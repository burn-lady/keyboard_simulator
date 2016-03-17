namespace Keyboard_semulator.Forms
{
    partial class UsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.crearAndCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.userNameTextBox.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.userNameTextBox.Location = new System.Drawing.Point(11, 11);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(661, 23);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.addUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addUserButton.Location = new System.Drawing.Point(201, 48);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(278, 72);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // usersListBox
            // 
            this.usersListBox.BackColor = System.Drawing.Color.Black;
            this.usersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usersListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.usersListBox.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersListBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 15;
            this.usersListBox.Location = new System.Drawing.Point(41, 210);
            this.usersListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(599, 272);
            this.usersListBox.TabIndex = 2;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersListBox_SelectedIndexChanged);
            // 
            // crearAndCreateButton
            // 
            this.crearAndCreateButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.crearAndCreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crearAndCreateButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearAndCreateButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.crearAndCreateButton.Location = new System.Drawing.Point(201, 124);
            this.crearAndCreateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crearAndCreateButton.Name = "crearAndCreateButton";
            this.crearAndCreateButton.Size = new System.Drawing.Size(278, 74);
            this.crearAndCreateButton.TabIndex = 3;
            this.crearAndCreateButton.Text = "Очистить и создать заново файл";
            this.crearAndCreateButton.UseVisualStyleBackColor = false;
            this.crearAndCreateButton.Click += new System.EventHandler(this.crearAndCreateButton_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(683, 495);
            this.Controls.Add(this.crearAndCreateButton);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.userNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UsersForm";
            this.Text = "Пользователи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Button crearAndCreateButton;
    }
}