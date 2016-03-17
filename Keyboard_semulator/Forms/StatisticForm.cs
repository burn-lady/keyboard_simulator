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
        //деления,  для корректной отрисовки размеры GraphicsBox должны быть кратны этому числу
        private static int CELL_DIVISION = 30;
        private static int MODIFIER_INDENT_FOR_X = 2;
        private static int STEP_X = 30;
        private static int STEP_Y = 30;

        List<User> listUsers;
        User selectedUser = null;
        Graphics g;

        private void initInterface()
        {
            sessionTypeComboBox.Items.Add(Session.CONTROL_WORDS_SESSION);
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

        private void updateGraphicsBox()
            {
            try { 

            g.Clear(Color.White);
            drawSnoodAndCaption();
            drawGraphic();
            }
            catch (System.NullReferenceException)
            {
                g = graphicBox.CreateGraphics();
            }
        }

        private void updateGraphicsBox(Session selectedSession)
        {
            g.Clear(Color.White);
            drawSnoodAndCaption();
            drawGraphic(selectedSession);
        }

        // Нарисовать клеточки
        private void drawSnoodAndCaption()
        {
            try
            {
               
                drawShood();
                drawCaption();
                drawString("Время набора текста", 0, 0 );

            } catch(System.NullReferenceException)
            {
                g = graphicBox.CreateGraphics();
            }
            
        }

        private void drawString(string text, int x, int y)
        {
            StringFormat SF = StringFormat.GenericDefault;
            SF.FormatFlags = StringFormatFlags.DirectionVertical;
            GraphicsPath gPath = new GraphicsPath();
            gPath.AddString(text,
                FontFamily.GenericSerif,
                0, // стиль
                20, // размер
                new Point(x, y),
                SF);

            g.DrawPath(new Pen(Brushes.Black), gPath);
        }

        private void drawShood()
        {
            Pen pen = new Pen(Color.Gray, 1);
            for (int bloc = CELL_DIVISION*MODIFIER_INDENT_FOR_X; bloc < graphicBox.Size.Width; bloc += CELL_DIVISION)
                g.DrawLine(pen, bloc, 0, bloc, graphicBox.Size.Height - CELL_DIVISION); // Вертикальные  линии

            for (int bloc = graphicBox.Height; bloc > 0; bloc -= CELL_DIVISION)
                    g.DrawLine(pen, CELL_DIVISION*MODIFIER_INDENT_FOR_X, 
                        graphicBox.Height - bloc, graphicBox.Size.Width, graphicBox.Height - bloc); // Горизонтальные линии
        }
      
        private void drawCaption()
        {
            Font font = new Font(FontFamily.GenericSerif, 10);
                for (int y = CELL_DIVISION; y < graphicBox.Width; y += CELL_DIVISION)//
                g.DrawString(((y / CELL_DIVISION) * STEP_Y).ToString(), font,
                        Brushes.Black, new PointF(CELL_DIVISION, graphicBox.Height - y - CELL_DIVISION));// вертикаль

                for (int x = 0; x < graphicBox.Width; x += CELL_DIVISION)
                g.DrawString(((x + CELL_DIVISION) * STEP_X / CELL_DIVISION).ToString(),
                        font, Brushes.Black, 
                        new PointF(x + CELL_DIVISION*MODIFIER_INDENT_FOR_X + CELL_DIVISION, graphicBox.Height - CELL_DIVISION));// горизонт            
        }

        private void drawGraphic(Session selectedSession)
        {
            try {
            int x = CELL_DIVISION*MODIFIER_INDENT_FOR_X;
            List<Point> points = new List<Point>();

            foreach (TimeBlockCliks timeBlock in selectedSession.listTimeBlockClicks)
            {
                points.Add(new Point(x,
                        graphicBox.Height - CELL_DIVISION - timeBlock.countClicks * (CELL_DIVISION / STEP_Y)));
                    x = ( CELL_DIVISION * timeBlock.secondStartSession / STEP_X + CELL_DIVISION );
            }
            for (int i = 1; i < points.Count; i++)
            {
                g.DrawLine(new Pen(Color.Red, 2), points[i - 1], points[i]);
            }
            } catch (NullReferenceException)
            {
                MessageBox.Show("Пользователи загружаются..");
            }

        }

        private void drawGraphic()
        {
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
            
            try {
           string dateString = dateListBox.GetItemText(dateListBox.SelectedItem);
            Session selectedSession = Session.searchSession(selectedUser, dateString);

                updateGraphicsBox(selectedSession);

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
            updateGraphicsBox();
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
    
    }
}
}
