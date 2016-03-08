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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(12, 12);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(911, 24);
            this.userComboBox.TabIndex = 0;
            this.userComboBox.SelectedValueChanged += new System.EventHandler(this.userComboBox_SelectedValueChanged);
            // 
            // dateListBox
            // 
            this.dateListBox.FormattingEnabled = true;
            this.dateListBox.ItemHeight = 16;
            this.dateListBox.Location = new System.Drawing.Point(12, 85);
            this.dateListBox.Name = "dateListBox";
            this.dateListBox.Size = new System.Drawing.Size(220, 468);
            this.dateListBox.TabIndex = 1;
            this.dateListBox.SelectedValueChanged += new System.EventHandler(this.dateListBox_SelectedValueChanged);
            // 
            // InfoListBox
            // 
            this.InfoListBox.FormattingEnabled = true;
            this.InfoListBox.ItemHeight = 16;
            this.InfoListBox.Location = new System.Drawing.Point(242, 87);
            this.InfoListBox.Name = "InfoListBox";
            this.InfoListBox.Size = new System.Drawing.Size(681, 116);
            this.InfoListBox.TabIndex = 2;
            // 
            // graphicBox
            // 
            this.graphicBox.Location = new System.Drawing.Point(274, 212);
            this.graphicBox.Name = "graphicBox";
            this.graphicBox.Size = new System.Drawing.Size(649, 345);
            this.graphicBox.TabIndex = 3;
            this.graphicBox.TabStop = false;
            // 
            // sessionTypeComboBox
            // 
            this.sessionTypeComboBox.FormattingEnabled = true;
            this.sessionTypeComboBox.Location = new System.Drawing.Point(12, 42);
            this.sessionTypeComboBox.Name = "sessionTypeComboBox";
            this.sessionTypeComboBox.Size = new System.Drawing.Size(911, 24);
            this.sessionTypeComboBox.TabIndex = 4;
            this.sessionTypeComboBox.SelectedValueChanged += new System.EventHandler(this.sessionTypeComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "errors";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sessionTypeComboBox);
            this.Controls.Add(this.graphicBox);
            this.Controls.Add(this.InfoListBox);
            this.Controls.Add(this.dateListBox);
            this.Controls.Add(this.userComboBox);
            this.Name = "StatisticForm";
            this.Text = ".";
            ((System.ComponentModel.ISupportInitialize)(this.graphicBox)).EndInit();
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
    }
}