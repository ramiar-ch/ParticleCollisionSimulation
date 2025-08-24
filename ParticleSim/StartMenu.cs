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

            // navigationMap is a variable required for the Navigate() method
            navigationMap = new Dictionary<Button, Func<Form>>
            {
                { btn1D, () => new OneDCollisions() },
                { btn2D, () => new OneDCollisions() },              // replace this with TwoDCollisions()
                { btnRelativistic, () => new OneDCollisions() },    // replace this with RelativisticCollisions()
                { btnGaseous, () => new OneDCollisions() }          // replace this with GaseousCollisions()
            };
        }

        // Navigate() is a single method that handles all button click events
        private void Navigate(object sender, EventArgs e)
        {
            if (!(sender is Button clickedButton))
            {
                return;
            }

            if (navigationMap.ContainsKey(clickedButton))
            {
                Form nextForm = navigationMap[clickedButton]();
                nextForm.Show();
                this.Hide();
            }
        }
        
    }
}
