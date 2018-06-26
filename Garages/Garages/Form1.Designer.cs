namespace Garages
{
    partial class Form1
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
            this.btnEinde = new System.Windows.Forms.Button();
            this.lblChassisnummer = new System.Windows.Forms.Label();
            this.txbChassisnummer = new System.Windows.Forms.TextBox();
            this.lblKenteken = new System.Windows.Forms.Label();
            this.txbKenteken = new System.Windows.Forms.TextBox();
            this.lblFabricageDatum = new System.Windows.Forms.Label();
            this.dtpFabricageDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatumOpKenteken = new System.Windows.Forms.Label();
            this.dtpDatumOpKenteken = new System.Windows.Forms.DateTimePicker();
            this.lblMerk = new System.Windows.Forms.Label();
            this.txbMerk = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txbType = new System.Windows.Forms.TextBox();
            this.lblKleur = new System.Windows.Forms.Label();
            this.txbKleur = new System.Windows.Forms.TextBox();
            this.lblBrandstof = new System.Windows.Forms.Label();
            this.txbBrandstof = new System.Windows.Forms.TextBox();
            this.lblAantalKilowats = new System.Windows.Forms.Label();
            this.txbAantalKilowats = new System.Windows.Forms.TextBox();
            this.lblAantalPortieren = new System.Windows.Forms.Label();
            this.txbAantalPortieren = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.lblTrekhaak = new System.Windows.Forms.Label();
            this.chbTrekhaak = new System.Windows.Forms.CheckBox();
            this.KleurPicker = new System.Windows.Forms.ColorDialog();
            this.lblZoekMerk = new System.Windows.Forms.Label();
            this.cmbMerk = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbChassisnummer = new System.Windows.Forms.ComboBox();
            this.lblZoekChassisnummer = new System.Windows.Forms.Label();
            this.cmbKenteken = new System.Windows.Forms.ComboBox();
            this.lblZoekKenteken = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblZoekType = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.lblZoekModel = new System.Windows.Forms.Label();
            this.dgvGarage = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGarage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEinde
            // 
            this.btnEinde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEinde.BackColor = System.Drawing.Color.LightCoral;
            this.btnEinde.Location = new System.Drawing.Point(491, 586);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(75, 23);
            this.btnEinde.TabIndex = 0;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = false;
            this.btnEinde.Click += new System.EventHandler(this.btnEinde_Click);
            // 
            // lblChassisnummer
            // 
            this.lblChassisnummer.AutoSize = true;
            this.lblChassisnummer.Location = new System.Drawing.Point(9, 13);
            this.lblChassisnummer.Name = "lblChassisnummer";
            this.lblChassisnummer.Size = new System.Drawing.Size(83, 13);
            this.lblChassisnummer.TabIndex = 1;
            this.lblChassisnummer.Text = "Chassisnummer:";
            // 
            // txbChassisnummer
            // 
            this.txbChassisnummer.Location = new System.Drawing.Point(13, 30);
            this.txbChassisnummer.Name = "txbChassisnummer";
            this.txbChassisnummer.Size = new System.Drawing.Size(142, 20);
            this.txbChassisnummer.TabIndex = 2;
            // 
            // lblKenteken
            // 
            this.lblKenteken.AutoSize = true;
            this.lblKenteken.Location = new System.Drawing.Point(158, 13);
            this.lblKenteken.Name = "lblKenteken";
            this.lblKenteken.Size = new System.Drawing.Size(56, 13);
            this.lblKenteken.TabIndex = 3;
            this.lblKenteken.Text = "Kenteken:";
            // 
            // txbKenteken
            // 
            this.txbKenteken.Location = new System.Drawing.Point(161, 29);
            this.txbKenteken.Name = "txbKenteken";
            this.txbKenteken.Size = new System.Drawing.Size(131, 20);
            this.txbKenteken.TabIndex = 4;
            // 
            // lblFabricageDatum
            // 
            this.lblFabricageDatum.AutoSize = true;
            this.lblFabricageDatum.Location = new System.Drawing.Point(295, 14);
            this.lblFabricageDatum.Name = "lblFabricageDatum";
            this.lblFabricageDatum.Size = new System.Drawing.Size(88, 13);
            this.lblFabricageDatum.TabIndex = 5;
            this.lblFabricageDatum.Text = "FabricageDatum:";
            // 
            // dtpFabricageDatum
            // 
            this.dtpFabricageDatum.Location = new System.Drawing.Point(298, 30);
            this.dtpFabricageDatum.Name = "dtpFabricageDatum";
            this.dtpFabricageDatum.Size = new System.Drawing.Size(203, 20);
            this.dtpFabricageDatum.TabIndex = 7;
            // 
            // lblDatumOpKenteken
            // 
            this.lblDatumOpKenteken.AutoSize = true;
            this.lblDatumOpKenteken.Location = new System.Drawing.Point(295, 57);
            this.lblDatumOpKenteken.Name = "lblDatumOpKenteken";
            this.lblDatumOpKenteken.Size = new System.Drawing.Size(101, 13);
            this.lblDatumOpKenteken.TabIndex = 8;
            this.lblDatumOpKenteken.Text = "DatumOpKenteken:";
            // 
            // dtpDatumOpKenteken
            // 
            this.dtpDatumOpKenteken.Location = new System.Drawing.Point(298, 73);
            this.dtpDatumOpKenteken.Name = "dtpDatumOpKenteken";
            this.dtpDatumOpKenteken.Size = new System.Drawing.Size(203, 20);
            this.dtpDatumOpKenteken.TabIndex = 9;
            // 
            // lblMerk
            // 
            this.lblMerk.AutoSize = true;
            this.lblMerk.Location = new System.Drawing.Point(9, 57);
            this.lblMerk.Name = "lblMerk";
            this.lblMerk.Size = new System.Drawing.Size(34, 13);
            this.lblMerk.TabIndex = 10;
            this.lblMerk.Text = "Merk:";
            // 
            // txbMerk
            // 
            this.txbMerk.Location = new System.Drawing.Point(12, 73);
            this.txbMerk.Name = "txbMerk";
            this.txbMerk.Size = new System.Drawing.Size(143, 20);
            this.txbMerk.TabIndex = 11;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(158, 57);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type:";
            // 
            // txbType
            // 
            this.txbType.Location = new System.Drawing.Point(161, 72);
            this.txbType.Name = "txbType";
            this.txbType.Size = new System.Drawing.Size(131, 20);
            this.txbType.TabIndex = 13;
            // 
            // lblKleur
            // 
            this.lblKleur.AutoSize = true;
            this.lblKleur.Location = new System.Drawing.Point(295, 96);
            this.lblKleur.Name = "lblKleur";
            this.lblKleur.Size = new System.Drawing.Size(34, 13);
            this.lblKleur.TabIndex = 14;
            this.lblKleur.Text = "Kleur:";
            // 
            // txbKleur
            // 
            this.txbKleur.Location = new System.Drawing.Point(298, 116);
            this.txbKleur.Name = "txbKleur";
            this.txbKleur.Size = new System.Drawing.Size(203, 20);
            this.txbKleur.TabIndex = 15;
            this.txbKleur.Click += new System.EventHandler(this.txbKleur_Click);
            // 
            // lblBrandstof
            // 
            this.lblBrandstof.AutoSize = true;
            this.lblBrandstof.Location = new System.Drawing.Point(158, 100);
            this.lblBrandstof.Name = "lblBrandstof";
            this.lblBrandstof.Size = new System.Drawing.Size(55, 13);
            this.lblBrandstof.TabIndex = 16;
            this.lblBrandstof.Text = "Brandstof:";
            // 
            // txbBrandstof
            // 
            this.txbBrandstof.Location = new System.Drawing.Point(161, 116);
            this.txbBrandstof.Name = "txbBrandstof";
            this.txbBrandstof.Size = new System.Drawing.Size(131, 20);
            this.txbBrandstof.TabIndex = 17;
            // 
            // lblAantalKilowats
            // 
            this.lblAantalKilowats.AutoSize = true;
            this.lblAantalKilowats.Location = new System.Drawing.Point(9, 100);
            this.lblAantalKilowats.Name = "lblAantalKilowats";
            this.lblAantalKilowats.Size = new System.Drawing.Size(79, 13);
            this.lblAantalKilowats.TabIndex = 18;
            this.lblAantalKilowats.Text = "AantalKilowats:";
            // 
            // txbAantalKilowats
            // 
            this.txbAantalKilowats.Location = new System.Drawing.Point(12, 116);
            this.txbAantalKilowats.Name = "txbAantalKilowats";
            this.txbAantalKilowats.Size = new System.Drawing.Size(143, 20);
            this.txbAantalKilowats.TabIndex = 19;
            // 
            // lblAantalPortieren
            // 
            this.lblAantalPortieren.AutoSize = true;
            this.lblAantalPortieren.Location = new System.Drawing.Point(9, 144);
            this.lblAantalPortieren.Name = "lblAantalPortieren";
            this.lblAantalPortieren.Size = new System.Drawing.Size(82, 13);
            this.lblAantalPortieren.TabIndex = 20;
            this.lblAantalPortieren.Text = "AantalPortieren:";
            // 
            // txbAantalPortieren
            // 
            this.txbAantalPortieren.Location = new System.Drawing.Point(12, 161);
            this.txbAantalPortieren.Name = "txbAantalPortieren";
            this.txbAantalPortieren.Size = new System.Drawing.Size(143, 20);
            this.txbAantalPortieren.TabIndex = 21;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(158, 144);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 22;
            this.lblModel.Text = "Model:";
            // 
            // txbModel
            // 
            this.txbModel.Location = new System.Drawing.Point(161, 161);
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(131, 20);
            this.txbModel.TabIndex = 23;
            // 
            // lblTrekhaak
            // 
            this.lblTrekhaak.AutoSize = true;
            this.lblTrekhaak.Location = new System.Drawing.Point(295, 144);
            this.lblTrekhaak.Name = "lblTrekhaak";
            this.lblTrekhaak.Size = new System.Drawing.Size(56, 13);
            this.lblTrekhaak.TabIndex = 24;
            this.lblTrekhaak.Text = "Trekhaak:";
            // 
            // chbTrekhaak
            // 
            this.chbTrekhaak.AutoSize = true;
            this.chbTrekhaak.Location = new System.Drawing.Point(298, 164);
            this.chbTrekhaak.Name = "chbTrekhaak";
            this.chbTrekhaak.Size = new System.Drawing.Size(72, 17);
            this.chbTrekhaak.TabIndex = 25;
            this.chbTrekhaak.Text = "Trekhaak";
            this.chbTrekhaak.UseVisualStyleBackColor = true;
            // 
            // lblZoekMerk
            // 
            this.lblZoekMerk.AutoSize = true;
            this.lblZoekMerk.Location = new System.Drawing.Point(6, 22);
            this.lblZoekMerk.Name = "lblZoekMerk";
            this.lblZoekMerk.Size = new System.Drawing.Size(34, 13);
            this.lblZoekMerk.TabIndex = 27;
            this.lblZoekMerk.Text = "Merk:";
            // 
            // cmbMerk
            // 
            this.cmbMerk.FormattingEnabled = true;
            this.cmbMerk.Location = new System.Drawing.Point(46, 19);
            this.cmbMerk.Name = "cmbMerk";
            this.cmbMerk.Size = new System.Drawing.Size(134, 21);
            this.cmbMerk.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbChassisnummer);
            this.groupBox1.Controls.Add(this.lblZoekChassisnummer);
            this.groupBox1.Controls.Add(this.cmbKenteken);
            this.groupBox1.Controls.Add(this.lblZoekKenteken);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.lblZoekType);
            this.groupBox1.Controls.Add(this.cmbModel);
            this.groupBox1.Controls.Add(this.lblZoekModel);
            this.groupBox1.Controls.Add(this.cmbMerk);
            this.groupBox1.Controls.Add(this.lblZoekMerk);
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 88);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zoeken";
            // 
            // cmbChassisnummer
            // 
            this.cmbChassisnummer.FormattingEnabled = true;
            this.cmbChassisnummer.Location = new System.Drawing.Point(370, 61);
            this.cmbChassisnummer.Name = "cmbChassisnummer";
            this.cmbChassisnummer.Size = new System.Drawing.Size(184, 21);
            this.cmbChassisnummer.TabIndex = 36;
            // 
            // lblZoekChassisnummer
            // 
            this.lblZoekChassisnummer.AutoSize = true;
            this.lblZoekChassisnummer.Location = new System.Drawing.Point(281, 64);
            this.lblZoekChassisnummer.Name = "lblZoekChassisnummer";
            this.lblZoekChassisnummer.Size = new System.Drawing.Size(83, 13);
            this.lblZoekChassisnummer.TabIndex = 35;
            this.lblZoekChassisnummer.Text = "Chassisnummer:";
            // 
            // cmbKenteken
            // 
            this.cmbKenteken.FormattingEnabled = true;
            this.cmbKenteken.Location = new System.Drawing.Point(68, 61);
            this.cmbKenteken.Name = "cmbKenteken";
            this.cmbKenteken.Size = new System.Drawing.Size(212, 21);
            this.cmbKenteken.TabIndex = 34;
            // 
            // lblZoekKenteken
            // 
            this.lblZoekKenteken.AutoSize = true;
            this.lblZoekKenteken.Location = new System.Drawing.Point(6, 64);
            this.lblZoekKenteken.Name = "lblZoekKenteken";
            this.lblZoekKenteken.Size = new System.Drawing.Size(56, 13);
            this.lblZoekKenteken.TabIndex = 33;
            this.lblZoekKenteken.Text = "Kenteken:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(431, 19);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(123, 21);
            this.cmbType.TabIndex = 32;
            // 
            // lblZoekType
            // 
            this.lblZoekType.AutoSize = true;
            this.lblZoekType.Location = new System.Drawing.Point(394, 22);
            this.lblZoekType.Name = "lblZoekType";
            this.lblZoekType.Size = new System.Drawing.Size(31, 13);
            this.lblZoekType.TabIndex = 31;
            this.lblZoekType.Text = "Type";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(233, 19);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(151, 21);
            this.cmbModel.TabIndex = 30;
            // 
            // lblZoekModel
            // 
            this.lblZoekModel.AutoSize = true;
            this.lblZoekModel.Location = new System.Drawing.Point(191, 22);
            this.lblZoekModel.Name = "lblZoekModel";
            this.lblZoekModel.Size = new System.Drawing.Size(36, 13);
            this.lblZoekModel.TabIndex = 29;
            this.lblZoekModel.Text = "Model";
            // 
            // dgvGarage
            // 
            this.dgvGarage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGarage.Location = new System.Drawing.Point(12, 291);
            this.dgvGarage.Name = "dgvGarage";
            this.dgvGarage.Size = new System.Drawing.Size(967, 289);
            this.dgvGarage.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 621);
            this.Controls.Add(this.dgvGarage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chbTrekhaak);
            this.Controls.Add(this.lblTrekhaak);
            this.Controls.Add(this.txbModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txbAantalPortieren);
            this.Controls.Add(this.lblAantalPortieren);
            this.Controls.Add(this.txbAantalKilowats);
            this.Controls.Add(this.lblAantalKilowats);
            this.Controls.Add(this.txbBrandstof);
            this.Controls.Add(this.lblBrandstof);
            this.Controls.Add(this.txbKleur);
            this.Controls.Add(this.lblKleur);
            this.Controls.Add(this.txbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txbMerk);
            this.Controls.Add(this.lblMerk);
            this.Controls.Add(this.dtpDatumOpKenteken);
            this.Controls.Add(this.lblDatumOpKenteken);
            this.Controls.Add(this.dtpFabricageDatum);
            this.Controls.Add(this.lblFabricageDatum);
            this.Controls.Add(this.txbKenteken);
            this.Controls.Add(this.lblKenteken);
            this.Controls.Add(this.txbChassisnummer);
            this.Controls.Add(this.lblChassisnummer);
            this.Controls.Add(this.btnEinde);
            this.Name = "Form1";
            this.Text = "frmGarage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGarage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.Label lblChassisnummer;
        private System.Windows.Forms.TextBox txbChassisnummer;
        private System.Windows.Forms.Label lblKenteken;
        private System.Windows.Forms.TextBox txbKenteken;
        private System.Windows.Forms.Label lblFabricageDatum;
        private System.Windows.Forms.DateTimePicker dtpFabricageDatum;
        private System.Windows.Forms.Label lblDatumOpKenteken;
        private System.Windows.Forms.DateTimePicker dtpDatumOpKenteken;
        private System.Windows.Forms.Label lblMerk;
        private System.Windows.Forms.TextBox txbMerk;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txbType;
        private System.Windows.Forms.Label lblKleur;
        private System.Windows.Forms.TextBox txbKleur;
        private System.Windows.Forms.Label lblBrandstof;
        private System.Windows.Forms.TextBox txbBrandstof;
        private System.Windows.Forms.Label lblAantalKilowats;
        private System.Windows.Forms.TextBox txbAantalKilowats;
        private System.Windows.Forms.Label lblAantalPortieren;
        private System.Windows.Forms.TextBox txbAantalPortieren;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.Label lblTrekhaak;
        private System.Windows.Forms.CheckBox chbTrekhaak;
        private System.Windows.Forms.ColorDialog KleurPicker;
        private System.Windows.Forms.Label lblZoekMerk;
        private System.Windows.Forms.ComboBox cmbMerk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label lblZoekModel;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblZoekType;
        private System.Windows.Forms.ComboBox cmbChassisnummer;
        private System.Windows.Forms.Label lblZoekChassisnummer;
        private System.Windows.Forms.ComboBox cmbKenteken;
        private System.Windows.Forms.Label lblZoekKenteken;
        private System.Windows.Forms.DataGridView dgvGarage;
    }
}

