using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mode4Button_Click(object sender, EventArgs e)
        {
            ChooseImageMode4 form = new ChooseImageMode4();
            form.Show();
        }
    }
}
