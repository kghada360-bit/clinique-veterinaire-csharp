namespace CliniqueVeterinaire
{
    partial class SecretaireForm
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
            this.tabControlSecretaire = new System.Windows.Forms.TabControl();
            this.tabProprietaires = new System.Windows.Forms.TabPage();
            this.panelProp = new System.Windows.Forms.Panel();
            this.btnPropActualiser = new System.Windows.Forms.Button();
            this.btnPropSupprimer = new System.Windows.Forms.Button();
            this.btnPropModifier = new System.Windows.Forms.Button();
            this.btnPropAjouter = new System.Windows.Forms.Button();
            this.dgvProprietaires = new System.Windows.Forms.DataGridView();
            this.tabAnimaux = new System.Windows.Forms.TabPage();
            this.panelAnimaux = new System.Windows.Forms.Panel();
            this.btnAnimauxActualiser = new System.Windows.Forms.Button();
            this.btnAnimauxSupprimer = new System.Windows.Forms.Button();
            this.btnAnimauxModifier = new System.Windows.Forms.Button();
            this.btnAnimauxAjouter = new System.Windows.Forms.Button();
            this.dgvAnimaux = new System.Windows.Forms.DataGridView();
            this.tabRendezVous = new System.Windows.Forms.TabPage();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.cmbFiltreStatut = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFiltreAnimal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRendezVous = new System.Windows.Forms.Panel();
            this.btnRdvActualiser = new System.Windows.Forms.Button();
            this.btnRdvSupprimer = new System.Windows.Forms.Button();
            this.btnRdvModifier = new System.Windows.Forms.Button();
            this.btnRdvAjouter = new System.Windows.Forms.Button();
            this.dgvRendezVous = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelFactures = new System.Windows.Forms.Panel();
            this.btnExporterPDF = new System.Windows.Forms.Button();
            this.btnActualiserFactures = new System.Windows.Forms.Button();
            this.btnMarquerPaye = new System.Windows.Forms.Button();
            this.dgvFactures = new System.Windows.Forms.DataGridView();
            this.tabControlSecretaire.SuspendLayout();
            this.tabProprietaires.SuspendLayout();
            this.panelProp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietaires)).BeginInit();
            this.tabAnimaux.SuspendLayout();
            this.panelAnimaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaux)).BeginInit();
            this.tabRendezVous.SuspendLayout();
            this.panelRendezVous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendezVous)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panelFactures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactures)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSecretaire
            // 
            this.tabControlSecretaire.Controls.Add(this.tabProprietaires);
            this.tabControlSecretaire.Controls.Add(this.tabAnimaux);
            this.tabControlSecretaire.Controls.Add(this.tabRendezVous);
            this.tabControlSecretaire.Controls.Add(this.tabPage1);
            this.tabControlSecretaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSecretaire.Location = new System.Drawing.Point(0, 0);
            this.tabControlSecretaire.Name = "tabControlSecretaire";
            this.tabControlSecretaire.SelectedIndex = 0;
            this.tabControlSecretaire.Size = new System.Drawing.Size(982, 603);
            this.tabControlSecretaire.TabIndex = 0;
            // 
            // tabProprietaires
            // 
            this.tabProprietaires.Controls.Add(this.panelProp);
            this.tabProprietaires.Controls.Add(this.dgvProprietaires);
            this.tabProprietaires.Location = new System.Drawing.Point(4, 25);
            this.tabProprietaires.Name = "tabProprietaires";
            this.tabProprietaires.Padding = new System.Windows.Forms.Padding(3);
            this.tabProprietaires.Size = new System.Drawing.Size(974, 574);
            this.tabProprietaires.TabIndex = 0;
            this.tabProprietaires.Text = "👤 Propriétaires";
            this.tabProprietaires.UseVisualStyleBackColor = true;
            // 
            // panelProp
            // 
            this.panelProp.Controls.Add(this.btnPropActualiser);
            this.panelProp.Controls.Add(this.btnPropSupprimer);
            this.panelProp.Controls.Add(this.btnPropModifier);
            this.panelProp.Controls.Add(this.btnPropAjouter);
            this.panelProp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProp.Location = new System.Drawing.Point(3, 471);
            this.panelProp.Name = "panelProp";
            this.panelProp.Size = new System.Drawing.Size(968, 100);
            this.panelProp.TabIndex = 1;
            // 
            // btnPropActualiser
            // 
            this.btnPropActualiser.BackColor = System.Drawing.Color.LightGray;
            this.btnPropActualiser.Location = new System.Drawing.Point(668, 25);
            this.btnPropActualiser.Name = "btnPropActualiser";
            this.btnPropActualiser.Size = new System.Drawing.Size(140, 45);
            this.btnPropActualiser.TabIndex = 3;
            this.btnPropActualiser.Text = "Actualiser";
            this.btnPropActualiser.UseVisualStyleBackColor = false;
            this.btnPropActualiser.Click += new System.EventHandler(this.btnPropActualiser_Click);
            // 
            // btnPropSupprimer
            // 
            this.btnPropSupprimer.BackColor = System.Drawing.Color.LightCoral;
            this.btnPropSupprimer.Location = new System.Drawing.Point(466, 25);
            this.btnPropSupprimer.Name = "btnPropSupprimer";
            this.btnPropSupprimer.Size = new System.Drawing.Size(146, 45);
            this.btnPropSupprimer.TabIndex = 2;
            this.btnPropSupprimer.Text = "Supprimer";
            this.btnPropSupprimer.UseVisualStyleBackColor = false;
            this.btnPropSupprimer.Click += new System.EventHandler(this.btnPropSupprimer_Click);
            // 
            // btnPropModifier
            // 
            this.btnPropModifier.BackColor = System.Drawing.Color.LightBlue;
            this.btnPropModifier.Location = new System.Drawing.Point(260, 25);
            this.btnPropModifier.Name = "btnPropModifier";
            this.btnPropModifier.Size = new System.Drawing.Size(131, 45);
            this.btnPropModifier.TabIndex = 1;
            this.btnPropModifier.Text = "Modifier";
            this.btnPropModifier.UseVisualStyleBackColor = false;
            this.btnPropModifier.Click += new System.EventHandler(this.btnPropModifier_Click);
            // 
            // btnPropAjouter
            // 
            this.btnPropAjouter.BackColor = System.Drawing.Color.LightGreen;
            this.btnPropAjouter.Location = new System.Drawing.Point(58, 25);
            this.btnPropAjouter.Name = "btnPropAjouter";
            this.btnPropAjouter.Size = new System.Drawing.Size(147, 45);
            this.btnPropAjouter.TabIndex = 0;
            this.btnPropAjouter.Text = "Ajouter";
            this.btnPropAjouter.UseVisualStyleBackColor = false;
            this.btnPropAjouter.Click += new System.EventHandler(this.btnPropAjouter_Click);
            // 
            // dgvProprietaires
            // 
            this.dgvProprietaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProprietaires.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProprietaires.Location = new System.Drawing.Point(3, 3);
            this.dgvProprietaires.Name = "dgvProprietaires";
            this.dgvProprietaires.RowHeadersWidth = 51;
            this.dgvProprietaires.RowTemplate.Height = 24;
            this.dgvProprietaires.Size = new System.Drawing.Size(968, 568);
            this.dgvProprietaires.TabIndex = 0;
            // 
            // tabAnimaux
            // 
            this.tabAnimaux.Controls.Add(this.panelAnimaux);
            this.tabAnimaux.Controls.Add(this.dgvAnimaux);
            this.tabAnimaux.Location = new System.Drawing.Point(4, 25);
            this.tabAnimaux.Name = "tabAnimaux";
            this.tabAnimaux.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimaux.Size = new System.Drawing.Size(974, 574);
            this.tabAnimaux.TabIndex = 1;
            this.tabAnimaux.Text = "🐕 Animaux";
            this.tabAnimaux.UseVisualStyleBackColor = true;
            // 
            // panelAnimaux
            // 
            this.panelAnimaux.Controls.Add(this.btnAnimauxActualiser);
            this.panelAnimaux.Controls.Add(this.btnAnimauxSupprimer);
            this.panelAnimaux.Controls.Add(this.btnAnimauxModifier);
            this.panelAnimaux.Controls.Add(this.btnAnimauxAjouter);
            this.panelAnimaux.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAnimaux.Location = new System.Drawing.Point(3, 471);
            this.panelAnimaux.Name = "panelAnimaux";
            this.panelAnimaux.Size = new System.Drawing.Size(968, 100);
            this.panelAnimaux.TabIndex = 1;
            // 
            // btnAnimauxActualiser
            // 
            this.btnAnimauxActualiser.BackColor = System.Drawing.Color.LightGray;
            this.btnAnimauxActualiser.Location = new System.Drawing.Point(614, 32);
            this.btnAnimauxActualiser.Name = "btnAnimauxActualiser";
            this.btnAnimauxActualiser.Size = new System.Drawing.Size(132, 43);
            this.btnAnimauxActualiser.TabIndex = 3;
            this.btnAnimauxActualiser.Text = "Actualiser";
            this.btnAnimauxActualiser.UseVisualStyleBackColor = false;
            this.btnAnimauxActualiser.Click += new System.EventHandler(this.btnAnimauxActualiser_Click);
            // 
            // btnAnimauxSupprimer
            // 
            this.btnAnimauxSupprimer.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnimauxSupprimer.Location = new System.Drawing.Point(429, 32);
            this.btnAnimauxSupprimer.Name = "btnAnimauxSupprimer";
            this.btnAnimauxSupprimer.Size = new System.Drawing.Size(132, 43);
            this.btnAnimauxSupprimer.TabIndex = 2;
            this.btnAnimauxSupprimer.Text = "Supprimer";
            this.btnAnimauxSupprimer.UseVisualStyleBackColor = false;
            this.btnAnimauxSupprimer.Click += new System.EventHandler(this.btnAnimauxSupprimer_Click);
            // 
            // btnAnimauxModifier
            // 
            this.btnAnimauxModifier.BackColor = System.Drawing.Color.LightBlue;
            this.btnAnimauxModifier.Location = new System.Drawing.Point(240, 32);
            this.btnAnimauxModifier.Name = "btnAnimauxModifier";
            this.btnAnimauxModifier.Size = new System.Drawing.Size(132, 43);
            this.btnAnimauxModifier.TabIndex = 1;
            this.btnAnimauxModifier.Text = "Modifier";
            this.btnAnimauxModifier.UseVisualStyleBackColor = false;
            this.btnAnimauxModifier.Click += new System.EventHandler(this.btnAnimauxModifier_Click);
            // 
            // btnAnimauxAjouter
            // 
            this.btnAnimauxAjouter.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnimauxAjouter.Location = new System.Drawing.Point(53, 32);
            this.btnAnimauxAjouter.Name = "btnAnimauxAjouter";
            this.btnAnimauxAjouter.Size = new System.Drawing.Size(132, 43);
            this.btnAnimauxAjouter.TabIndex = 0;
            this.btnAnimauxAjouter.Text = "Ajouter";
            this.btnAnimauxAjouter.UseVisualStyleBackColor = false;
            this.btnAnimauxAjouter.Click += new System.EventHandler(this.btnAnimauxAjouter_Click);
            // 
            // dgvAnimaux
            // 
            this.dgvAnimaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimaux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnimaux.Location = new System.Drawing.Point(3, 3);
            this.dgvAnimaux.Name = "dgvAnimaux";
            this.dgvAnimaux.RowHeadersWidth = 51;
            this.dgvAnimaux.RowTemplate.Height = 24;
            this.dgvAnimaux.Size = new System.Drawing.Size(968, 568);
            this.dgvAnimaux.TabIndex = 0;
            // 
            // tabRendezVous
            // 
            this.tabRendezVous.Controls.Add(this.btnReinitialiser);
            this.tabRendezVous.Controls.Add(this.btnRechercher);
            this.tabRendezVous.Controls.Add(this.cmbFiltreStatut);
            this.tabRendezVous.Controls.Add(this.label5);
            this.tabRendezVous.Controls.Add(this.cmbFiltreAnimal);
            this.tabRendezVous.Controls.Add(this.label4);
            this.tabRendezVous.Controls.Add(this.dtpDateFin);
            this.tabRendezVous.Controls.Add(this.dtpDateDebut);
            this.tabRendezVous.Controls.Add(this.label3);
            this.tabRendezVous.Controls.Add(this.label2);
            this.tabRendezVous.Controls.Add(this.label1);
            this.tabRendezVous.Controls.Add(this.panelRendezVous);
            this.tabRendezVous.Controls.Add(this.dgvRendezVous);
            this.tabRendezVous.Location = new System.Drawing.Point(4, 25);
            this.tabRendezVous.Name = "tabRendezVous";
            this.tabRendezVous.Padding = new System.Windows.Forms.Padding(3);
            this.tabRendezVous.Size = new System.Drawing.Size(974, 574);
            this.tabRendezVous.TabIndex = 2;
            this.tabRendezVous.Text = "📅 Rendez-vous";
            this.tabRendezVous.UseVisualStyleBackColor = true;
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BackColor = System.Drawing.Color.LightGray;
            this.btnReinitialiser.Location = new System.Drawing.Point(827, 386);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(100, 30);
            this.btnReinitialiser.TabIndex = 12;
            this.btnReinitialiser.Text = "🔄 Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.LightBlue;
            this.btnRechercher.Location = new System.Drawing.Point(760, 385);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(50, 30);
            this.btnRechercher.TabIndex = 11;
            this.btnRechercher.Text = "🔍 \r\n";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // cmbFiltreStatut
            // 
            this.cmbFiltreStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltreStatut.FormattingEnabled = true;
            this.cmbFiltreStatut.Location = new System.Drawing.Point(623, 390);
            this.cmbFiltreStatut.Name = "cmbFiltreStatut";
            this.cmbFiltreStatut.Size = new System.Drawing.Size(131, 24);
            this.cmbFiltreStatut.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Statut :";
            // 
            // cmbFiltreAnimal
            // 
            this.cmbFiltreAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltreAnimal.FormattingEnabled = true;
            this.cmbFiltreAnimal.Location = new System.Drawing.Point(396, 389);
            this.cmbFiltreAnimal.Name = "cmbFiltreAnimal";
            this.cmbFiltreAnimal.Size = new System.Drawing.Size(164, 24);
            this.cmbFiltreAnimal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Animal :";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Location = new System.Drawing.Point(210, 391);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(120, 22);
            this.dtpDateFin.TabIndex = 6;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Location = new System.Drawing.Point(42, 391);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(120, 22);
            this.dtpDateDebut.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Au:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Du :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "🔍 Rechercher :";
            // 
            // panelRendezVous
            // 
            this.panelRendezVous.Controls.Add(this.btnRdvActualiser);
            this.panelRendezVous.Controls.Add(this.btnRdvSupprimer);
            this.panelRendezVous.Controls.Add(this.btnRdvModifier);
            this.panelRendezVous.Controls.Add(this.btnRdvAjouter);
            this.panelRendezVous.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRendezVous.Location = new System.Drawing.Point(3, 471);
            this.panelRendezVous.Name = "panelRendezVous";
            this.panelRendezVous.Size = new System.Drawing.Size(968, 100);
            this.panelRendezVous.TabIndex = 1;
            // 
            // btnRdvActualiser
            // 
            this.btnRdvActualiser.BackColor = System.Drawing.Color.LightGray;
            this.btnRdvActualiser.Location = new System.Drawing.Point(566, 27);
            this.btnRdvActualiser.Name = "btnRdvActualiser";
            this.btnRdvActualiser.Size = new System.Drawing.Size(132, 47);
            this.btnRdvActualiser.TabIndex = 3;
            this.btnRdvActualiser.Text = "Actualiser";
            this.btnRdvActualiser.UseVisualStyleBackColor = false;
            this.btnRdvActualiser.Click += new System.EventHandler(this.btnRdvActualiser_Click);
            // 
            // btnRdvSupprimer
            // 
            this.btnRdvSupprimer.BackColor = System.Drawing.Color.LightCoral;
            this.btnRdvSupprimer.Location = new System.Drawing.Point(393, 27);
            this.btnRdvSupprimer.Name = "btnRdvSupprimer";
            this.btnRdvSupprimer.Size = new System.Drawing.Size(132, 47);
            this.btnRdvSupprimer.TabIndex = 2;
            this.btnRdvSupprimer.Text = "Supprimer";
            this.btnRdvSupprimer.UseVisualStyleBackColor = false;
            this.btnRdvSupprimer.Click += new System.EventHandler(this.btnRdvSupprimer_Click);
            // 
            // btnRdvModifier
            // 
            this.btnRdvModifier.BackColor = System.Drawing.Color.LightBlue;
            this.btnRdvModifier.Location = new System.Drawing.Point(221, 27);
            this.btnRdvModifier.Name = "btnRdvModifier";
            this.btnRdvModifier.Size = new System.Drawing.Size(132, 47);
            this.btnRdvModifier.TabIndex = 1;
            this.btnRdvModifier.Text = "Modifier";
            this.btnRdvModifier.UseVisualStyleBackColor = false;
            this.btnRdvModifier.Click += new System.EventHandler(this.btnRdvModifier_Click);
            // 
            // btnRdvAjouter
            // 
            this.btnRdvAjouter.BackColor = System.Drawing.Color.LightGreen;
            this.btnRdvAjouter.Location = new System.Drawing.Point(35, 27);
            this.btnRdvAjouter.Name = "btnRdvAjouter";
            this.btnRdvAjouter.Size = new System.Drawing.Size(132, 47);
            this.btnRdvAjouter.TabIndex = 0;
            this.btnRdvAjouter.Text = "Ajouter";
            this.btnRdvAjouter.UseVisualStyleBackColor = false;
            this.btnRdvAjouter.Click += new System.EventHandler(this.btnRdvAjouter_Click);
            // 
            // dgvRendezVous
            // 
            this.dgvRendezVous.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRendezVous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRendezVous.Location = new System.Drawing.Point(3, 3);
            this.dgvRendezVous.Name = "dgvRendezVous";
            this.dgvRendezVous.RowHeadersWidth = 51;
            this.dgvRendezVous.RowTemplate.Height = 24;
            this.dgvRendezVous.Size = new System.Drawing.Size(968, 568);
            this.dgvRendezVous.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelFactures);
            this.tabPage1.Controls.Add(this.dgvFactures);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 574);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "💰 Factures";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelFactures
            // 
            this.panelFactures.Controls.Add(this.btnExporterPDF);
            this.panelFactures.Controls.Add(this.btnActualiserFactures);
            this.panelFactures.Controls.Add(this.btnMarquerPaye);
            this.panelFactures.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFactures.Location = new System.Drawing.Point(3, 471);
            this.panelFactures.Name = "panelFactures";
            this.panelFactures.Size = new System.Drawing.Size(968, 100);
            this.panelFactures.TabIndex = 2;
            // 
            // btnExporterPDF
            // 
            this.btnExporterPDF.BackColor = System.Drawing.Color.LightBlue;
            this.btnExporterPDF.Location = new System.Drawing.Point(349, 29);
            this.btnExporterPDF.Name = "btnExporterPDF";
            this.btnExporterPDF.Size = new System.Drawing.Size(159, 50);
            this.btnExporterPDF.TabIndex = 3;
            this.btnExporterPDF.Text = "📄 Exporter PDF";
            this.btnExporterPDF.UseVisualStyleBackColor = false;
            this.btnExporterPDF.Click += new System.EventHandler(this.btnExporterPDF_Click);
            // 
            // btnActualiserFactures
            // 
            this.btnActualiserFactures.BackColor = System.Drawing.Color.LightGray;
            this.btnActualiserFactures.Location = new System.Drawing.Point(637, 29);
            this.btnActualiserFactures.Name = "btnActualiserFactures";
            this.btnActualiserFactures.Size = new System.Drawing.Size(159, 50);
            this.btnActualiserFactures.TabIndex = 2;
            this.btnActualiserFactures.Text = "🔄 Actualiser";
            this.btnActualiserFactures.UseVisualStyleBackColor = false;
            // 
            // btnMarquerPaye
            // 
            this.btnMarquerPaye.BackColor = System.Drawing.Color.LightGreen;
            this.btnMarquerPaye.Location = new System.Drawing.Point(90, 29);
            this.btnMarquerPaye.Name = "btnMarquerPaye";
            this.btnMarquerPaye.Size = new System.Drawing.Size(159, 50);
            this.btnMarquerPaye.TabIndex = 1;
            this.btnMarquerPaye.Text = "✅ Marquer comme payé";
            this.btnMarquerPaye.UseVisualStyleBackColor = false;
            this.btnMarquerPaye.Click += new System.EventHandler(this.btnMarquerPaye_Click);
            // 
            // dgvFactures
            // 
            this.dgvFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactures.Location = new System.Drawing.Point(3, 3);
            this.dgvFactures.Name = "dgvFactures";
            this.dgvFactures.RowHeadersWidth = 51;
            this.dgvFactures.RowTemplate.Height = 24;
            this.dgvFactures.Size = new System.Drawing.Size(968, 568);
            this.dgvFactures.TabIndex = 0;
            // 
            // SecretaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.tabControlSecretaire);
            this.Name = "SecretaireForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secrétaire - Clinique Vétérinaire";
            this.tabControlSecretaire.ResumeLayout(false);
            this.tabProprietaires.ResumeLayout(false);
            this.panelProp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietaires)).EndInit();
            this.tabAnimaux.ResumeLayout(false);
            this.panelAnimaux.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaux)).EndInit();
            this.tabRendezVous.ResumeLayout(false);
            this.tabRendezVous.PerformLayout();
            this.panelRendezVous.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendezVous)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panelFactures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSecretaire;
        private System.Windows.Forms.TabPage tabProprietaires;
        private System.Windows.Forms.TabPage tabAnimaux;
        private System.Windows.Forms.TabPage tabRendezVous;
        private System.Windows.Forms.DataGridView dgvProprietaires;
        private System.Windows.Forms.Panel panelProp;
        private System.Windows.Forms.Button btnPropActualiser;
        private System.Windows.Forms.Button btnPropSupprimer;
        private System.Windows.Forms.Button btnPropModifier;
        private System.Windows.Forms.Button btnPropAjouter;
        private System.Windows.Forms.Panel panelAnimaux;
        private System.Windows.Forms.Button btnAnimauxActualiser;
        private System.Windows.Forms.Button btnAnimauxSupprimer;
        private System.Windows.Forms.Button btnAnimauxModifier;
        private System.Windows.Forms.Button btnAnimauxAjouter;
        private System.Windows.Forms.DataGridView dgvAnimaux;
        private System.Windows.Forms.Panel panelRendezVous;
        private System.Windows.Forms.Button btnRdvActualiser;
        private System.Windows.Forms.Button btnRdvSupprimer;
        private System.Windows.Forms.Button btnRdvModifier;
        private System.Windows.Forms.Button btnRdvAjouter;
        private System.Windows.Forms.DataGridView dgvRendezVous;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnMarquerPaye;
        private System.Windows.Forms.DataGridView dgvFactures;
        private System.Windows.Forms.Panel panelFactures;
        private System.Windows.Forms.Button btnActualiserFactures;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.ComboBox cmbFiltreStatut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFiltreAnimal;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnExporterPDF;
    }
}