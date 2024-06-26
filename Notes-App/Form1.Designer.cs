﻿namespace Notes_App
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.přidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odstranitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.LoadToolStripMenuItem,
            this.LoadAsToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.SaveToolStripMenuItem.Text = "Uložit";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.SaveAsToolStripMenuItem.Text = "Uložit jako";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.LoadToolStripMenuItem.Text = "Načíst";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // LoadAsToolStripMenuItem
            // 
            this.LoadAsToolStripMenuItem.Name = "LoadAsToolStripMenuItem";
            this.LoadAsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.LoadAsToolStripMenuItem.Text = "Načíst jako";
            this.LoadAsToolStripMenuItem.Click += new System.EventHandler(this.LoadAsToolStripMenuItem_Click);
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.Location = new System.Drawing.Point(0, 0);
            this.listBoxNotes.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(324, 447);
            this.listBoxNotes.TabIndex = 5;
            this.listBoxNotes.DoubleClick += new System.EventHandler(this.listBoxNotes_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přidatToolStripMenuItem,
            this.upravitToolStripMenuItem,
            this.odstranitToolStripMenuItem,
            this.otevřítToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 92);
            // 
            // přidatToolStripMenuItem
            // 
            this.přidatToolStripMenuItem.Name = "přidatToolStripMenuItem";
            this.přidatToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.přidatToolStripMenuItem.Text = "Přidat";
            this.přidatToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // upravitToolStripMenuItem
            // 
            this.upravitToolStripMenuItem.Name = "upravitToolStripMenuItem";
            this.upravitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.upravitToolStripMenuItem.Text = "Upravit";
            this.upravitToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // odstranitToolStripMenuItem
            // 
            this.odstranitToolStripMenuItem.Name = "odstranitToolStripMenuItem";
            this.odstranitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.odstranitToolStripMenuItem.Text = "Odstranit";
            this.odstranitToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // otevřítToolStripMenuItem
            // 
            this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
            this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.otevřítToolStripMenuItem.Text = "Otevřít";
            this.otevřítToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxNotes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 497);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonEdit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 447);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 50);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 50);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Přidat";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(216, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 50);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Odstranit";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(108, 0);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(108, 50);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Upravit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Poznámky";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadAsToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem přidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odstranitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
    }
}

