﻿namespace Notes_App
{
    partial class EditWindow
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.richTextBoxTextEdit = new System.Windows.Forms.RichTextBox();
            this.textBoxTitleEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(12, 444);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(326, 23);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "✅";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // richTextBoxTextEdit
            // 
            this.richTextBoxTextEdit.Location = new System.Drawing.Point(12, 80);
            this.richTextBoxTextEdit.Name = "richTextBoxTextEdit";
            this.richTextBoxTextEdit.Size = new System.Drawing.Size(326, 358);
            this.richTextBoxTextEdit.TabIndex = 4;
            this.richTextBoxTextEdit.Text = "";
            // 
            // textBoxTitleEdit
            // 
            this.textBoxTitleEdit.Location = new System.Drawing.Point(12, 29);
            this.textBoxTitleEdit.Name = "textBoxTitleEdit";
            this.textBoxTitleEdit.Size = new System.Drawing.Size(326, 20);
            this.textBoxTitleEdit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nadpis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Obsah";
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 472);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.richTextBoxTextEdit);
            this.Controls.Add(this.textBoxTitleEdit);
            this.Name = "EditWindow";
            this.Text = "Upravit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.RichTextBox richTextBoxTextEdit;
        private System.Windows.Forms.TextBox textBoxTitleEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}