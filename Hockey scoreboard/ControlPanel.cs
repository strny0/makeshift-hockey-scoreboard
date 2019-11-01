using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hockey_scoreboard
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form View = new View(); // starts the view panel
            View.ShowDialog();
        }
    }
}
