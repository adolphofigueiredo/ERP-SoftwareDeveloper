namespace _20240918_Database_FrameWork
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formEntityFrameworkExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem,
            this.corsiToolStripMenuItem,
            this.proToolStripMenuItem,
            this.oldToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.studentiToolStripMenuItem.Text = "Studenti";
            this.studentiToolStripMenuItem.Click += new System.EventHandler(this.studentiToolStripMenuItem_Click);
            // 
            // corsiToolStripMenuItem
            // 
            this.corsiToolStripMenuItem.Name = "corsiToolStripMenuItem";
            this.corsiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.corsiToolStripMenuItem.Text = "Corsi";
            this.corsiToolStripMenuItem.Click += new System.EventHandler(this.corsiToolStripMenuItem_Click);
            // 
            // proToolStripMenuItem
            // 
            this.proToolStripMenuItem.Name = "proToolStripMenuItem";
            this.proToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.proToolStripMenuItem.Text = "Pro";
            // 
            // oldToolStripMenuItem
            // 
            this.oldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form01ToolStripMenuItem,
            this.formEntityFrameworkExampleToolStripMenuItem});
            this.oldToolStripMenuItem.Name = "oldToolStripMenuItem";
            this.oldToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.oldToolStripMenuItem.Text = "Old";
            // 
            // form01ToolStripMenuItem
            // 
            this.form01ToolStripMenuItem.Name = "form01ToolStripMenuItem";
            this.form01ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.form01ToolStripMenuItem.Text = "Form01";
            this.form01ToolStripMenuItem.Click += new System.EventHandler(this.Form1_Click);
            // 
            // formEntityFrameworkExampleToolStripMenuItem
            // 
            this.formEntityFrameworkExampleToolStripMenuItem.Name = "formEntityFrameworkExampleToolStripMenuItem";
            this.formEntityFrameworkExampleToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.formEntityFrameworkExampleToolStripMenuItem.Text = "FormEntityFrameworkExample";
            this.formEntityFrameworkExampleToolStripMenuItem.Click += new System.EventHandler(this.FrmEntityFrameworkExample_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Gestionali Studenti";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formEntityFrameworkExampleToolStripMenuItem;
    }
}