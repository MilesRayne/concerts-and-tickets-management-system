
namespace View.UserControls
{
    partial class SearchPerformer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSearchPerformer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFoundPerformers = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSelectedPerformer = new System.Windows.Forms.GroupBox();
            this.dgvConcerts = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbArtistName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlSearchPerformer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundPerformers)).BeginInit();
            this.gbSelectedPerformer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcerts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchPerformer
            // 
            this.pnlSearchPerformer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSearchPerformer.Controls.Add(this.btnCancel);
            this.pnlSearchPerformer.Controls.Add(this.label2);
            this.pnlSearchPerformer.Controls.Add(this.dgvFoundPerformers);
            this.pnlSearchPerformer.Controls.Add(this.btnSearch);
            this.pnlSearchPerformer.Controls.Add(this.tbQuery);
            this.pnlSearchPerformer.Controls.Add(this.label1);
            this.pnlSearchPerformer.Controls.Add(this.gbSelectedPerformer);
            this.pnlSearchPerformer.Location = new System.Drawing.Point(3, 3);
            this.pnlSearchPerformer.Name = "pnlSearchPerformer";
            this.pnlSearchPerformer.Size = new System.Drawing.Size(861, 520);
            this.pnlSearchPerformer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pronađeni izvođači:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvFoundPerformers
            // 
            this.dgvFoundPerformers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundPerformers.Location = new System.Drawing.Point(17, 99);
            this.dgvFoundPerformers.Name = "dgvFoundPerformers";
            this.dgvFoundPerformers.ReadOnly = true;
            this.dgvFoundPerformers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoundPerformers.Size = new System.Drawing.Size(409, 403);
            this.dgvFoundPerformers.TabIndex = 4;
            this.dgvFoundPerformers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoundPerformers_CellContentClick);
            this.dgvFoundPerformers.SelectionChanged += new System.EventHandler(this.dgvFoundPerformers_SelectionChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(274, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(17, 47);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(251, 20);
            this.tbQuery.TabIndex = 2;
            this.tbQuery.TextChanged += new System.EventHandler(this.tbQuery_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraga izvođača";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbSelectedPerformer
            // 
            this.gbSelectedPerformer.Controls.Add(this.dgvConcerts);
            this.gbSelectedPerformer.Controls.Add(this.label5);
            this.gbSelectedPerformer.Controls.Add(this.tbGenre);
            this.gbSelectedPerformer.Controls.Add(this.tbArtistName);
            this.gbSelectedPerformer.Controls.Add(this.label4);
            this.gbSelectedPerformer.Controls.Add(this.label3);
            this.gbSelectedPerformer.Location = new System.Drawing.Point(432, 19);
            this.gbSelectedPerformer.Name = "gbSelectedPerformer";
            this.gbSelectedPerformer.Size = new System.Drawing.Size(415, 489);
            this.gbSelectedPerformer.TabIndex = 0;
            this.gbSelectedPerformer.TabStop = false;
            this.gbSelectedPerformer.Text = "Detalji o izabranom izvođaču";
            this.gbSelectedPerformer.Enter += new System.EventHandler(this.gbSelectedPerformer_Enter);
            // 
            // dgvConcerts
            // 
            this.dgvConcerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConcerts.Location = new System.Drawing.Point(9, 115);
            this.dgvConcerts.Name = "dgvConcerts";
            this.dgvConcerts.ReadOnly = true;
            this.dgvConcerts.Size = new System.Drawing.Size(400, 368);
            this.dgvConcerts.TabIndex = 5;
            this.dgvConcerts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConcerts_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Koncerti na kojima odabrani izvođač učestvuje:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(172, 61);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.ReadOnly = true;
            this.tbGenre.Size = new System.Drawing.Size(237, 20);
            this.tbGenre.TabIndex = 3;
            this.tbGenre.TextChanged += new System.EventHandler(this.tbGenre_TextChanged);
            // 
            // tbArtistName
            // 
            this.tbArtistName.Location = new System.Drawing.Point(172, 32);
            this.tbArtistName.Name = "tbArtistName";
            this.tbArtistName.ReadOnly = true;
            this.tbArtistName.Size = new System.Drawing.Size(237, 20);
            this.tbArtistName.TabIndex = 2;
            this.tbArtistName.TextChanged += new System.EventHandler(this.tbArtistName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Žanr muzike";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Naziv izvođača / umetničko ime";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Poništi";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SearchPerformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSearchPerformer);
            this.Name = "SearchPerformer";
            this.Size = new System.Drawing.Size(867, 526);
            this.Load += new System.EventHandler(this.SearchPerformer_Load);
            this.pnlSearchPerformer.ResumeLayout(false);
            this.pnlSearchPerformer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundPerformers)).EndInit();
            this.gbSelectedPerformer.ResumeLayout(false);
            this.gbSelectedPerformer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConcerts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchPerformer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFoundPerformers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSelectedPerformer;
        private System.Windows.Forms.DataGridView dgvConcerts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbArtistName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
    }
}
