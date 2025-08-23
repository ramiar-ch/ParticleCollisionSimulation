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
        private Dictionary<Button, Func<Form>> navigationMap;
        public StartMenu()
        {
            InitializeComponent();
        }

        
    }
}
