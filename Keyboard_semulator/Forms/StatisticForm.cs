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

        private void initInterface()
        {
            sessionTypeComboBox.Items.Add(Session.CONTROL_WORDS_SESSION);
            sessionTypeComboBox.Items.Add(Session.CONTROL_TEXT_SESSION);
            sessionTypeComboBox.Items.Add(Session.CONTROL_LETTERS_SESSION);
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
            }
            catch (System.NullReferenceException)
            {
                g = graphicBox.CreateGraphics();
            }
        }

        private void updateGraphicsBox(Session selectedSession)
        {
            g.Clear(Color.White);
            adapteSizes(selectedSession);
            drawSnoodAndCaption();
            drawGraphic(selectedSession);
        }

        private void adapteSizes (Session session)
        {
           
          double debug = pointOfDivision_X = (double) session.sessionTime / (graphicBox.Width - CELL_DIVISION*4);
           pointOfDivision_Y = (double) session.totalClicks / (graphicBox.Height - CELL_DIVISION*2);
           captionCellDivision_X =  Math.Round(pointOfDivision_X * CELL_DIVISION);
           captionCellDivision_Y =  Math.Round(pointOfDivision_Y * CELL_DIVISION, 1);

        }

        // Нарисовать клеточки
        private void drawSnoodAndCaption()
        {
            try
            {             
                drawShood();
                drawCaption();
                drawString("Количество нажатий в общем", new Point(0,0));

            } catch(System.NullReferenceException)
            {
                g = graphicBox.CreateGraphics();
            }
            
        }

        private void drawShood()
        {
            Pen pen = new Pen(Color.Green, 1);
            for (int x = CELL_DIVISION * MODIFIER_INDENT_FOR_X; x < graphicBox.Size.Width; x += CELL_DIVISION)
                g.DrawLine(pen, x, 0, x, graphicBox.Size.Height - CELL_DIVISION); // Вертикальные  линии

            for (int y = graphicBox.Height; y > 0; y -= CELL_DIVISION)
                g.DrawLine(pen, CELL_DIVISION * MODIFIER_INDENT_FOR_X,
                    graphicBox.Height - y, graphicBox.Size.Width, graphicBox.Height - y); // Горизонтальные линии
        }

        private void drawString(string text, Point point)
        {
            StringFormat SF = StringFormat.GenericDefault;
            SF.FormatFlags = StringFormatFlags.DirectionVertical;
            GraphicsPath gPath = new GraphicsPath();
            gPath.AddString(text,
                FontFamily.GenericSerif,
                0, // стиль
                20, // размер
                point,
                SF);

            g.DrawPath(new Pen(Brushes.Black), gPath);
        }

        private void drawCaption()
        {
            Font font = new Font(FontFamily.GenericSerif, 10);
            double caption = 0;
            for (int y = 0; y < graphicBox.Width; y += CELL_DIVISION)
            { //
                g.DrawString(caption.ToString(), font,
                        Brushes.Black,
                        new PointF(CELL_DIVISION, graphicBox.Height - y - CELL_DIVISION - (CELL_DIVISION / 2)));// вертикаль
                caption += captionCellDivision_Y;
            }

            caption = 0;
            for (int x = 0; x < graphicBox.Width; x += CELL_DIVISION)
            {
                g.DrawString(caption.ToString(),
                        font, Brushes.Black,
                        new PointF(x + CELL_DIVISION * MODIFIER_INDENT_FOR_X, graphicBox.Height - CELL_DIVISION));// горизонт       
                caption += captionCellDivision_X;

             }     
        }

        private void drawGraphic (Session selectedSession)
        {
            try
            {
                int x = CELL_DIVISION * MODIFIER_INDENT_FOR_X;

                List<Point> points = new List<Point>();

                //int inc = 0;
                //while (x < graphicBox.Width)
                //{
                //    if (inc == selectedSession.listTimeBlockClicks.Count) break;

                //    points.Add(new Point (x , getPointY(selectedSession.listTimeBlockClicks[inc].countClicks)));
                //    x += CELL_DIVISION;

                //    int step = (int)Math.Round(pointOfDivision_X);
                //    if (step >= 1) inc += step;
                //    else inc++;

                //}

                

                while ( x < graphicBox.Width)
                {
                    points.Add(new Point
                        (x,
                        getPointY(selectedSession.dictionaryTimeBlockClicks[x / CELL_DIVISION])));
                    x += CELL_DIVISION;
                }

                //foreach (KeyValuePair<int, int> value in selectedSession.dictionaryTimeBlockClicks)
                //{
                   
                //        points.Add(new Point(getPointX(x), getPointY(value.Value)));
                //        x += pointOfDivision_X;
                     
                //}

                for (int i = 1; i < points.Count; i++)
                {
                    g.DrawLine(new Pen(Color.Gray, 2), points[i - 1], points[i]);
                }
             }
            catch (NullReferenceException)
             {
                MessageBox.Show("Пользователи загружаются..");
             }
}
        private int getPointX (double x)
        {
          //  x *= CELL_DIVISION;
            if (x <= 1) return 1;
            return (int) Math.Round(x);   
        }

        private int getPointY(int countClicks)
        {
            double realY = (int)Math.Round(countClicks / pointOfDivision_Y);
            return (int)graphicBox.Height - CELL_DIVISION - (int)realY;
        }

        //private void drawGraphic(Session selectedSession)
        //{
        //    try {
        //    int x = CELL_DIVISION*MODIFIER_INDENT_FOR_X + CELL_DIVISION /captionCellDivision_X;
        //    List<Point> points = new List<Point>();

        //    foreach (TimeBlockCliks timeBlock in selectedSession.listTimeBlockClicks)
        //    {
        //        points.Add(new Point(x,
        //                graphicBox.Height - CELL_DIVISION - timeBlock.countClicks * (CELL_DIVISION / captionCellDivision_Y)));
        //             x = ( CELL_DIVISION * timeBlock.secondStartSession / captionCellDivision_X ) + CELL_DIVISION*MODIFIER_INDENT_FOR_X ;


        //    }
        //    for (int i = 1; i < points.Count; i++)
        //    {
        //        g.DrawLine(new Pen(Color.Gray, 2), points[i - 1], points[i]);
        //    }
        //    } catch (NullReferenceException)
        //    {
        //        MessageBox.Show("Пользователи загружаются..");
        //    }

        //}



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
