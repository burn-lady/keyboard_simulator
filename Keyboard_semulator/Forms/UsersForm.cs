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
    public partial class UsersForm : Form
    {
        List<User> listUser;

        public UsersForm()
        {
            InitializeComponent();
            loadUsers();
        }

        private void loadUsers()
        {
            usersListBox.Items.Clear();
            listUser = (List<User>)Serializer.readObject(Serializer.FILE_USERS);
            if (listUser != null)
                foreach (User user in listUser) usersListBox.Items.Add(user.name);               
            else { usersListBox.Items.Add("Сохранений не обнаружено!"); listUser = new List<User>(); }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            try {
                listUser.Add(new User(userNameTextBox.Text));
               if(! Serializer.writeObject(Serializer.FILE_USERS, listUser)) MessageBox.Show("Не удалось записать фаил");
               else usersListBox.Items.Add(userNameTextBox.Text);
            } catch (System.NullReferenceException)
            {
                MessageBox.Show("NullReferenseException");
            }
        }

        private void crearAndCreateButton_Click(object sender, EventArgs e)
        {
            if (Serializer.writeObject(Serializer.FILE_USERS, new List<User>())) MessageBox.Show("Очищено и создано заново!");
            loadUsers();
        }
    }
}
