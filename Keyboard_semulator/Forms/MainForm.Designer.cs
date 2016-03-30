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
            this.tutorialProgramButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.UsersBox = new System.Windows.Forms.ComboBox();
            this.usersButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.newGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGameButton.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newGameButton.Location = new System.Drawing.Point(74, 15);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(271, 43);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "Выбрать пользователя";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // tutorialProgramButton
            // 
            this.tutorialProgramButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tutorialProgramButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutorialProgramButton.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialProgramButton.Location = new System.Drawing.Point(660, 411);
            this.tutorialProgramButton.Margin = new System.Windows.Forms.Padding(2);
            this.tutorialProgramButton.Name = "tutorialProgramButton";
            this.tutorialProgramButton.Size = new System.Drawing.Size(177, 45);
            this.tutorialProgramButton.TabIndex = 1;
            this.tutorialProgramButton.Text = "Справка";
            this.tutorialProgramButton.UseVisualStyleBackColor = false;
            this.tutorialProgramButton.Click += new System.EventHandler(this.tutorialProgramButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.statisticsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statisticsButton.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsButton.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.statisticsButton.Location = new System.Drawing.Point(74, 300);
            this.statisticsButton.Margin = new System.Windows.Forms.Padding(2);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(271, 136);
            this.statisticsButton.TabIndex = 2;
            this.statisticsButton.Text = "Статистика";
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // UsersBox
            // 
            this.UsersBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UsersBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersBox.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.UsersBox.FormattingEnabled = true;
            this.UsersBox.Location = new System.Drawing.Point(74, 61);
            this.UsersBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(272, 21);
            this.UsersBox.Sorted = true;
            this.UsersBox.TabIndex = 3;
            this.UsersBox.SelectedIndexChanged += new System.EventHandler(this.UsersBox_SelectedIndexChanged);
            this.UsersBox.Click += new System.EventHandler(this.UsersBox_Click);
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersButton.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.usersButton.Location = new System.Drawing.Point(74, 111);
            this.usersButton.Margin = new System.Windows.Forms.Padding(2);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(271, 129);
            this.usersButton.TabIndex = 4;
            this.usersButton.Text = "Пользователи";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(417, 37);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 353);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(848, 467);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.UsersBox);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.tutorialProgramButton);
            this.Controls.Add(this.newGameButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Адаптивный клавиатурный тренажер";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button tutorialProgramButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.ComboBox UsersBox;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}