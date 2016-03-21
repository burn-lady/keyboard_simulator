namespace Keyboard_semulator.Forms
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.dateListBox = new System.Windows.Forms.ListBox();
            this.InfoListBox = new System.Windows.Forms.ListBox();
            this.graphicBox = new System.Windows.Forms.PictureBox();
            this.sessionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userComboBox
            // 
            this.userComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.userComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userComboBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(31, 6);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(514, 21);
            this.userComboBox.TabIndex = 0;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            this.userComboBox.SelectedValueChanged += new System.EventHandler(this.userComboBox_SelectedValueChanged);
            // 
            // dateListBox
            // 
            this.dateListBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dateListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateListBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dateListBox.FormattingEnabled = true;
            this.dateListBox.ItemHeight = 15;
            this.dateListBox.Location = new System.Drawing.Point(11, 72);
            this.dateListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateListBox.Name = "dateListBox";
            this.dateListBox.Size = new System.Drawing.Size(166, 364);
            this.dateListBox.TabIndex = 1;
            this.dateListBox.SelectedValueChanged += new System.EventHandler(this.dateListBox_SelectedValueChanged);
            // 
            // InfoListBox
            // 
            this.InfoListBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.InfoListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoListBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.InfoListBox.FormattingEnabled = true;
            this.InfoListBox.ItemHeight = 15;
            this.InfoListBox.Location = new System.Drawing.Point(216, 72);
            this.InfoListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InfoListBox.Name = "InfoListBox";
            this.InfoListBox.Size = new System.Drawing.Size(512, 79);
            this.InfoListBox.TabIndex = 2;
            // 
            // graphicBox
            // 
            this.graphicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphicBox.Location = new System.Drawing.Point(206, 176);
            this.graphicBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graphicBox.Name = "graphicBox";
            this.graphicBox.Size = new System.Drawing.Size(540, 268);
            this.graphicBox.TabIndex = 3;
            this.graphicBox.TabStop = false;
            // 
            // sessionTypeComboBox
            // 
            this.sessionTypeComboBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.sessionTypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sessionTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionTypeComboBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.sessionTypeComboBox.FormattingEnabled = true;
            this.sessionTypeComboBox.Location = new System.Drawing.Point(31, 34);
            this.sessionTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sessionTypeComboBox.Name = "sessionTypeComboBox";
            this.sessionTypeComboBox.Size = new System.Drawing.Size(514, 23);
            this.sessionTypeComboBox.TabIndex = 4;
            this.sessionTypeComboBox.SelectedValueChanged += new System.EventHandler(this.sessionTypeComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(179, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(402, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Время сессии";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 492);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(752, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sessionTypeComboBox);
            this.Controls.Add(this.graphicBox);
            this.Controls.Add(this.InfoListBox);
            this.Controls.Add(this.dateListBox);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StatisticForm";
            this.Text = "Статистика ";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.ListBox dateListBox;
        private System.Windows.Forms.ListBox InfoListBox;
        private System.Windows.Forms.PictureBox graphicBox;
        private System.Windows.Forms.ComboBox sessionTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}