using ParticleSim.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSim
{
    public partial class StartMenu : Form
    {
        public Dictionary<Button, Func<Form>> navigationMap; // initialising navigationMap
        public StartMenu()
        {
            InitializeComponent();

            // navigationMap is a dictionary required for the Navigate() method
            navigationMap = new Dictionary<Button, Func<Form>>
            {
                { btn1D, () => new _1DCollisions() },
                { btn2D, () => new _2DCollisions() },              
                { btnRelativistic, () => new RelativisticCollisions() },   
                { btnGaseous, () => new GaseousCollisions() },        
                { btnHelpGuide, () => new HelpGuide() },       
                { btnSettings, () => new Settings() }         
            };
        }

        // Navigate() is a single method that handles all button click events
        public void Navigate(object sender, EventArgs e)
        {
            // validation so that events only come from buttons
            if (!(sender is Button clickedButton))
            {
                return;
            }

            // checks if the clicked button is in the navigationMap, and opens corresponding form
            if (navigationMap.ContainsKey(clickedButton))
            {
                Form nextForm = navigationMap[clickedButton]();
                nextForm.Show();
                this.Hide();
            }
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
