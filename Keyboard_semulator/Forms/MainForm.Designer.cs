namespace Keyboard_semulator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.newGameButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.UsersBox = new System.Windows.Forms.ComboBox();
            this.usersButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(5, 15);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(361, 40);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "Выбрать пользователя";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(5, 271);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(361, 40);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // statisticsButton
            // 
            this.statisticsButton.Location = new System.Drawing.Point(5, 317);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(361, 40);
            this.statisticsButton.TabIndex = 2;
            this.statisticsButton.Text = "Статистика";
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // UsersBox
            // 
            this.UsersBox.FormattingEnabled = true;
            this.UsersBox.Location = new System.Drawing.Point(5, 61);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(361, 24);
            this.UsersBox.Sorted = true;
            this.UsersBox.TabIndex = 3;
            this.UsersBox.Click += new System.EventHandler(this.UsersBox_Click);
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(5, 225);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(361, 40);
            this.usersButton.TabIndex = 4;
            this.usersButton.Text = "Пользователи";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(377, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(355, 337);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 363);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.UsersBox);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.newGameButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.ComboBox UsersBox;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}