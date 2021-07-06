
namespace View
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKoncerti = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreateConcert = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaKoncerataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvođačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreatePerformer = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaIzvođačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProfile,
            this.menuKoncerti,
            this.izvođačiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuProfile
            // 
            this.menuProfile.Name = "menuProfile";
            this.menuProfile.Size = new System.Drawing.Size(47, 20);
            this.menuProfile.Text = "Profil";
            this.menuProfile.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // menuKoncerti
            // 
            this.menuKoncerti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreateConcert,
            this.pretragaKoncerataToolStripMenuItem});
            this.menuKoncerti.Name = "menuKoncerti";
            this.menuKoncerti.Size = new System.Drawing.Size(63, 20);
            this.menuKoncerti.Text = "Koncerti";
            // 
            // menuCreateConcert
            // 
            this.menuCreateConcert.Name = "menuCreateConcert";
            this.menuCreateConcert.Size = new System.Drawing.Size(173, 22);
            this.menuCreateConcert.Text = "Kreiranje koncerta";
            this.menuCreateConcert.Click += new System.EventHandler(this.kreiranjeKoncertaToolStripMenuItem_Click);
            // 
            // pretragaKoncerataToolStripMenuItem
            // 
            this.pretragaKoncerataToolStripMenuItem.Name = "pretragaKoncerataToolStripMenuItem";
            this.pretragaKoncerataToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pretragaKoncerataToolStripMenuItem.Text = "Pretraga koncerata";
            this.pretragaKoncerataToolStripMenuItem.Click += new System.EventHandler(this.pretragaKoncerataToolStripMenuItem_Click);
            // 
            // izvođačiToolStripMenuItem
            // 
            this.izvođačiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreatePerformer,
            this.pretragaIzvođačaToolStripMenuItem});
            this.izvođačiToolStripMenuItem.Name = "izvođačiToolStripMenuItem";
            this.izvođačiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.izvođačiToolStripMenuItem.Text = "Izvođači";
            // 
            // menuCreatePerformer
            // 
            this.menuCreatePerformer.Name = "menuCreatePerformer";
            this.menuCreatePerformer.Size = new System.Drawing.Size(169, 22);
            this.menuCreatePerformer.Text = "Kreiranje izvođača";
            this.menuCreatePerformer.Click += new System.EventHandler(this.kreiranjeIzvođačaToolStripMenuItem_Click);
            // 
            // pretragaIzvođačaToolStripMenuItem
            // 
            this.pretragaIzvođačaToolStripMenuItem.Name = "pretragaIzvođačaToolStripMenuItem";
            this.pretragaIzvođačaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pretragaIzvođačaToolStripMenuItem.Text = "Pretraga izvođača";
            this.pretragaIzvođačaToolStripMenuItem.Click += new System.EventHandler(this.pretragaIzvođačaToolStripMenuItem_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 24);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1055, 631);
            this.pnlContainer.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 655);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.Text = "Koncerti App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ToolStripMenuItem menuKoncerti;
        private System.Windows.Forms.ToolStripMenuItem izvođačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaIzvođačaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCreateConcert;
        private System.Windows.Forms.ToolStripMenuItem menuCreatePerformer;
        private System.Windows.Forms.ToolStripMenuItem pretragaKoncerataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuProfile;
    }
}