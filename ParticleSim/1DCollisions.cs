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
    public partial class _1DCollisions : Form
    {
        private DisplayFrame displayFrame;
        private ParticleInitialiser init;
        private SimulationManager simManager;

        private Random rng = new Random();       

        private Timer timer;
        private int fps = 30;
        private bool running = false;
        private float restitution; 
        private int mode = 1; // 1D mode

        private bool draggingParticle = false;

        private Particle selectedParticle = null;
        private Particle particleToModify = null;

        public _1DCollisions()
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
                                                                                          
            Dictionary<string, Color> colors = new Dictionary<string, Color>
            {
                { "Random", Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256)) },
                { "Red", Color.Red },
                { "Green", Color.Green },
                { "Blue", Color.Blue },
                { "Yellow", Color.Yellow },
                { "Magenta", Color.Magenta },
                { "Cyan", Color.Cyan },
            };

            comboBoxColor.DataSource = new BindingSource(colors, null);
            comboBoxColor.DisplayMember = "Key";
            comboBoxColor.ValueMember = "Value";
            comboBoxColor.SelectedIndex = 0;                                                // default to "Random"
            
            comboBoxColorModifier.DataSource = new BindingSource(colors, null);
            comboBoxColorModifier.DisplayMember = "Key";
            comboBoxColorModifier.ValueMember = "Value";
            comboBoxColorModifier.SelectedIndex = -1;                                       // default to no selection
        }

        private void panelDisplayArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (checkBoxGrid.Checked == true)           // if option enabled
            {
                displayFrame.DrawGrid(g, panelDisplayArea);

            }

            List<Particle> particles = init.GetParticles();
            displayFrame.RenderParticles(g, particles, panelDisplayArea, mode);

            if (checkBoxArrows.Checked == true)
            {
                displayFrame.DrawArrows(g, particles, panelDisplayArea, mode);
            }
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

            float x = (float)rng.NextDouble() * panelDisplayArea.Width;                 // random x position within panel bounds
            float y = (float)rng.NextDouble() * panelDisplayArea.Height;                // random y position within panel bounds

            Color color = Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256));  // random colour generation

            if (comboBoxColor.SelectedValue is Color selColor)
            {
                color = selColor;
            }
            
            Dictionary<string, object> particleConfig = new Dictionary<string, object>  // this dictionary is used to generate a 
            {                                                                           // full particle profile                 
                { "mass", mass },                                                       // before addding it to the list
                { "speed", speed },
                { "position", new Vector2(x, y) },
                { "color", color }
            };

            init.AddNewParticle(particleConfig, mode);                                        // adds new particle to the list
            panelDisplayArea.Invalidate();                                              // refresh

            ClearInputs();
        }      
        
        private void ClearInputs()
        {
            textBoxMass.Clear();                                                        // clear input boxes after use
            textBoxSpeed.Clear();
            comboBoxColor.SelectedIndex = 0;                                            // reset color selection to "Random"
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

        private void checkBoxGrid_CheckedChanged(object sender, EventArgs e)
        {
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
                    simManager.DetectCollisions(particles, mode);     // check for collisions between particles
                    simManager.UpdateParticles(particles, timer.Interval, mode);   // update particle positions based on their velocities
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

        private void trackBarElasticity_Scroll(object sender, EventArgs e)
        {
            restitution = trackBarElasticity.Value / (float)trackBarElasticity.Maximum;   // get restitution value between 0 and 1          
            simManager.SetElasticity(restitution);                                        // update simulation manager with new restitution value
        }

        private void panelDisplayArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)                          // only respond to left mouse button
            {
                return;
            }

            List<Particle> particles = init.GetParticles();             // get current particles
            Vector2 mousePos = new Vector2(e.X, e.Y);                   // mouse position as Vector2

            float arrowLengthScale = 0.4f;                              // pixels per m/s
            float headLengthScale = 1f;                                 // arrowhead length for radius 1px
            float headWidthScale = 0.8f;                                // arrowhead width for radius 1px

            foreach (Particle p in particles)                           // check each particle
            {
                float radius = p.radius;                                // radius of the particle
                float headLength = radius * headLengthScale;            // length of arrowhead
                float headWidth = radius * headWidthScale;              // width of arrowhead

                Vector2 velocity = p.velocity;                             // get velocity vector
                float speed = velocity.Length();                            // speed is the length of the velocity vector

                Vector2 normal = velocity / speed;                          // normalize velocity to get direction
                Vector2 start = p.position;                                 // arrow starts at particle position
                Vector2 end = start + (normal * speed * arrowLengthScale);  // end point based on speed and direction

                Vector2 baseCenter = end - normal * headLength;             // center point of the triangle base
                Vector2 perp = new Vector2(-normal.Y, normal.X);            // perpendicular to direction

                Vector2 left = baseCenter + perp * (headWidth * 0.5f);      // left base point
                Vector2 right = baseCenter - perp * (headWidth * 0.5f);     // right base point

                float centerX = (left.X + right.X + end.X) / 3f;          // center of triangle x-coordinate
                float centerY = (left.Y + right.Y + end.Y) / 3f;          // center of triangle y-coordinate

                float distFromCenter = Vector2.Distance(mousePos, new Vector2(centerX, centerY)); // distance from mouse to center

                if (distFromCenter <= headWidth)                          // approximate check using distance to center of triangle
                {
                    velocity.X = -velocity.X;
                    p.velocity = velocity;                                // reverse x-velocity to modify speed
                    panelDisplayArea.Invalidate();                        // refresh display area
                    return;
                }

                float dist = Vector2.Distance(mousePos, p.position);    // distance from mouse to particle center
                if (dist <= p.radius)                                   // if within particle radius
                {
                    selectedParticle = p;                               // select this particle
                    draggingParticle = true;                            // enable dragging
                    particleToModify = p;                               // set particle to modify

                    textBoxMassModifier.Text = p.mass.ToString();       // fill modifier fields with current values
                    textBoxSpeedModifier.Text = Math.Round(p.velocity.Length()).ToString();

                    try
                    {
                        comboBoxColorModifier.SelectedValue = p.color;  // set color selection to current particle color
                    }
                    catch
                    {
                        comboBoxColorModifier.SelectedIndex = 0;        // fallback to "Random" if color not found
                    }

                    StopSimulation();                                   // stop simulation while dragging
                    return;
                }
            }
        }

        private void panelDisplayArea_MouseMove(object sender, MouseEventArgs e)
        {
            int mousePosX = e.X;                               // current mouse position

            if (draggingParticle != true || selectedParticle == null)               // if not dragging or no particle selected
            {
                return;
            }

            float newX = e.X;                               // new position based on mouse
            float radius = selectedParticle.radius;         // radius of selected particle

            if (newX < radius)                              // constrain within panel bounds
            {
                newX = radius;
            }
            if (newX > panelDisplayArea.Width - radius)
            {
                newX = panelDisplayArea.Width - radius;
            }

            selectedParticle.position.X = newX;           // update particle position
            panelDisplayArea.Invalidate();
        }

        private void panelDisplayArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (draggingParticle == true || selectedParticle != null)           // if not dragging or no particle selected
            {
                draggingParticle = false;                                           // disable dragging
                selectedParticle = null;                                            // clear selected particle
                return;
            }
        }

        private void buttonModifyParticle_Click(object sender, EventArgs e)
        {
            if (particleToModify == null)                                                           // no particle selected to modify
            {
                MessageBox.Show("No particle selected to modify. Click on a particle to select it.", "No particle selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(textBoxMassModifier.Text, out float newMass))                       // parse and validate mass input 
            {
                MessageBox.Show("Fields must be numeric.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMassModifier.Focus();
                return;
            }

            if (!float.TryParse(textBoxSpeedModifier.Text, out float newSpeed))                     // parse and validate speed input
            {
                MessageBox.Show("Fields must be numeric.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSpeedModifier.Focus();
                return;
            }

            Vector2 newVelocity = new Vector2(newSpeed, 0);                                                      // new velocity vector

            particleToModify.mass = newMass;                          // update mass
            particleToModify.velocity = newVelocity;                  // update velocity

            if (comboBoxColorModifier.SelectedValue is Color selColor)
            {
                particleToModify.color = selColor;                    // update color
            }

            init.ScaleRadii(init.GetParticles(), mode);                     // rescale radii based on new mass
            panelDisplayArea.Invalidate();                            // refresh display
        }

        private void buttonArrowBack_Click(object sender, EventArgs e)
        {
            Form form = new StartMenu();          // navigate back to start menu
            form.Show();
            this.Hide();
        }
    }
}
