
namespace View.UserControls
{
    partial class SearchConcert
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFoundConcerts = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSelectedPerformer = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemovePerformer = new System.Windows.Forms.Button();
            this.btnAddPerformer = new System.Windows.Forms.Button();
            this.lblPerformer = new System.Windows.Forms.Label();
            this.cbPerformers = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRemainingSlots = new System.Windows.Forms.TextBox();
            this.tbTotalSlots = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPerformers = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundConcerts)).BeginInit();
            this.gbSelectedPerformer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContainer.Controls.Add(this.btnCancel);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Controls.Add(this.dgvFoundConcerts);
            this.pnlContainer.Controls.Add(this.btnSearch);
            this.pnlContainer.Controls.Add(this.tbQuery);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.gbSelectedPerformer);
            this.pnlContainer.Location = new System.Drawing.Point(3, 4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(863, 556);
            this.pnlContainer.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(356, 46);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Poništi";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pronađeni koncerti:";
            // 
            // dgvFoundConcerts
            // 
            this.dgvFoundConcerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundConcerts.Location = new System.Drawing.Point(20, 103);
            this.dgvFoundConcerts.Name = "dgvFoundConcerts";
            this.dgvFoundConcerts.ReadOnly = true;
            this.dgvFoundConcerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoundConcerts.Size = new System.Drawing.Size(409, 441);
            this.dgvFoundConcerts.TabIndex = 10;
            this.dgvFoundConcerts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoundConcerts_CellContentClick);
            this.dgvFoundConcerts.SelectionChanged += new System.EventHandler(this.dgvFoundConcerts_SelectionChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(277, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(20, 51);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(251, 20);
            this.tbQuery.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pretraga koncerata";
            // 
            // gbSelectedPerformer
            // 
            this.gbSelectedPerformer.Controls.Add(this.btnDelete);
            this.gbSelectedPerformer.Controls.Add(this.btnSave);
            this.gbSelectedPerformer.Controls.Add(this.btnRemovePerformer);
            this.gbSelectedPerformer.Controls.Add(this.btnAddPerformer);
            this.gbSelectedPerformer.Controls.Add(this.lblPerformer);
            this.gbSelectedPerformer.Controls.Add(this.cbPerformers);
            this.gbSelectedPerformer.Controls.Add(this.btnBuy);
            this.gbSelectedPerformer.Controls.Add(this.label10);
            this.gbSelectedPerformer.Controls.Add(this.tbPrice);
            this.gbSelectedPerformer.Controls.Add(this.label9);
            this.gbSelectedPerformer.Controls.Add(this.label8);
            this.gbSelectedPerformer.Controls.Add(this.tbRemainingSlots);
            this.gbSelectedPerformer.Controls.Add(this.tbTotalSlots);
            this.gbSelectedPerformer.Controls.Add(this.label7);
            this.gbSelectedPerformer.Controls.Add(this.tbDate);
            this.gbSelectedPerformer.Controls.Add(this.label6);
            this.gbSelectedPerformer.Controls.Add(this.dgvPerformers);
            this.gbSelectedPerformer.Controls.Add(this.label5);
            this.gbSelectedPerformer.Controls.Add(this.tbAddress);
            this.gbSelectedPerformer.Controls.Add(this.tbName);
            this.gbSelectedPerformer.Controls.Add(this.label4);
            this.gbSelectedPerformer.Controls.Add(this.label3);
            this.gbSelectedPerformer.Location = new System.Drawing.Point(435, 17);
            this.gbSelectedPerformer.Name = "gbSelectedPerformer";
            this.gbSelectedPerformer.Size = new System.Drawing.Size(421, 533);
            this.gbSelectedPerformer.TabIndex = 6;
            this.gbSelectedPerformer.TabStop = false;
            this.gbSelectedPerformer.Text = "Detalji o izabranom koncertu:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(9, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Obriši koncert";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(265, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAČUVAJ IZMENE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemovePerformer
            // 
            this.btnRemovePerformer.Location = new System.Drawing.Point(280, 193);
            this.btnRemovePerformer.Name = "btnRemovePerformer";
            this.btnRemovePerformer.Size = new System.Drawing.Size(135, 23);
            this.btnRemovePerformer.TabIndex = 19;
            this.btnRemovePerformer.Text = "Ukloni izvođača";
            this.btnRemovePerformer.UseVisualStyleBackColor = true;
            this.btnRemovePerformer.Click += new System.EventHandler(this.btnRemovePerformer_Click);
            // 
            // btnAddPerformer
            // 
            this.btnAddPerformer.Location = new System.Drawing.Point(308, 159);
            this.btnAddPerformer.Name = "btnAddPerformer";
            this.btnAddPerformer.Size = new System.Drawing.Size(107, 23);
            this.btnAddPerformer.TabIndex = 18;
            this.btnAddPerformer.Text = "Dodaj";
            this.btnAddPerformer.UseVisualStyleBackColor = true;
            this.btnAddPerformer.Click += new System.EventHandler(this.btnAddPerformer_Click);
            // 
            // lblPerformer
            // 
            this.lblPerformer.AutoSize = true;
            this.lblPerformer.Location = new System.Drawing.Point(23, 164);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(46, 13);
            this.lblPerformer.TabIndex = 17;
            this.lblPerformer.Text = "Izvođač";
            // 
            // cbPerformers
            // 
            this.cbPerformers.FormattingEnabled = true;
            this.cbPerformers.Location = new System.Drawing.Point(75, 161);
            this.cbPerformers.Name = "cbPerformers";
            this.cbPerformers.Size = new System.Drawing.Size(227, 21);
            this.cbPerformers.TabIndex = 16;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(9, 504);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(406, 23);
            this.btnBuy.TabIndex = 15;
            this.btnBuy.Text = "Kupi kartu";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "RSD";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(75, 87);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(126, 20);
            this.tbPrice.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cena";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "/";
            // 
            // tbRemainingSlots
            // 
            this.tbRemainingSlots.Location = new System.Drawing.Point(177, 113);
            this.tbRemainingSlots.Name = "tbRemainingSlots";
            this.tbRemainingSlots.ReadOnly = true;
            this.tbRemainingSlots.Size = new System.Drawing.Size(107, 20);
            this.tbRemainingSlots.TabIndex = 10;
            // 
            // tbTotalSlots
            // 
            this.tbTotalSlots.Location = new System.Drawing.Point(308, 113);
            this.tbTotalSlots.Name = "tbTotalSlots";
            this.tbTotalSlots.ReadOnly = true;
            this.tbTotalSlots.Size = new System.Drawing.Size(107, 20);
            this.tbTotalSlots.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Broj preostalih mesta";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(308, 87);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(107, 20);
            this.tbDate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Datum";
            // 
            // dgvPerformers
            // 
            this.dgvPerformers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerformers.Location = new System.Drawing.Point(9, 222);
            this.dgvPerformers.Name = "dgvPerformers";
            this.dgvPerformers.ReadOnly = true;
            this.dgvPerformers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerformers.Size = new System.Drawing.Size(406, 247);
            this.dgvPerformers.TabIndex = 5;
            this.dgvPerformers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformers_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Izvođači koji učestvuju na datom koncertu:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(75, 61);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(340, 20);
            this.tbAddress.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(75, 32);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(340, 20);
            this.tbName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Naziv";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SearchConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Name = "SearchConcert";
            this.Size = new System.Drawing.Size(876, 568);
            this.Load += new System.EventHandler(this.SearchConcert_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundConcerts)).EndInit();
            this.gbSelectedPerformer.ResumeLayout(false);
            this.gbSelectedPerformer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFoundConcerts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSelectedPerformer;
        private System.Windows.Forms.DataGridView dgvPerformers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRemainingSlots;
        private System.Windows.Forms.TextBox tbTotalSlots;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnRemovePerformer;
        private System.Windows.Forms.Button btnAddPerformer;
        private System.Windows.Forms.Label lblPerformer;
        private System.Windows.Forms.ComboBox cbPerformers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}
