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
            this.taskLabel = new System.Windows.Forms.Label();
            this.totalClickLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.listBoxTextFile = new System.Windows.Forms.ListBox();
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
            this.totalClickLabel.Location = new System.Drawing.Point(284, 33);
            this.totalClickLabel.Name = "totalClickLabel";
            this.totalClickLabel.Size = new System.Drawing.Size(99, 17);
            this.totalClickLabel.TabIndex = 1;
            this.totalClickLabel.Text = "totalClickLabel";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(31, 207);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 423);
            this.Controls.Add(this.listBoxTextFile);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.totalClickLabel);
            this.Controls.Add(this.taskLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label totalClickLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox listBoxTextFile;
    }
}

