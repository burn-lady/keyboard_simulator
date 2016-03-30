using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keyboard_semulator.Forms;
using Keyboard_semulator.Data;

namespace Keyboard_semulator
{
    public partial class MainForm : Form
    {
        List<User> listUsers;

        public MainForm()
        {
            InitializeComponent();            
        }

        private void loadUsers()
        {
            UsersBox.Items.Clear();
            listUsers = (List<User>)Serializer.readObject(Serializer.FILE_USERS);
            if (listUsers != null)
                foreach (User user in listUsers) UsersBox.Items.Add(user.name);
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            if (UsersBox.Text != "")
                new Form1(
                     UsersBox.Text
                    ).ShowDialog();
            else MessageBox.Show("Необходимо выбрать пользователя!");
            loadUsers();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            new UsersForm().ShowDialog();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            new StatisticForm().ShowDialog();
        }

        private void UsersBox_Click(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void UsersBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tutorialProgramButton_Click(object sender, EventArgs e)
        {
            new TutorialProgramForm().ShowDialog();
        }
    }
}
