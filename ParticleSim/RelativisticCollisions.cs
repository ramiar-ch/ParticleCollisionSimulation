using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ParticleSim
{
    public partial class RelativisticCollisions : Form
    {
        private Random rng = new Random();              // random
        private Timer timer = new Timer();              // for particles
        private Stopwatch stopwatch = new Stopwatch();  // for clocks

        private DisplayFrame cmFrame;                   // objects initialised
        private DisplayFrame labFrame;
        private ParticleInitialiser init;
        private SimulationManager simManager;

        private int fps = 30;                           // frames per second
        private int mode = 3;                           // relativistic mode
        private bool running = false;                   // running flag

        private List<Particle> cmParticles = new List<Particle>();
        private List<Particle> labParticles = new List<Particle>();

        public RelativisticCollisions()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true); // enable double buffering to reduce flickering
            this.UpdateStyles();                                                                                                     // apply styles   
            var prop = typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);                  // reflection to set double buffering on panel   
            prop.SetValue(panelCM, true, null);                                                                                      // to reduce flickering
            prop.SetValue(panelLab, true, null);

            cmFrame = new DisplayFrame();
            labFrame = new DisplayFrame();
            init = new ParticleInitialiser();
            simManager = new SimulationManager();

            timer.Interval = 1000 / fps;
            timer.Tick += Timer_Tick;             // tick event added            

            Dictionary<string, Color> colors = new Dictionary<string, Color>
            {
                { "Random", Color.Empty },        // dictionary for colors
                { "Red", Color.Red },
                { "Green", Color.Green },
                { "Blue", Color.Blue },
                { "Yellow", Color.Yellow },
                { "Magenta", Color.Magenta },
                { "Cyan", Color.Cyan },
            };

            comboBoxColorA.DataSource = new BindingSource(colors, null);    // links combobox to colors dictionary
            comboBoxColorA.DisplayMember = "Key";
            comboBoxColorA.ValueMember = "Value";
            comboBoxColorA.SelectedIndex = 0;                               // default to "Random"

            comboBoxColorB.DataSource = new BindingSource(colors, null);
            comboBoxColorB.DisplayMember = "Key";
            comboBoxColorB.ValueMember = "Value";
            comboBoxColorB.SelectedIndex = 0;                                                           
        }

        // renders CM frame display area, starting with the grid, then particles
        private void panelCM_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;                                    
            
            if (checkBoxGrid.Checked == true)           // if option enabled
            {
                cmFrame.DrawGrid(g, panelCM);
            }

            if (checkBoxArrows.Checked == true)         // if option enabled
            {
                cmFrame.DrawArrows(g, cmParticles, panelCM, mode);
            }

            cmFrame.RenderParticles(g, cmParticles, panelCM, mode);     // draw cm particles
        }

        // renders lab frame display area, starting with the grid, then particles
        private void panelLab_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            if (checkBoxGrid.Checked == true)                                   // if option enabled
            {
                labFrame.DrawGrid(g, panelLab);
            }

            if (checkBoxArrows.Checked == true)                               // if option enabled
            {
                labFrame.DrawArrows(g, labParticles, panelLab, mode);
            }

            labFrame.RenderParticles(g, labParticles, panelLab, mode);          // draw lab particles
        }

        // navigates back to start menu
        private void buttonArrowBack_Click(object sender, EventArgs e)
        {
            Form form = new StartMenu();                                        // navigate back to start menu
            form.Show();
            this.Hide();
        }

        // clears input fields and resets selections
        private void ClearInputs()
        {
            textBoxMassA.Clear();                                                        // clear input boxes after use
            trackBarVelocityA.Value = trackBarVelocityA.Minimum;                         // reset trackbar to minimum
            textBoxVelocityA.Clear();                                                    // clear textboxes
            comboBoxColorA.SelectedIndex = 0;                                            // reset color selection to "Random"

            textBoxMassB.Clear();
            trackBarVelocityB.Value = trackBarVelocityB.Minimum;
            textBoxVelocityB.Clear();
            comboBoxColorB.SelectedIndex = 0;

            timer.Stop();
            stopwatch.Reset();

            panelLab.Invalidate();
            panelCM.Invalidate();
        }

        private void buttonCreateParticle_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(textBoxMassA.Text, out float massA))                     // parse and validate mass input 
            {
                if (textBoxMassA.Text == "")
                {
                    MessageBox.Show("Mass value cannot be empty.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxMassA.Focus();
                    ClearInputs();
                }                
                else
                {
                    MessageBox.Show("Fields must be numeric.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxMassA.Focus();
                    ClearInputs();
                }
                return;
            }

            if (!float.TryParse(textBoxMassB.Text, out float massB))                     // parse and validate mass input 
            {
                if (textBoxMassB.Text == "")
                {
                    MessageBox.Show("Mass value cannot be empty.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxMassB.Focus();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Fields must be numeric.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxMassB.Focus();
                    ClearInputs();
                }
                return;
            }

            if (massA <= 0)                                                                // mass must be positive
            {
                MessageBox.Show("Mass values must be positive.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMassA.Focus();
                ClearInputs();
                return;
            }
            else if (massA >= 1000000)
            {
                MessageBox.Show("Mass value too large.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMassA.Focus();
                ClearInputs();
                return;
            }

            if (massB <= 0)
            {
                MessageBox.Show("Mass values must be positive.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMassB.Focus();
                ClearInputs();
                return;
            }
            else if (massB >= 1000000)
            {
                MessageBox.Show("Mass value too large.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMassB.Focus();
                ClearInputs();
                return;
            }

            float velocityA = trackBarVelocityA.Value / 100f;                           // get speed from textbox
            float velocityB = trackBarVelocityB.Value / 100f;                                     

            if (velocityA >= 1f)                                                        // avoids lorentz factor going to infinity
            {
                velocityA = 0.999f;
            }

            if (velocityB >= 1f)
            {
                velocityB = 0.999f;
            }

            if (velocityA < 0f)
            {
                MessageBox.Show("Velocity must be non-negative.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxVelocityA.Focus();
                ClearInputs();
                return;
            }
            if (velocityB < 0f)
            {
                MessageBox.Show("Velocity must be non-negative.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxVelocityB.Focus();
                ClearInputs();
                return;
            }
            Color colorA = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256)); // random colour generation

            if (comboBoxColorA.SelectedValue is Color selColorA && selColorA != Color.Empty)
            {
                colorA = selColorA;
            }
            else
            {
                colorA = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256));   // fallback to random color
            }

            Color colorB = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256)); // random colour generation

            if (comboBoxColorB.SelectedValue is Color selColorB && selColorB != Color.Empty)
            {
                colorB = selColorB;
            }
            else
            {
                colorB = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256));  // fallback to random color
            }

            init.ClearParticles();                                                              // ensure lists are clear
            ClearInputs();

            Particle cmA = init.AddRelativisticParticle(panelCM, massA, velocityA, colorA);     // create particles
            Particle cmB = init.AddRelativisticParticle(panelCM, massB, velocityB, colorB);

            Particle labA = init.AddRelativisticParticle(panelLab, massA, velocityA, colorA);
            Particle labB = init.AddRelativisticParticle(panelLab, massB, velocityB, colorB);

            cmParticles.Add(cmA);                                                               // add particles
            cmParticles.Add(cmB);

            labParticles.Add(labA);
            labParticles.Add(labB);

            panelCM.Invalidate();                                                               // redraw panels
            panelLab.Invalidate();

            ClearInputs();                                                                      // clear input fields
        }

        private void StartSimulation()
        {
            StopSimulation();       // ensures existing simulation stopped first
            
            if (labParticles.Count == 0 || cmParticles.Count == 0)
            {
                MessageBox.Show("No particles to simulate. Please create particles first.", "No Particles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                running = false;    // reset running flag
                return;
            }
            running = true;         // set running flag

            timer.Start();          // start the timer
            stopwatch.Start();
        }

        private void StopSimulation()
        {
            running = false;        // switch running flag            
            timer.Stop();           // pause timers                   
            stopwatch.Stop();       // pause stopwatch
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (running)
            {
                labParticles = simManager.UpdateRelativisticParticles(labParticles, timer.Interval, 1);     // updates lab particles
                simManager.DetectCollisions(labParticles, mode, 1);                                         // checks collisions

                cmParticles = simManager.UpdateRelativisticParticles(cmParticles, timer.Interval, 2);       // updates cm particles
                simManager.DetectCollisions(cmParticles, mode, 2);

                ClockUpdate();                                                                              // update clocks
            }
                
            panelCM.Invalidate();                                                                           // redraw panels
            panelLab.Invalidate();
        }

        // button to start/pause simulation
        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (running)                                // if simulation running when button pressed
            {
                StopSimulation();                       // stop the simulation
                buttonRun.Text = "RUN";                 // change the text
            }
            else
            {
                StartSimulation();                      // otherwise start simulation
                buttonRun.Text = "PAUSE";               // change the text
            }
        }

        // button to clear all particles from the simulation
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputs();

            labParticles.Clear();       // clear particle lists
            cmParticles.Clear();
            init.ClearParticles();

            panelCM.Invalidate();       // redraw panels
            panelLab.Invalidate();

            timer.Stop();               // stop timers
            stopwatch.Reset();
        }

        // updates lab and cm clocks based on time dilation
        private void ClockUpdate()
        {
            TimeSpan elapsedLab = stopwatch.Elapsed;                                                                    // lab frame time
            labelClockLab.Text = string.Format("Lab Time: {0:D2}:{1:D3}", elapsedLab.Seconds, elapsedLab.Milliseconds); // update lab clock

            float velocityCM = simManager.GetCMVelocity(labParticles);                                                  // get CoM velocity
            float gamma = 1f / (float)Math.Sqrt(1 - (velocityCM * velocityCM));                                         // lorentz factor

            TimeSpan elapsedCM = TimeSpan.FromTicks((long)(stopwatch.ElapsedTicks / gamma));                            // time dilation formula
            labelClockCM.Text = string.Format("CoM Time: {0:D2}:{1:D3}", elapsedCM.Seconds, elapsedCM.Milliseconds);    // update cm clock
        }

        // handles velocity A trackbar scroll event
        private void trackBarVelocityA_Scroll(object sender, EventArgs e)
        {
            if (trackBarVelocityA.Value == 100)                                     // avoid velocity being 1c
            {
                trackBarVelocityA.Value = 99;
            }
            textBoxVelocityA.Text = $"{(float)trackBarVelocityA.Value / 100f}c";    // update text
        }

        // handles velocity B trackbar scroll event
        private void trackBarVelocityB_Scroll(object sender, EventArgs e)
        {
            if (trackBarVelocityB.Value == 100)                                     // avoid velocity being 1c
            {
                trackBarVelocityB.Value = 99;
            }
            textBoxVelocityB.Text = $"{(float)trackBarVelocityB.Value / 100f}c";    // update text
        }

        // handles velocity A textbox change event
        private void textBoxVelocityA_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxVelocityA.Text, out float velocityA))         // parse and validate velocity input 
            {   
                if (0 <= velocityA && velocityA < 100)                              // between trackbar values
                {
                    trackBarVelocityA.Value = (int)(velocityA);
                }
                else if (velocityA >= 100)                                          // avoid lorentz factor going to infinity
                {
                    trackBarVelocityA.Value = 99;
                }
            }
        }

        // handles velocity B textbox change event
        private void textBoxVelocityB_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxVelocityB.Text, out float velocityB))         // parse and validate velocity input 
            {   
                if (0 <= velocityB && velocityB < 100)                              // between trackbar values
                {
                    trackBarVelocityB.Value = (int)(velocityB);
                }
                else if (velocityB >= 100)
                {
                    trackBarVelocityB.Value = 99;                                   // avoid lorentz factor going to infinity
                }
            }
        }

        // grid enable/disable
        private void checkBoxGrid_CheckedChanged(object sender, EventArgs e)
        {
            panelCM.Invalidate();
            panelLab.Invalidate();
        }

        // velocity arrow enable/disable
        private void checkBoxArrows_CheckedChanged(object sender, EventArgs e)
        {
            panelCM.Invalidate();
            panelLab.Invalidate();
        }

        // only digits, dp and control allowed
        private void textBoxVelocityA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar));
        }

        // only digits, dp and control allowed
        private void textBoxVelocityB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar));
        }
    }
}
