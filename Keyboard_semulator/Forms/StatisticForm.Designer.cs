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
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.dateListBox = new System.Windows.Forms.ListBox();
            this.InfoListBox = new System.Windows.Forms.ListBox();
            this.graphicBox = new System.Windows.Forms.PictureBox();
            this.sessionTypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(12, 12);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(861, 24);
            this.userComboBox.TabIndex = 0;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            this.userComboBox.SelectedValueChanged += new System.EventHandler(this.userComboBox_SelectedValueChanged);
            // 
            // dateListBox
            // 
            this.dateListBox.FormattingEnabled = true;
            this.dateListBox.ItemHeight = 16;
            this.dateListBox.Location = new System.Drawing.Point(12, 85);
            this.dateListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateListBox.Name = "dateListBox";
            this.dateListBox.Size = new System.Drawing.Size(220, 292);
            this.dateListBox.TabIndex = 1;
            this.dateListBox.SelectedValueChanged += new System.EventHandler(this.dateListBox_SelectedValueChanged);
            // 
            // InfoListBox
            // 
            this.InfoListBox.FormattingEnabled = true;
            this.InfoListBox.ItemHeight = 16;
            this.InfoListBox.Location = new System.Drawing.Point(12, 390);
            this.InfoListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoListBox.Name = "InfoListBox";
            this.InfoListBox.Size = new System.Drawing.Size(220, 164);
            this.InfoListBox.TabIndex = 2;
            // 
            // graphicBox
            // 
            this.graphicBox.Location = new System.Drawing.Point(243, 85);
            this.graphicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphicBox.Name = "graphicBox";
            this.graphicBox.Size = new System.Drawing.Size(630, 480);
            this.graphicBox.TabIndex = 3;
            this.graphicBox.TabStop = false;
            // 
            // sessionTypeComboBox
            // 
            this.sessionTypeComboBox.FormattingEnabled = true;
            this.sessionTypeComboBox.Location = new System.Drawing.Point(12, 42);
            this.sessionTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sessionTypeComboBox.Name = "sessionTypeComboBox";
            this.sessionTypeComboBox.Size = new System.Drawing.Size(861, 24);
            this.sessionTypeComboBox.TabIndex = 4;
            this.sessionTypeComboBox.SelectedValueChanged += new System.EventHandler(this.sessionTypeComboBox_SelectedValueChanged);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 580);
            this.Controls.Add(this.sessionTypeComboBox);
            this.Controls.Add(this.graphicBox);
            this.Controls.Add(this.InfoListBox);
            this.Controls.Add(this.dateListBox);
            this.Controls.Add(this.userComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StatisticForm";
            this.Text = ".";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.ListBox dateListBox;
        private System.Windows.Forms.ListBox InfoListBox;
        private System.Windows.Forms.PictureBox graphicBox;
        private System.Windows.Forms.ComboBox sessionTypeComboBox;
    }
}