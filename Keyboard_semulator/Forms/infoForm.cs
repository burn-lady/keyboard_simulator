using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_semulator.Forms
{
    public partial class InfoForm : Form
    {
        public InfoForm(string message)
        {
            InitializeComponent();

            label1.Text = message;
            radioButton1.Text = message;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
