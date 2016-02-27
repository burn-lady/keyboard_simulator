using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Keyboard_semulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int errors;
        private int time;
        
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            List<string> lines = MyTextReader.read(Application.StartupPath, MyTextReader.FILE_NAME);
            foreach (string line in lines)
            {
                listBoxTextFile.Items.Add(line);
            }
            
        }
    }
}
