using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keyboard_semulator.Data;



namespace Keyboard_semulator
{
    public partial class Form1 : Form
    {
        int errorClicks;
        int totalClicks;
        int sessionTime;
        int step;
        int maxWords;
        


        string task = " ";
        bool run;
        bool unlockTextBox; // костыль

        string userName;
        string sessionType;
        public Dictionary<char, int> errorLetters;

        private void createVariables ()
        {
            errorLetters = new Dictionary<char, int>();
            errorClicks = 0;
            totalClicks = 0;
            sessionTime = 0;
            step = 0;           

            maxWords = 7;
            unlockTextBox = true;
            run = true;

            timeLabel.Text = "Текущее время: 0";
        }

        private void createComponents()
        {
            taskLabel.Font = new Font("Arial", 17, FontStyle.Italic);
        }

        public Form1(string userName)
        {
            InitializeComponent();
            createComponents();
            createVariables();

            this.userName = userName;
            userTextLabel.Text = "Текущий пользователь: " + userName;
            run = false;            
        }


        public void addErrorLetter(char letter)
        {
            if (errorLetters.ContainsKey(letter)) errorLetters[letter]++;
            else errorLetters.Add(letter, 1);
        }

        private void startButtonClick(object sender, EventArgs e)
        {
            createVariables();
            simulationTimer.Enabled = true;          
            List<string> lines = null;

            if (wordsRadioButton.Checked)
            {
                lines = MyTextReader.read(MyTextReader.WORDS);
                task = Controller.generateTask_Words(lines, maxWords);
                sessionType = Session.WORDS_SESSION;
            }
            if (textRadioButton.Checked)
            {
                lines = MyTextReader.read(MyTextReader.CONTROL_TEXT);
                task = Controller.generateTask_ControlText(lines);
                sessionType = Session.CONTROL_TEXT_SESSION;
            }          

            taskLabel.Text = Controller.visibleLine(task, 0); //step = 0
            textBox1.Focus();
          
              
        }

        private void hitClickEvent()
        {
            step++;
            totalClicks++;
            taskLabel.Text = Controller.visibleLine(task, step);
            updateInterface();
        }

        private void errorCLickEvent(char letter)
        {
            totalClicks++;
            errorClicks++;
            updateInterface();
            addErrorLetter(letter);
        }

        private void updateInterface()
        {
            totalClickLabel.Text = "Всего: "  + totalClicks + "  Ошибок: " + errorClicks  ;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (task[step] == e.KeyChar) hitClickEvent();
            else errorCLickEvent(); */
        
        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (task[step].ToString() == e.KeyValue.ToString()) hitClickEvent();
            else errorCLickEvent();
            listBoxTextFile.Items.Add(e.KeyValue.ToString()); */
        } 

        private void finishSession()
        {
            run = false;
            simulationTimer.Enabled = false;
            textBox1.Clear();
            saveResult();
            MessageBox.Show("Вы закончили упражнение! \n" + DateTime.Now.ToString());
        }

        private void saveResult()
        {
            List<User> listUsers = (List<User>)Serializer.readObject(Serializer.FILE_USERS);
            User user = User.searchUser(listUsers, userName);
            listUsers.Remove(user);
            if (user.A_first == 0) user.A_first = sessionTime; 
            user.listSessions.Add(new Session
                (sessionType ,totalClicks, errorClicks, sessionTime, maxWords, errorLetters));
            listUsers.Add(user);
            Serializer.writeObject(Serializer.FILE_USERS, listUsers);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (unlockTextBox && run)
            {
                if (step < task.Length-1)
                {
                    if (task[step].ToString() == textBox1.Text) hitClickEvent();
                    else errorCLickEvent(textBox1.Text[0]);
                    unlockTextBox = false;
                    textBox1.Clear();
                    textBox1.Focus();  
                }
                else finishSession(); 
            }
            else unlockTextBox = true;
           
        }

        private void simulationTimer_Tick(object sender, EventArgs e)
        {
            sessionTime++;
            timeLabel.Text = "Время: " + sessionTime ; 
            //if (timeLimiter == sessionTime) finishSession();                   
        }
    }
}
