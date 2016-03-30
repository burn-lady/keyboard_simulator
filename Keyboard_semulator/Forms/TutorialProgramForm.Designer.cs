namespace Keyboard_semulator.Forms
{
    partial class TutorialProgramForm
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
            this.tutorialTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tutorialTextBox
            // 
            this.tutorialTextBox.Location = new System.Drawing.Point(12, 12);
            this.tutorialTextBox.Multiline = true;
            this.tutorialTextBox.Name = "tutorialTextBox";
            this.tutorialTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tutorialTextBox.Size = new System.Drawing.Size(853, 451);
            this.tutorialTextBox.TabIndex = 0;
            // 
            // TutorialProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 475);
            this.Controls.Add(this.tutorialTextBox);
            this.Name = "TutorialProgramForm";
            this.Text = "AboutProgramForm";
            this.Load += new System.EventHandler(this.AboutProgramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tutorialTextBox;
    }
}