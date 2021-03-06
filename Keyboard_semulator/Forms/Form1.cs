﻿using System;
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
using Keyboard_semulator.Controllers;



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
        User selectedUser;
        string sessionType;

        public Dictionary<char, int> errorLetters;
        Dictionary<int, int> dictionaryTimeBlocksClicks;

        public Form1(string userName)
        {
            InitializeComponent();
            createComponents();
            createVariables();
            this.userName = userName;
            userTextLabel.Text = "Текущий пользователь: " + userName;
            run = false;
        }

        public Form1(User user)
        {
            this.selectedUser = user;
            userName = user.name;
            InitializeComponent();
            createComponents();
            createVariables();
            userTextLabel.Text = "Текущий пользователь: " + userName;
            run = false;
        }

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
            simulationTimer.Interval = Global.TIME_BLOCK_MINISECOND;
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
            Global.MAX_TIME_OF_SESSION = (int)numericUpDown1.Value*1000;
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
                if (lines != null)
                {
                    task = Controller.generateTask_ControlText(lines);
                    sessionType = Session.CONTROL_TEXT_SESSION;
                }
                else showFileNotFoundMessage();
            }

            if (lettersRadioButton.Checked)
            {
                LettersController.init();
                LettersController.statisticLetters = selectedUser.statisticLetters;
                task = LettersController.getRandomLine();
                //task = Convert.ToString(LettersController.getLetterHasMaxMiniseconds());
                taskLabel.Text = task;
                sessionType = Session.CONTROL_LETTERS_SESSION;
                LettersLogger.setUserAndCreateLog(userName);
                
            }
        }

        

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {       
        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        } 


        private void saveResult()
        {
            List<User> listUsers = (List<User>)Serializer.readObject(Serializer.FILE_USERS);
            User user = User.searchUser(listUsers, userName);
            listUsers.Remove(user);
            if (user.A_first == 0) user.A_first = sessionTime; 
            user.listSessions.Add(new Session
                (sessionType ,totalClicks, errorClicks, sessionTime, maxWords, errorLetters, dictionaryTimeBlocksClicks));
            user.statisticLetters = LettersController.statisticLetters;
            listUsers.Add(user);
            Serializer.writeObject(Serializer.FILE_USERS, listUsers);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (unlockTextBox && run)
            {
                if (lettersRadioButton.Checked) lettersMode();
                else normalMode();

                unlockTextBox = false;
                textBox1.Clear();
                textBox1.Focus();
            }
            else unlockTextBox = true;

        }

        private void normalMode()
        {
            if (step < task.Length - 1)
            {
                if (task[step].ToString() == textBox1.Text) hitClickEvent();
                else errorCLickEvent(textBox1.Text[0]);
            }
            else finishSession();
        }

        private void lettersMode()
        {
            if (taskLabel.Text[0] == textBox1.Text[0])
            {
                hitClickLettersEvent(textBox1.Text[0]);
            }
            else
            {
                errorCLickEvent(taskLabel.Text[0]);
            }
        }

        private void hitClickLettersEvent(char letter)
        {
            totalClicks++;
            task = LettersController.getLine();
            //task = Convert.ToString(LettersController.getLetterHasMaxMiniseconds());
            taskLabel.Text = task;
            LettersController.setLetter(letter, sessionTimeBlock);
            fixBlock();
            updateInterface();
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



        private void showFileNotFoundMessage()
        {
            MessageBox.Show("Фаил с заданиями не обнаружен");
            simulationTimer.Enabled = false;
            run = false;
        }


        private void updateInterface()
        {
            totalClickLabel.Text = "Всего: " + totalClicks + "  Ошибок: " + errorClicks;
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
            sessionTime += Global.TIME_BLOCK_MINISECOND;
            sessionTimeBlock += Global.TIME_BLOCK_MINISECOND;
            timeLabel.Text = "Время (сек.): " + Convert.ToString(sessionTime/1000 );          
            if (lettersRadioButton.Checked)
            {
                if (Global.MAX_TIME_OF_SESSION < sessionTime) finishSession();
            }
            else
            {
                if (Global.TIME_BLOCK_MINISECOND == sessionTimeBlock) fixBlock();
                if (step > task.Length - 2) finishSession();
            }
        }

        private void finishSession()
        {
            run = false;
            taskLabel.Text = "";
            simulationTimer.Enabled = false;
            textBox1.Clear();
            saveResult();
            fixBlock();
            //  MessageBox.Show("Вы закончили упражнение! \n" + DateTime.Now.ToString());
            new InfoForm(userName + " , Поздравляем! Вы закончили упражнение!  \n" + "               "
                + DateTime.Now.ToString()).ShowDialog();
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
