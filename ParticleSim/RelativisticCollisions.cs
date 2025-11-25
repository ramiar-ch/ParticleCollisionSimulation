using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSim
{
    public partial class RelativisticCollisions : Form
    {
        private Random rng = new Random();
        private Timer timerLab = new Timer();     
        private Timer timerCM = new Timer(); 
        private Stopwatch stopwatch = new Stopwatch();

        private DisplayFrame cmFrame;
        private DisplayFrame labFrame;
        private ParticleInitialiser init;
        private SimulationManager simManager;

        private int fps = 30;
        private int mode = 3;
        private bool running = false;

        private List<Particle> cmParticles = new List<Particle>();
        private List<Particle> labParticles = new List<Particle>();

        public RelativisticCollisions()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true); // enable double buffering to reduce flickering
            this.UpdateStyles();                                                                                                     // apply styles   
            var prop = typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);                  // reflection to set double buffering on panel   
            prop.SetValue(panelCM, true, null);                                                                                     // to reduce flickering
            prop.SetValue(panelLab, true, null);

            cmFrame = new DisplayFrame();
            labFrame = new DisplayFrame();
            init = new ParticleInitialiser();
            simManager = new SimulationManager();

            simManager.SetBounds(panelCM.Width, panelCM.Height);

            timerLab = new Timer();
            timerLab.Interval = 1000 / fps;
            timerLab.Tick += TimerLab_Tick;
            

            Dictionary<string, Color> colors = new Dictionary<string, Color>
            {
                { "Random", Color.Empty },
                { "Red", Color.Red },
                { "Green", Color.Green },
                { "Blue", Color.Blue },
                { "Yellow", Color.Yellow },
                { "Magenta", Color.Magenta },
                { "Cyan", Color.Cyan },
            };

            comboBoxColorA.DataSource = new BindingSource(colors, null);
            comboBoxColorA.DisplayMember = "Key";
            comboBoxColorA.ValueMember = "Value";
            comboBoxColorA.SelectedIndex = 0;                                                // default to "Random"

            comboBoxColorB.DataSource = new BindingSource(colors, null);
            comboBoxColorB.DisplayMember = "Key";
            comboBoxColorB.ValueMember = "Value";
            comboBoxColorB.SelectedIndex = 0;                                                // default to "Random"

            timerLab.Interval = 1000 / fps;
            timerCM.Interval = 1000 / fps;
        }




        private void panelCM_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            cmFrame.RenderParticles(g, cmParticles, panelCM, mode);
        }

        private void panelLab_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            labFrame.RenderParticles(g, labParticles, panelLab, mode);
        }

        private void buttonArrowBack_Click(object sender, EventArgs e)
        {
            Form form = new StartMenu();          // navigate back to start menu
            form.Show();
            this.Hide();
        }

        private void ClearInputs()
        {
            textBoxMassA.Clear();                                                        // clear input boxes after use
            trackBarVelocityA.Value = trackBarVelocityA.Minimum;                                  // reset trackbar to minimum
            comboBoxColorA.SelectedIndex = 0;                                            // reset color selection to "Random"

            textBoxMassB.Clear();
            trackBarVelocityB.Value = trackBarVelocityB.Minimum;                                  // reset trackbar to minimum
            comboBoxColorB.SelectedIndex = 0;

        }

        private void buttonCreateParticle_Click(object sender, EventArgs e)
        {

            if (!float.TryParse(textBoxMassA.Text, out float massA))                     // parse and validate mass input 
            {
                MessageBox.Show("Fields must be numeric.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMassA.Focus();
                ClearInputs();
                return;
            }

            if (!float.TryParse(textBoxMassB.Text, out float massB))                     // parse and validate mass input 
            {
                MessageBox.Show("Fields must be numeric.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMassB.Focus();
                ClearInputs();
                return;
            }

            float velocityA = trackBarVelocityA.Value / 100f;                    // get speed from trackbar
            float velocityB = trackBarVelocityB.Value / 100f;                    // get speed from trackbar            

            Color colorA = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256));  // random colour generation

            if (comboBoxColorA.SelectedValue is Color selColorA && selColorA != Color.Empty)
            {
                colorA = selColorA;
            }
            else
            {
                colorA = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256));  // fallback to random color
            }

            Color colorB = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256));  // random colour generation

            if (comboBoxColorB.SelectedValue is Color selColorB && selColorB != Color.Empty)
            {
                colorB = selColorB;
            }
            else
            {
                colorB = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256));  // fallback to random color
            }

            init.ClearParticles();

            Particle cmA = init.AddRelativisticParticle(panelCM, massA, velocityA, colorA);
            Particle cmB = init.AddRelativisticParticle(panelCM, massB, velocityB, colorB);

            Particle labA = init.AddRelativisticParticle(panelLab, massA, velocityA, colorA);
            Particle labB = init.AddRelativisticParticle(panelLab, massB, velocityB, colorB);

            cmParticles.Add(cmA);
            cmParticles.Add(cmB);

            labParticles.Add(labA);
            labParticles.Add(labB);

            panelCM.Invalidate();
            panelLab.Invalidate();

            ClearInputs();
        }

        private void StartSimulation()
        {
            StopSimulation();                                   // ensures that any existing simulation is stopped first
            simManager.SetBounds(panelLab.Width, panelLab.Height);
            
            running = true;                                     // set running flag     
            timerLab.Start();                                      // start the timer
            stopwatch.Restart();
        }

        private void StopSimulation()
        {
            running = false;                                    // clear running flag
            if (timerLab != null)                                  // if timer exists
            {
                timerLab.Stop();                                   // stop timer                      
            }
            stopwatch.Stop();
        }

        private void TimerLab_Tick(object sender, EventArgs e)
        {
            if (running)
            {
                // update lab frame particles and collisions (lab frame uses labParticles)
                labParticles = simManager.UpdateRelativisticParticles(labParticles, timerLab.Interval, 1);
                simManager.DetectCollisions(labParticles, mode, true);

                // update CoM frame particles and collisions (cm frame uses cmParticles)
                cmParticles = simManager.UpdateRelativisticParticles(cmParticles, timerCM.Interval, 2);
                simManager.DetectCollisions(cmParticles, mode, false);

                ClockUpdate(); // now called every tick so clocks update synchronously with simulation
            }

            panelCM.Invalidate();
            panelLab.Invalidate();
        }

        

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (running)                                // if simulation is running when the button is pressed
            {
                StopSimulation();                       // stop the simulation
                buttonRun.Text = "RUN";            // change the text
            }
            else
            {
                StartSimulation();                      // otherwise start simulation
                buttonRun.Text = "PAUSE";          // change the text
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            init.ClearParticles();
            panelCM.Invalidate();
            panelLab.Invalidate();
        }

        private void ClockUpdate()
        {
            TimeSpan elapsedLab = stopwatch.Elapsed;
            labelClockLab.Text = string.Format("Lab Time: {0:D2}:{1:D3}",
                elapsedLab.Seconds, elapsedLab.Milliseconds);

            float velocityCM = simManager.GetCMVelocity(labParticles);
            float gamma = 1f / (float)Math.Sqrt(1 - (velocityCM * velocityCM));

            TimeSpan elapsedCM = TimeSpan.FromTicks((long)(stopwatch.ElapsedTicks / gamma));
            labelClockCM.Text = string.Format("CoM Time: {0:D2}:{1:D3}",
                elapsedCM.Seconds, elapsedCM.Milliseconds);
        }
    }
}
