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
    public partial class TutorialProgramForm : Form
    {
        public TutorialProgramForm()
        {
            InitializeComponent();
            //this.Width = System.D

        }

        private void AboutProgramForm_Load(object sender, EventArgs e)
        {
            StringBuilder SB = new StringBuilder();
            List<string> lines = MyTextReader.read(MyTextReader.TUTORIAL_PROGRAM_FILE);
            foreach (string line in lines) SB.Append(line + "\n\r");

            tutorialTextBox.Text = SB.ToString();
        }


    }
}
