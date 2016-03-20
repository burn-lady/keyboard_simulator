namespace Keyboard_semulator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.taskLabel = new System.Windows.Forms.Label();
            this.totalClickLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userTextLabel = new System.Windows.Forms.Label();
            this.simulationTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.wordsRadioButton = new System.Windows.Forms.RadioButton();
            this.textRadioButton = new System.Windows.Forms.RadioButton();
            this.lettersRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.taskLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taskLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskLabel.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.taskLabel.Location = new System.Drawing.Point(11, 61);
            this.taskLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(781, 36);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Задание                                                           ";
            this.taskLabel.Click += new System.EventHandler(this.taskLabel_Click);
            // 
            // totalClickLabel
            // 
            this.totalClickLabel.AutoSize = true;
            this.totalClickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalClickLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.totalClickLabel.Location = new System.Drawing.Point(287, 146);
            this.totalClickLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalClickLabel.Name = "totalClickLabel";
            this.totalClickLabel.Size = new System.Drawing.Size(207, 31);
            this.totalClickLabel.TabIndex = 1;
            this.totalClickLabel.Text = "totalClickLabel";
            this.totalClickLabel.Click += new System.EventHandler(this.totalClickLabel_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.startButton.Location = new System.Drawing.Point(282, 191);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startButton.Size = new System.Drawing.Size(227, 88);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(38, 191);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 13);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userTextLabel
            // 
            this.userTextLabel.AutoSize = true;
            this.userTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userTextLabel.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.userTextLabel.Location = new System.Drawing.Point(9, 403);
            this.userTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userTextLabel.Name = "userTextLabel";
            this.userTextLabel.Size = new System.Drawing.Size(155, 27);
            this.userTextLabel.TabIndex = 6;
            this.userTextLabel.Text = "Пользователь";
            // 
            // simulationTimer
            // 
            this.simulationTimer.Interval = 1000;
            this.simulationTimer.Tick += new System.EventHandler(this.simulationTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.timeLabel.Location = new System.Drawing.Point(59, 377);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(105, 26);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Время (с)";
            // 
            // wordsRadioButton
            // 
            this.wordsRadioButton.AutoSize = true;
            this.wordsRadioButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.wordsRadioButton.Checked = true;
            this.wordsRadioButton.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsRadioButton.Location = new System.Drawing.Point(347, 335);
            this.wordsRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.wordsRadioButton.Name = "wordsRadioButton";
            this.wordsRadioButton.Size = new System.Drawing.Size(90, 26);
            this.wordsRadioButton.TabIndex = 8;
            this.wordsRadioButton.TabStop = true;
            this.wordsRadioButton.Text = "СлОвА";
            this.wordsRadioButton.UseVisualStyleBackColor = false;
            this.wordsRadioButton.CheckedChanged += new System.EventHandler(this.wordsRadioButton_CheckedChanged);
            // 
            // textRadioButton
            // 
            this.textRadioButton.AutoSize = true;
            this.textRadioButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textRadioButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textRadioButton.Location = new System.Drawing.Point(546, 278);
            this.textRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.textRadioButton.Name = "textRadioButton";
            this.textRadioButton.Size = new System.Drawing.Size(246, 32);
            this.textRadioButton.TabIndex = 9;
            this.textRadioButton.TabStop = true;
            this.textRadioButton.Text = "КОНТРОЛЬНЫЙ ТЕКСТ";
            this.textRadioButton.UseVisualStyleBackColor = true;
            this.textRadioButton.CheckedChanged += new System.EventHandler(this.textRadioButton_CheckedChanged);
            // 
            // lettersRadioButton
            // 
            this.lettersRadioButton.AutoSize = true;
            this.lettersRadioButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lettersRadioButton.Location = new System.Drawing.Point(12, 278);
            this.lettersRadioButton.Name = "lettersRadioButton";
            this.lettersRadioButton.Size = new System.Drawing.Size(216, 32);
            this.lettersRadioButton.TabIndex = 10;
            this.lettersRadioButton.TabStop = true;
            this.lettersRadioButton.Text = "БУКВЫ и СИМВОЛЫ";
            this.lettersRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(804, 459);
            this.Controls.Add(this.lettersRadioButton);
            this.Controls.Add(this.textRadioButton);
            this.Controls.Add(this.wordsRadioButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.userTextLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.totalClickLabel);
            this.Controls.Add(this.taskLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Задания";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label totalClickLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label userTextLabel;
        private System.Windows.Forms.Timer simulationTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.RadioButton wordsRadioButton;
        private System.Windows.Forms.RadioButton textRadioButton;
        private System.Windows.Forms.RadioButton lettersRadioButton;
    }
}

