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
                    {
                        dateListBox.Items.Add(session.dateTime.ToString());                    
                    }
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
            for (int bloc = 0; bloc < graphicBox.Size.Width; bloc += 10)
            {
                g.DrawLine(pen, bloc, 0, bloc, graphicBox.Size.Height);
                g.DrawLine(pen, 0, bloc, graphicBox.Size.Width, bloc);
            }
          } catch(System.NullReferenceException)
            {
                g = graphicBox.CreateGraphics();
            }
            
        }

        private void drawGraphic()
        {
            drawSnood();

            int x = 10;
            List<Point> points = new List<Point>();
           // int t_AllTime = selectedUser.get_t_AllTime();
            foreach (Session session in selectedUser.listSessions)
            {
               // if (sessionTypeComboBox.Text == session.typeSession)
                {
                  //  MessageBox.Show("double y =  " + getY(session.sessionTime, selectedUser.A_first, t_AllTime));
                  //  int y = (int)getY(session.sessionTime, selectedUser.A_first, t_AllTime);
                    
                 //   points.Add(new Point(x, graphicBox.Size.Height - y * 100));
                    points.Add(new Point(x, graphicBox.Size.Height - session.sessionTime * 1));
                    x += 10; 
                }
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
            drawGraphic();

        }

        private void addInfo(string line){ InfoListBox.Items.Add(line);}

        private void dateListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
           string dateString = dateListBox.GetItemText(dateListBox.SelectedItem);
            Session selectedSession = Session.searchSession(selectedUser, dateString);

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
    }
}
