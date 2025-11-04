using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSim
{
    public partial class OneDCollisions : Form
    {
        private DisplayFrame displayFrame;
        private ParticleInitialiser init;
        private SimulationManager simManager;

        private Random rng = new Random();       

        private Timer timer;
        private int fps = 30;
        private bool running = false;
        
        public OneDCollisions()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true); // enable double buffering to reduce flickering
            this.UpdateStyles();                                                                                                     // apply styles   
            var prop = typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);                  // reflection to set double buffering on panel   
            prop?.SetValue(panelDisplayArea, true, null);                                                                            // to reduce flickering   

            displayFrame = new DisplayFrame();
            init = new ParticleInitialiser();
            simManager = new SimulationManager();

            simManager.SetBounds(panelDisplayArea.Width);                                                                               
            panelDisplayArea.Invalidate();
        }                    

        private void panelDisplayArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;            

            if (checkBoxGrid.Checked == true)           // if option enabled
            {
                Pen gridPen = new Pen(Color.LightSalmon);

                int gridlines = 100;                    // how many gridlines drawn horizontally and vertically
                int spacing = 10;                       // space between gridlines in pixels

                for (int i = 0; i <= gridlines; i++)    // draw horizontal gridlines
                {
                    g.DrawLine(gridPen, i * spacing, 0, i * spacing, panelDisplayArea.Height);
                }

                for (int j = 0; j <= gridlines; j++)    // draw vertical gridlines
                {
                    g.DrawLine(gridPen, 0, j * spacing, panelDisplayArea.Width, j * spacing);
                }
            }

            List<Particle> particles = init.GetParticles();
            displayFrame.RenderParticles(g, particles, panelDisplayArea);
        }

        private void textBoxMass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allows digits, decimal point and control characters
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar)); 
        }

        private void textBoxSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allows digits, decimal point and control characters
            // also allows negative sign for speed so particles can move left
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar));
        }
        

        private void buttonCreateParticle_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(textBoxMass.Text, out float mass) )                     // parse and validate mass input 
            {                 
                MessageBox.Show("Fields must be numeric.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMass.Focus();
                ClearInputs();
                return;
            }

            if (!float.TryParse(textBoxSpeed.Text, out float speed))                    // parse and validate speed input
            {   
                MessageBox.Show("Fields must be numeric.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSpeed.Focus();
                ClearInputs();
                return;
            }

            if (mass <= 0f)
            {
                MessageBox.Show("Mass value must be positive.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMass.Focus();
                ClearInputs();
                return;
            }
            if (speed.Equals(null))
            {
                MessageBox.Show("Speed value cannot be empty.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSpeed.Focus();
                ClearInputs();
                return;
            }

            // string
            // -20

            float x = (float)rng.NextDouble() * panelDisplayArea.Width;                 // random x position within panel bounds
            float y = (float)rng.NextDouble() * panelDisplayArea.Height;                // random y position within panel bounds

            Color color = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256));  // random colour generation

            Dictionary<string, object> particleConfig = new Dictionary<string, object>  // this dictionary is used to generate a 
            {                                                                           // full particle profile                 
                { "mass", mass },                                                       // before addding it to the list
                { "speed", speed },
                { "position", new Vector2(x, y) },
                { "color", color }
            };

            init.AddNewParticle(particleConfig);                                        // adds new particle to the list
            panelDisplayArea.Invalidate();                                              // refresh

            ClearInputs();
        }      
        
        private void ClearInputs()
        {
            textBoxMass.Clear();                                                        // clear input boxes after use
            textBoxSpeed.Clear();
        }

        private void buttonRunReset_Click(object sender, EventArgs e)
        {
            if (running)                                // if simulation is running when the button is pressed
            {
                StopSimulation();                       // stop the simulation
                buttonRunReset.Text = "RUN";            // change the text
            }
            else
            {
                StartSimulation();                      // otherwise start simulation
                buttonRunReset.Text = "PAUSE";          // change the text
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            init.ClearParticles();                      // particle list is cleared and made empty
            panelDisplayArea.Invalidate();              // redraw the display area
        }

        private void StartSimulation()
        {
            StopSimulation();                                   // ensures that any existing simulation is stopped first

            List<Particle> particles = init.GetParticles();     // gets particles

            running = true;                                     // set running flag
            timer = new Timer();
            timer.Interval = 1000 / fps;                        // set timer interval based on fps
            timer.Tick += (s, e) =>                             // on each tick of the timer
            {
                if (running)                                    
                {   
                    simManager.DetectCollisions(particles);     // check for collisions between particles
                    simManager.UpdateParticles(particles, timer.Interval);   // update particle positions based on their velocities
                }
                panelDisplayArea.Invalidate();                  // redraw display area
            };
            timer.Start();                                      // start the timer
        }

        private void StopSimulation()
        {   
            running = false;                                    // clear running flag
            if (timer != null)                                  // if timer exists
            {
                timer.Stop();                                   // stop timer
                timer.Tick -= null;                             // remove all event handlers                
                timer.Dispose();                                // dispose of timer
                timer = null;                                   // clear timer variable        
            }                           
        }        
    }
}
