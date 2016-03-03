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
        int hitClicks;
        int totalClicks;
        int timeSimulation;
        int step;
        int maxWords;

        string task;
        int timeLimiter;
        bool run;


        private void createVariables ()
        {
            hitClicks = 0;
            totalClicks = 0;
            timeSimulation = 0;
            step = 0;
            maxWords = 0;
        }

        public Form1()
        {
            InitializeComponent();
            createVariables();
            run = false;
        }




        private void startButtonClick(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            List<string> lines = MyTextReader.read(Application.StartupPath, MyTextReader.FILE_NAME);
            foreach (string line in lines)
            {
                listBoxTextFile.Items.Add(line);
            }
            task = Controller.generateTask(lines);
            taskLabel.Text = Controller.visibleLine(task, 0); //step = 0
              
        }

        private void hitClickEvent()
        {
            step++;
            hitClicks++;
            totalClicks++;
            taskLabel.Text = Controller.visibleLine(task, step);
            updateInterface();
        }

        private void errorCLickEvent()
        {
            totalClicks++;
            updateInterface();
        }

        private void updateInterface()
        {
            totalClickLabel.Text = "Всего: "  + totalClicks + "  Попаданий: " + hitClicks  ;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (task[step] == e.KeyChar) hitClickEvent();
            else errorCLickEvent();
        
        }
    }
}
