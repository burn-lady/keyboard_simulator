using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keyboard_semulator.Data;

namespace Keyboard_semulator.Forms
{
    public partial class StatisticForm : Form
    {
        //деления,  для корректной отрисовки размеры GraphicsBox (Size) должны быть кратны этому числу
        private static int CELL_DIVISION = 30;
        int MODIFIER_INDENT_FOR_X = 2;

        double captionCellDivision_X = 30;
        double captionCellDivision_Y = 30;

        double pointOfDivision_X;
        double pointOfDivision_Y;

        List<User> listUsers;
        User selectedUser = null;
        Graphics g;

        private ZedGraph.ZedGraphControl zGraph;

   

        public StatisticForm()
        {
            InitializeComponent();
            initZGraph();
            loadUsers();
            initInterface();
       
           // g = graphicBox.CreateGraphics();
          
        }

        private void initZGraph()
        {
            zGraph = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            this.zGraph.IsShowPointValues = false;
            this.zGraph.Location = new System.Drawing.Point(200, 150);
            this.zGraph.Name = "zGraph";
            this.zGraph.PointValueFormat = "G";
            this.zGraph.Size = new System.Drawing.Size(500, 329);
            this.zGraph.TabIndex = 0;

            this.Controls.Add(this.zGraph);



            /*
             this.z1 = new ZedGraph.ZedGraphControl();
        this.SuspendLayout();
        // 
        // z1
        // 
        this.z1.IsShowPointValues = false;
        this.z1.Location = new System.Drawing.Point(0, 0);
        this.z1.Name = "z1";
        this.z1.PointValueFormat = "G";
        this.z1.Size = new System.Drawing.Size(816, 478);
        this.z1.TabIndex = 0;
        // 
        // Form1
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
        this.ClientSize = new System.Drawing.Size(856, 512);
        this.Controls.Add(this.z1);
        this.Name = "Form1";
        this.Text = "Form1";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.ResumeLayout(false);

    }

*/
        }

        private void initInterface()
        {
            sessionTypeComboBox.Items.Add(Session.CONTROL_WORDS_SESSION);
            sessionTypeComboBox.Items.Add(Session.CONTROL_TEXT_SESSION);
            sessionTypeComboBox.Items.Add(Session.CONTROL_LETTERS_SESSION);
            userComboBox.SelectedIndex = 0;
            sessionTypeComboBox.SelectedIndex = 0;
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


        private void updateGraphicsBox(Session selectedSession)
        {
            g.Clear(Color.White);
            drawGraphic(selectedSession);
        }



        private void drawGraphic (Session selectedSession)
        {
           // try
            {
                zGraph.IsShowPointValues = true;
                List<double> listX = new List<double>();
                List<double> listY = new List<double>();

                listX.Add(2); listX.Add(5); listX.Add(7);
                listY.Add(4); listY.Add(10); listY.Add(14);
               // foreach (KeyValuePair<int, int> keyValue  in selectedSession.dictionaryTimeBlockClicks)
               // {
               //     listX.Add(keyValue.Key);
               //     listY.Add(keyValue.Value);
              //  }
                zGraph.GraphPane.AddCurve("line", listX.ToArray(), listY.ToArray(), Color.Red);
                zGraph.AxisChange();
                zGraph.Invalidate();             
             }
           // catch (NullReferenceException)
             {
           //     MessageBox.Show("Пользователи загружаются..");
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
            
            try {
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
            } catch (NullReferenceException)
            {
                MessageBox.Show("Выбирите конкретную сессию");
            }  
        }

        private void sessionTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            uploadUserDateInfo();
            
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
    
    }
}
}
