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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.taskLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskLabel.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.taskLabel.Location = new System.Drawing.Point(1, 23);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(1139, 50);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Задание                                                           ";
            this.taskLabel.Click += new System.EventHandler(this.taskLabel_Click);
            // 
            // totalClickLabel
            // 
            this.totalClickLabel.AutoSize = true;
            this.totalClickLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.totalClickLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalClickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalClickLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.totalClickLabel.Location = new System.Drawing.Point(332, 198);
            this.totalClickLabel.Name = "totalClickLabel";
            this.totalClickLabel.Size = new System.Drawing.Size(39, 41);
            this.totalClickLabel.TabIndex = 1;
            this.totalClickLabel.Text = "0";
            this.totalClickLabel.Click += new System.EventHandler(this.totalClickLabel_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightBlue;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(397, 255);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startButton.Size = new System.Drawing.Size(255, 103);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(51, 235);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 15);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userTextLabel
            // 
            this.userTextLabel.AutoSize = true;
            this.userTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTextLabel.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.userTextLabel.Location = new System.Drawing.Point(12, 480);
            this.userTextLabel.Name = "userTextLabel";
            this.userTextLabel.Size = new System.Drawing.Size(216, 33);
            this.userTextLabel.TabIndex = 6;
            this.userTextLabel.Text = "Пользователь :";
            // 
            // simulationTimer
            // 
            this.simulationTimer.Interval = 1000;
            this.simulationTimer.Tick += new System.EventHandler(this.simulationTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.timeLabel.Location = new System.Drawing.Point(12, 440);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(243, 31);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Время (милисек) :";
            // 
            // wordsRadioButton
            // 
            this.wordsRadioButton.AutoSize = true;
            this.wordsRadioButton.BackColor = System.Drawing.Color.SkyBlue;
            this.wordsRadioButton.Checked = true;
            this.wordsRadioButton.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsRadioButton.Location = new System.Drawing.Point(468, 378);
            this.wordsRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wordsRadioButton.Name = "wordsRadioButton";
            this.wordsRadioButton.Size = new System.Drawing.Size(101, 31);
            this.wordsRadioButton.TabIndex = 8;
            this.wordsRadioButton.TabStop = true;
            this.wordsRadioButton.Text = "СлОвА";
            this.wordsRadioButton.UseVisualStyleBackColor = false;
            this.wordsRadioButton.CheckedChanged += new System.EventHandler(this.wordsRadioButton_CheckedChanged);
            // 
            // textRadioButton
            // 
            this.textRadioButton.AutoSize = true;
            this.textRadioButton.BackColor = System.Drawing.Color.SkyBlue;
            this.textRadioButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textRadioButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textRadioButton.Location = new System.Drawing.Point(725, 297);
            this.textRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRadioButton.Name = "textRadioButton";
            this.textRadioButton.Size = new System.Drawing.Size(302, 39);
            this.textRadioButton.TabIndex = 9;
            this.textRadioButton.TabStop = true;
            this.textRadioButton.Text = "КОНТРОЛЬНЫЙ ТЕКСТ";
            this.textRadioButton.UseVisualStyleBackColor = false;
            this.textRadioButton.CheckedChanged += new System.EventHandler(this.textRadioButton_CheckedChanged);
            // 
            // lettersRadioButton
            // 
            this.lettersRadioButton.AutoSize = true;
            this.lettersRadioButton.BackColor = System.Drawing.Color.SkyBlue;
            this.lettersRadioButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lettersRadioButton.Location = new System.Drawing.Point(16, 297);
            this.lettersRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lettersRadioButton.Name = "lettersRadioButton";
            this.lettersRadioButton.Size = new System.Drawing.Size(267, 39);
            this.lettersRadioButton.TabIndex = 10;
            this.lettersRadioButton.TabStop = true;
            this.lettersRadioButton.Text = "БУКВЫ и СИМВОЛЫ";
            this.lettersRadioButton.UseVisualStyleBackColor = false;
            this.lettersRadioButton.CheckedChanged += new System.EventHandler(this.lettersRadioButton_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1072, 479);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(925, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Время сессии (сек)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(928, 491);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1072, 565);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lettersRadioButton);
            this.Controls.Add(this.textRadioButton);
            this.Controls.Add(this.wordsRadioButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.userTextLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.totalClickLabel);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Задания";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

