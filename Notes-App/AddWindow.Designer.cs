namespace Notes_App
{
    partial class AddWindow
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
            this.textBoxTitleAdd = new System.Windows.Forms.TextBox();
            this.richTextBoxTextAdd = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTitleAdd
            // 
            this.textBoxTitleAdd.Location = new System.Drawing.Point(13, 25);
            this.textBoxTitleAdd.Name = "textBoxTitleAdd";
            this.textBoxTitleAdd.Size = new System.Drawing.Size(326, 20);
            this.textBoxTitleAdd.TabIndex = 0;
            // 
            // richTextBoxTextAdd
            // 
            this.richTextBoxTextAdd.Location = new System.Drawing.Point(13, 76);
            this.richTextBoxTextAdd.Name = "richTextBoxTextAdd";
            this.richTextBoxTextAdd.Size = new System.Drawing.Size(326, 362);
            this.richTextBoxTextAdd.TabIndex = 1;
            this.richTextBoxTextAdd.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 444);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(326, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Obsah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nadpis";
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.richTextBoxTextAdd);
            this.Controls.Add(this.textBoxTitleAdd);
            this.Name = "AddWindow";
            this.Text = "Vytvořit poznámku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitleAdd;
        private System.Windows.Forms.RichTextBox richTextBoxTextAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}