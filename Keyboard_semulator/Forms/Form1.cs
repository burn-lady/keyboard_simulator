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
using Keyboard_semulator.Forms;



namespace Keyboard_semulator
{
    public partial class Form1 : Form
    {
        
        int sessionTime;
        int sessionTimeBlock;

        int errorClicks;
        int totalClicks;

        int step;
        int maxWords;
        


        string task = " ";
        bool run;
        bool unlockTextBox; // костыль

        string userName;
        string sessionType;

        public Dictionary<char, int> errorLetters;
        Dictionary<int, int> dictionaryTimeBlocksClicks;

        private void createVariables ()
        {
          
            errorLetters = new Dictionary<char, int>();
            dictionaryTimeBlocksClicks = new Dictionary<int, int>();

            errorClicks = 0;
            totalClicks = 0;
            sessionTime = 0;
            sessionTimeBlock = 0;
            step = 0;           

            maxWords = 7;
            unlockTextBox = true;
            run = true;

            timeLabel.Text = "Текущее время: 0";
        }

        private void createComponents()
        {
            taskLabel.Font = new Font("Arial", 27, FontStyle.Italic);
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
           
            rangeOfTask();
       

            taskLabel.Text = Controller.visibleLine(task, 0); //step = 0
            textBox1.Focus();
          
              
        }

        private void rangeOfTask()
        {
            
                List<string> lines = null;

                if (wordsRadioButton.Checked)
                {
                    lines = MyTextReader.read(MyTextReader.CONTROL_WORDS);
                     if (lines != null)
                     {
                    task = Controller.generateTask_Words(lines, maxWords);
                    sessionType = Session.CONTROL_WORDS_SESSION;
                        }
                        else showFileNotFoundMessage();
                }

                if (textRadioButton.Checked)
                {
                      lines = MyTextReader.read(MyTextReader.CONTROL_TEXT);
                    if(lines != null)
                      {
                    task = Controller.generateTask_ControlText(lines);
                    sessionType = Session.CONTROL_TEXT_SESSION;
                      }
                     else showFileNotFoundMessage();
                }

                if (lettersRadioButton.Checked)
                {
                  lines = MyTextReader.read(MyTextReader.CONTROL_LETTERS);
                      if (lines != null)
                     {
                    task = Controller.generateTask_Letters(lines);
                    sessionType = Session.CONTROL_LETTERS_SESSION;
                     }
                else showFileNotFoundMessage();
                }
            
        }

        


        private void showFileNotFoundMessage() {
            MessageBox.Show("Фаил с заданиями не обнаружен");
            simulationTimer.Enabled = false;
            run = false;
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
        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        } 

        private void finishSession()
        {
             run = false;
            simulationTimer.Enabled = false;
            textBox1.Clear();
            saveResult();
            fixBlock();
          //  MessageBox.Show("Вы закончили упражнение! \n" + DateTime.Now.ToString());
            new InfoForm( userName + " , Поздравляем! Вы закончили упражнение!  \n" + "               "+ DateTime.Now.ToString()).ShowDialog();
        }

        private void saveResult()
        {
            List<User> listUsers = (List<User>)Serializer.readObject(Serializer.FILE_USERS);
            User user = User.searchUser(listUsers, userName);
            listUsers.Remove(user);
            if (user.A_first == 0) user.A_first = sessionTime; 
            user.listSessions.Add(new Session
                (sessionType ,totalClicks, errorClicks, sessionTime, maxWords, errorLetters, dictionaryTimeBlocksClicks));
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

        private void fixBlock()
        {
            sessionTimeBlock = 0;
            if (dictionaryTimeBlocksClicks.ContainsKey(sessionTime))
               dictionaryTimeBlocksClicks[sessionTime] = totalClicks;
            else         
               dictionaryTimeBlocksClicks.Add(sessionTime, totalClicks);
            
        }

        private void simulationTimer_Tick(object sender, EventArgs e)
        {
            sessionTime++;
            sessionTimeBlock++;
            timeLabel.Text = "Время (сек.): " + sessionTime ;
            if(Constanta.TIME_BLOCK_SECOND == sessionTimeBlock) fixBlock();
                           
        }

        private void totalClickLabel_Click(object sender, EventArgs e)
        {

        }

        private void textRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wordsRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void taskLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lettersRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
