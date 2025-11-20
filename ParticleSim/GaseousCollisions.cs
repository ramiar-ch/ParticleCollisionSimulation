using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSim
{
    public partial class GaseousCollisions : Form
    {
        private DisplayFrame displayFrame;
        private ParticleInitialiser init;
        private SimulationManager simManager;

        private Random rng = new Random();

        private Timer timer;
        private int fps = 30;
        private bool running = false;        
        private float restitution;
        private float heat;
        private int mode = 4; // gas mode

        public GaseousCollisions()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true); // enable double buffering to reduce flickering
            this.UpdateStyles();                                                                                                     // apply styles   
            var prop = typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);                  // reflection to set double buffering on panel   
            prop?.SetValue(panelDisplayArea, true, null);                                                                            // to reduce flickering   

            displayFrame = new DisplayFrame();
            init = new ParticleInitialiser();
            simManager = new SimulationManager();

            simManager.SetBounds(panelDisplayArea.Width, panelDisplayArea.Height);
            panelDisplayArea.Invalidate();

            trackBarElasticity.Minimum = 0;                                                 // set trackbar range
            trackBarElasticity.Maximum = 1000;                                              // use 0-1000 scale for more precise control
            trackBarElasticity.Value = trackBarElasticity.Maximum;                          // default to max elasticity (1.0)
            trackBarElasticity.TickStyle = TickStyle.None;                                  // hide ticks
            restitution = trackBarElasticity.Value / (float)trackBarElasticity.Maximum;     // initial restitution value             
        
            trackBarHeat.Minimum = 0;                                                       // set trackbar range
            trackBarHeat.Maximum = 1000;                                                    // use 0-1000 scale for more precise control
            trackBarHeat.Value = trackBarHeat.Maximum / 2;                                  // default to middle heat (0.5)
            trackBarHeat.TickStyle = TickStyle.None;                                        // hide ticks
            heat = trackBarHeat.Value / (float)trackBarHeat.Maximum;                        // initial heat value

        }

        private void panelDisplayArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (checkBoxGrid.Checked == true)           // if grid enabled
            {
                displayFrame.DrawGrid(g, panelDisplayArea);

            }

            List<Particle> particles = init.GetParticles();
            displayFrame.RenderParticles(g, particles, panelDisplayArea, mode);

            if (checkBoxArrows.Checked == true)         // if arrows enabled
            {
                displayFrame.DrawArrows(g, particles, panelDisplayArea, mode);
            }
        }

        private void textBoxMass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allows digits, decimal point and control characters
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || char.IsControl(e.KeyChar));
        }



        private void textBoxAvgSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allows digits, decimal point and control characters
            // also allows negative sign for speed so particles can move left
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-' || char.IsControl(e.KeyChar));
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(textBoxMass.Text, out float mass))                              // parse and validate mass input 
            {
                MessageBox.Show("Fields must be numeric.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMass.Focus();
                ClearInputs();
                return;
            }

            if (!float.TryParse(textBoxAvgSpeed.Text, out float avgSpeed))                      // parse and validate speed input 
            {
                MessageBox.Show("Fields must be numeric.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAvgSpeed.Focus();
                ClearInputs();
                return;
            }

                
            if (!int.TryParse(textBoxQuantity.Text, out int quantity))                          // parse and validate quantity input
            {
                MessageBox.Show("Quantity must be a positive integer.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxQuantity.Focus();
                ClearInputs();
                return;
            }
            
            
            for (int i = 0; i < quantity; i++)
            {
                int[] bounds = new int[2];                                                      // area bounds
                bounds[0] = panelDisplayArea.Width;
                bounds[1] = panelDisplayArea.Height;

                float radius = init.GetGasRadius(quantity, bounds);                             // get radius based on quantity

                Vector2 position = simManager.GetValidPosition(radius);                         // get position not overlapping 

                Dictionary<string, object> particleConfig = new Dictionary<string, object>      // create config dictionary
                {
                    { "mass", mass },
                    { "speed", avgSpeed },
                    { "position", position},
                    { "color", Color.Red }
                };
                    
                Particle newParticle = init.AddGasParticle(simManager, particleConfig, mode, heat); // create new particle

                simManager.InsertParticleToQuadtree(newParticle);                               // insert particle to quadtree
            }
            
            panelDisplayArea.Invalidate();                                                      // redraw display area
            ClearInputs();                                                                                  
        }

        private void ClearInputs()
        {
            textBoxMass.Clear();                                                        // clear input boxes after use
            textBoxAvgSpeed.Clear();
            textBoxQuantity.Clear();
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
            simManager.ClearQuadtree();                 // clear quadtree

            panelDisplayArea.Invalidate();              // redraw the display area
        }

        private void StartSimulation()
        {
            StopSimulation();                                   // ensures that any existing simulation is stopped first

            List<Particle> particles = init.GetParticles();     // gets particles

            running = true;                                     // set running flag
            timer = new Timer
            {
                Interval = 1000 / fps                        // set timer interval based on fps
            };
            timer.Tick += (s, e) =>                             // on each tick of the timer
            {
                if (running)
                {
                    simManager.DetectCollisions(particles, mode);     // check for collisions between particles
                    simManager.UpdateParticles(particles, timer.Interval, heat);   // update particle positions based on their velocities
                
                    float pressure = simManager.GetPressure();          // calculate pressure

                    textBoxPressure.Text = Math.Round(pressure, 2).ToString();   // update pressure textbox
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

        private void buttonArrowBack_Click(object sender, EventArgs e)
        {
            Form form = new StartMenu();          // navigate back to start menu
            form.Show();
            this.Hide();
        }

        private void trackBarHeat_Scroll(object sender, EventArgs e)
        {
            heat = trackBarHeat.Value / (float)trackBarHeat.Maximum;    // update heat value based on trackbar position
            textBoxHeat.Text = Math.Round(heat * 100.0f).ToString();    // update heat textbox
        }

        private void trackBarElasticity_Scroll(object sender, EventArgs e)
        {

        }        
    }
}
