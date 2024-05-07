namespace ProcházkaP_PoznámkovýBlok
{
    partial class ViewWindow
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
            this.richTextBoxTextView = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxTextView
            // 
            this.richTextBoxTextView.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxTextView.Name = "richTextBoxTextView";
            this.richTextBoxTextView.ReadOnly = true;
            this.richTextBoxTextView.Size = new System.Drawing.Size(776, 426);
            this.richTextBoxTextView.TabIndex = 3;
            this.richTextBoxTextView.Text = "";
            // 
            // ViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxTextView);
            this.Name = "ViewWindow";
            this.Text = "ViewWindow";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxTextView;
    }
}