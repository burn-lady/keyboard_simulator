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

namespace Keyboard_semulator.Forms
{
    public partial class StatisticForm : Form
    {
        private static int CELL_DIVISION = 30;  //деления
        private static int STEP_X = 5;
        private static int STEP_Y = 5;

        List<User> listUsers;
        User selectedUser = null;
        Graphics g;

        private void initInterface()
        {
            sessionTypeComboBox.Items.Add(Session.WORDS_SESSION);
            sessionTypeComboBox.Items.Add(Session.CONTROL_TEXT_SESSION);
            userComboBox.SelectedIndex = 0;
            sessionTypeComboBox.SelectedIndex = 0;
        }

        public StatisticForm()
        {
            InitializeComponent();
            loadUsers();
            initInterface();
       
            g = graphicBox.CreateGraphics();
          
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
           // drawGraphic();
        }

        private void loadUsers()
        {       
            listUsers = (List<User>)Serializer.readObject(Serializer.FILE_USERS);
            foreach (User user in listUsers) userComboBox.Items.Add(user.name);
        }

        private void uploadUserDateInfo()            
        {
            dateListBox.Items.Clear();
            if (selectedUser != null)
                foreach (Session session in selectedUser.listSessions)
                    if (sessionTypeComboBox.Text == session.typeSession)                    
                        dateListBox.Items.Add(session.dateTime.ToString());                    
                    
        }

        private double getY(int  T_selectSessionTime, int A_first, int t_allTime)
        {
            return Math.Log(T_selectSessionTime / A_first) / t_allTime;
        }

        // Нарисовать клеточки
        private void drawSnood()
        { try
            {
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Gray, 1);

            Font font = new Font(FontFamily.GenericSerif, 10)   ;

            for (int bloc = CELL_DIVISION; bloc < graphicBox.Size.Width; bloc += CELL_DIVISION)
                g.DrawLine(pen, bloc, 0, bloc, graphicBox.Size.Height - CELL_DIVISION); // Вертикальные  линии

            for (int bloc = graphicBox.Height - CELL_DIVISION; bloc > 0; bloc -= CELL_DIVISION )
                    g.DrawLine(pen, CELL_DIVISION, graphicBox.Height - bloc, graphicBox.Size.Width, graphicBox.Height - bloc); // Горизонтальные линии
      
            //подпись клеток
                for (int i = CELL_DIVISION; i < graphicBox.Width; i += CELL_DIVISION)//
                {                
                    g.DrawString(((i/CELL_DIVISION)*STEP_Y).ToString(), font, 
                        Brushes.Black, new PointF(0, graphicBox.Height - i - CELL_DIVISION));// вертикаль
                }
                for (int i = 0; i < graphicBox.Width; i += CELL_DIVISION)
                    g.DrawString(((i+ CELL_DIVISION)*STEP_X / CELL_DIVISION).ToString(),
                        font, Brushes.Black, new PointF(i + CELL_DIVISION, graphicBox.Height - CELL_DIVISION));// горизонт

            } catch(System.NullReferenceException)
            {
                g = graphicBox.CreateGraphics();
            }
            
        }

        private void drawGraphic(Session selectedSession)
        {
            drawSnood();
            int x = CELL_DIVISION;
            List<Point> points = new List<Point>();

            foreach (TimeBlockCliks timeBlock in selectedSession.listTimeBlockClicks)
            {
                points.Add(new Point(x, graphicBox.Height - CELL_DIVISION - timeBlock.countClicks));
            }

        }

        private void drawGraphic()
        {
            drawSnood();


            int x = CELL_DIVISION;
            List<Point> points = new List<Point>();
            foreach (Session session in selectedUser.listSessions)
            {                                              
                    points.Add(new Point(x, graphicBox.Size.Height - CELL_DIVISION - session.sessionTime * 1));
                    x +=  CELL_DIVISION;                 
            }
            for (int i=1; i<points.Count; i++)
            {
                g.DrawLine(new Pen(Color.Red, 2), points[i - 1], points[i]);
            }
        }

        private void userComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedUser = User.searchUser(listUsers, userComboBox.Text);
            uploadUserDateInfo();
           // drawGraphic();

        }

        private void addInfo(string line){ InfoListBox.Items.Add(line);}

        private void dateListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            

           string dateString = dateListBox.GetItemText(dateListBox.SelectedItem);
            Session selectedSession = Session.searchSession(selectedUser, dateString);

            drawGraphic(selectedSession);

            InfoListBox.Items.Clear();
            addInfo(dateString);
            addInfo(selectedSession.typeSession);
            addInfo("");
            addInfo("Время сессии (сек): " + selectedSession.sessionTime);
            addInfo("Колличество ошибок: " + selectedSession.errorClicks);
            addInfo("Всего нажатий: " + selectedSession.totalClicks);
            addInfo("Всего слов: " + selectedSession.totalWords);
            addInfo("");
            addInfo("Статистика ошибок по буквам");
            InfoListBox.Items.AddRange(selectedSession.getArrayStringErrorLetters());   
        }

        private void sessionTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            uploadUserDateInfo();
            drawGraphic();
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
    }
}
