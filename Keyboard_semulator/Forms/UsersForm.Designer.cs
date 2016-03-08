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
            this.userNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(370, 22);
            this.userNameTextBox.TabIndex = 0;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(12, 40);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(370, 27);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 16;
            this.usersListBox.Location = new System.Drawing.Point(12, 153);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(370, 148);
            this.usersListBox.TabIndex = 2;
            // 
            // crearAndCreateButton
            // 
            this.crearAndCreateButton.Location = new System.Drawing.Point(12, 119);
            this.crearAndCreateButton.Name = "crearAndCreateButton";
            this.crearAndCreateButton.Size = new System.Drawing.Size(370, 28);
            this.crearAndCreateButton.TabIndex = 3;
            this.crearAndCreateButton.Text = "Очистить и создать заново файл";
            this.crearAndCreateButton.UseVisualStyleBackColor = true;
            this.crearAndCreateButton.Click += new System.EventHandler(this.crearAndCreateButton_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 316);
            this.Controls.Add(this.crearAndCreateButton);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "UsersForm";
            this.Text = "UsersForm";
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