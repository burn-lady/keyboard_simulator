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
            adaptSizeFormAndTextBox();
        }

        private void adaptSizeFormAndTextBox()
        {
            this.Width = SystemInformation.PrimaryMonitorSize.Width;
            this.Height = SystemInformation.PrimaryMonitorSize.Height - 50;
            this.tutorialTextBox.Height = SystemInformation.PrimaryMonitorSize.Height - 100;
            this.tutorialTextBox.Width = SystemInformation.PrimaryMonitorSize.Width - 50;
        }

        private void AboutProgramForm_Load(object sender, EventArgs e)
        {
            loadTextForTextBox();
        }

        private void loadTextForTextBox()
        {
            try
            {
                StringBuilder SB = new StringBuilder();
                List<string> lines = MyTextReader.read(MyTextReader.TUTORIAL_PROGRAM_FILE);
                foreach (string line in lines) SB.Append(line + "\n\r");

                tutorialTextBox.Text = SB.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Отсутствует файл со справкой");
            }
        }

        private void tutorialTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
