
namespace View.UserControls
{
    partial class SaveConcert
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbConcertName = new System.Windows.Forms.TextBox();
            this.tbStreetNumber = new System.Windows.Forms.TextBox();
            this.cbAddress = new System.Windows.Forms.ComboBox();
            this.dtpDatetime = new System.Windows.Forms.DateTimePicker();
            this.tbSlotNumber = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPerformers = new System.Windows.Forms.DataGridView();
            this.btnAddPerformer = new System.Windows.Forms.Button();
            this.cbPerformer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemovePerformer = new System.Windows.Forms.Button();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbCity);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.tbSlotNumber);
            this.panel1.Controls.Add(this.dtpDatetime);
            this.panel1.Controls.Add(this.cbAddress);
            this.panel1.Controls.Add(this.tbStreetNumber);
            this.panel1.Controls.Add(this.tbConcertName);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 618);
            this.panel1.TabIndex = 0;
            // 
            // tbConcertName
            // 
            this.tbConcertName.Location = new System.Drawing.Point(110, 57);
            this.tbConcertName.Name = "tbConcertName";
            this.tbConcertName.Size = new System.Drawing.Size(688, 20);
            this.tbConcertName.TabIndex = 0;
            // 
            // tbStreetNumber
            // 
            this.tbStreetNumber.Location = new System.Drawing.Point(407, 84);
            this.tbStreetNumber.Name = "tbStreetNumber";
            this.tbStreetNumber.Size = new System.Drawing.Size(77, 20);
            this.tbStreetNumber.TabIndex = 2;
            // 
            // cbAddress
            // 
            this.cbAddress.FormattingEnabled = true;
            this.cbAddress.Location = new System.Drawing.Point(110, 84);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(291, 21);
            this.cbAddress.TabIndex = 3;
            this.cbAddress.SelectedIndexChanged += new System.EventHandler(this.cbAddress_SelectedIndexChanged);
            // 
            // dtpDatetime
            // 
            this.dtpDatetime.Location = new System.Drawing.Point(110, 111);
            this.dtpDatetime.Name = "dtpDatetime";
            this.dtpDatetime.Size = new System.Drawing.Size(291, 20);
            this.dtpDatetime.TabIndex = 4;
            // 
            // tbSlotNumber
            // 
            this.tbSlotNumber.Location = new System.Drawing.Point(716, 111);
            this.tbSlotNumber.Name = "tbSlotNumber";
            this.tbSlotNumber.Size = new System.Drawing.Size(82, 20);
            this.tbSlotNumber.TabIndex = 5;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(507, 111);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(76, 20);
            this.tbPrice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Broj mesta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cena karata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vreme održavanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Naziv koncerta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "RSD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 33);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kreiranje koncerta";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(15, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(783, 34);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Sačuvaj koncert";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbPerformer);
            this.groupBox1.Controls.Add(this.btnAddPerformer);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(15, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 388);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje izvođača";
            // 
            // dgvPerformers
            // 
            this.dgvPerformers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerformers.Location = new System.Drawing.Point(6, 19);
            this.dgvPerformers.Name = "dgvPerformers";
            this.dgvPerformers.ReadOnly = true;
            this.dgvPerformers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerformers.Size = new System.Drawing.Size(591, 304);
            this.dgvPerformers.TabIndex = 1;
            // 
            // btnAddPerformer
            // 
            this.btnAddPerformer.Location = new System.Drawing.Point(616, 18);
            this.btnAddPerformer.Name = "btnAddPerformer";
            this.btnAddPerformer.Size = new System.Drawing.Size(142, 23);
            this.btnAddPerformer.TabIndex = 3;
            this.btnAddPerformer.Text = "Dodaj izvođača";
            this.btnAddPerformer.UseVisualStyleBackColor = true;
            this.btnAddPerformer.Click += new System.EventHandler(this.btnAddPerformer_Click);
            // 
            // cbPerformer
            // 
            this.cbPerformer.FormattingEnabled = true;
            this.cbPerformer.Location = new System.Drawing.Point(283, 20);
            this.cbPerformer.Name = "cbPerformer";
            this.cbPerformer.Size = new System.Drawing.Size(327, 21);
            this.cbPerformer.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Izvođač";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemovePerformer);
            this.groupBox2.Controls.Add(this.dgvPerformers);
            this.groupBox2.Location = new System.Drawing.Point(13, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 329);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodati izvođači";
            // 
            // btnRemovePerformer
            // 
            this.btnRemovePerformer.Location = new System.Drawing.Point(603, 19);
            this.btnRemovePerformer.Name = "btnRemovePerformer";
            this.btnRemovePerformer.Size = new System.Drawing.Size(142, 23);
            this.btnRemovePerformer.TabIndex = 7;
            this.btnRemovePerformer.Text = "Ukloni izvođača";
            this.btnRemovePerformer.UseVisualStyleBackColor = true;
            this.btnRemovePerformer.Click += new System.EventHandler(this.btnRemovePerformer_Click);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(507, 84);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(291, 20);
            this.tbCity.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(490, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = ",";
            // 
            // SaveConcert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SaveConcert";
            this.Size = new System.Drawing.Size(821, 623);
            this.Load += new System.EventHandler(this.SaveConcert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbAddress;
        private System.Windows.Forms.TextBox tbStreetNumber;
        private System.Windows.Forms.TextBox tbConcertName;
        private System.Windows.Forms.DateTimePicker dtpDatetime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbSlotNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPerformer;
        private System.Windows.Forms.Button btnAddPerformer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemovePerformer;
        private System.Windows.Forms.DataGridView dgvPerformers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCity;
    }
}
