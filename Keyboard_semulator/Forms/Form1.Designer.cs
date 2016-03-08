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
            this.listBoxTextFile = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userTextLabel = new System.Windows.Forms.Label();
            this.simulationTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.wordsRadioButton = new System.Windows.Forms.RadioButton();
            this.textRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(28, 33);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(34, 17);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "task";
            // 
            // totalClickLabel
            // 
            this.totalClickLabel.AutoSize = true;
            this.totalClickLabel.Location = new System.Drawing.Point(137, 238);
            this.totalClickLabel.Name = "totalClickLabel";
            this.totalClickLabel.Size = new System.Drawing.Size(99, 17);
            this.totalClickLabel.TabIndex = 1;
            this.totalClickLabel.Text = "totalClickLabel";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(31, 263);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(636, 49);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButtonClick);
            // 
            // listBoxTextFile
            // 
            this.listBoxTextFile.FormattingEnabled = true;
            this.listBoxTextFile.ItemHeight = 16;
            this.listBoxTextFile.Location = new System.Drawing.Point(31, 69);
            this.listBoxTextFile.Name = "listBoxTextFile";
            this.listBoxTextFile.Size = new System.Drawing.Size(636, 132);
            this.listBoxTextFile.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userTextLabel
            // 
            this.userTextLabel.AutoSize = true;
            this.userTextLabel.Location = new System.Drawing.Point(12, 397);
            this.userTextLabel.Name = "userTextLabel";
            this.userTextLabel.Size = new System.Drawing.Size(101, 17);
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
            this.timeLabel.Location = new System.Drawing.Point(12, 380);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(34, 17);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "time";
            // 
            // wordsRadioButton
            // 
            this.wordsRadioButton.AutoSize = true;
            this.wordsRadioButton.Checked = true;
            this.wordsRadioButton.Location = new System.Drawing.Point(31, 318);
            this.wordsRadioButton.Name = "wordsRadioButton";
            this.wordsRadioButton.Size = new System.Drawing.Size(69, 21);
            this.wordsRadioButton.TabIndex = 8;
            this.wordsRadioButton.TabStop = true;
            this.wordsRadioButton.Text = "Слова";
            this.wordsRadioButton.UseVisualStyleBackColor = true;
            // 
            // textRadioButton
            // 
            this.textRadioButton.AutoSize = true;
            this.textRadioButton.Location = new System.Drawing.Point(106, 318);
            this.textRadioButton.Name = "textRadioButton";
            this.textRadioButton.Size = new System.Drawing.Size(165, 21);
            this.textRadioButton.TabIndex = 9;
            this.textRadioButton.TabStop = true;
            this.textRadioButton.Text = "Констрольный текст";
            this.textRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 423);
            this.Controls.Add(this.textRadioButton);
            this.Controls.Add(this.wordsRadioButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.userTextLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxTextFile);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.totalClickLabel);
            this.Controls.Add(this.taskLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label totalClickLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox listBoxTextFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label userTextLabel;
        private System.Windows.Forms.Timer simulationTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.RadioButton wordsRadioButton;
        private System.Windows.Forms.RadioButton textRadioButton;
    }
}

