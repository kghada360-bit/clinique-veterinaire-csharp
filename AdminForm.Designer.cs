namespace CliniqueVeterinaire
{
    partial class AdminForm
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
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableauDeBordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUtilisateurs = new System.Windows.Forms.TabPage();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvUtilisateurs = new System.Windows.Forms.DataGridView();
            this.tabMedicaments = new System.Windows.Forms.TabPage();
            this.panelMedicaments = new System.Windows.Forms.Panel();
            this.btnMedocActualiser = new System.Windows.Forms.Button();
            this.btnMedocSupprimer = new System.Windows.Forms.Button();
            this.btnMedocModifier = new System.Windows.Forms.Button();
            this.btnMedocAjouter = new System.Windows.Forms.Button();
            this.dgvMedicaments = new System.Windows.Forms.DataGridView();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dtpRevenusDebut = new System.Windows.Forms.DateTimePicker();
            this.groupRevenus = new System.Windows.Forms.GroupBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.btnRafraichirStats = new System.Windows.Forms.Button();
            this.dgvAlertes = new System.Windows.Forms.DataGridView();
            this.groupAlertes = new System.Windows.Forms.GroupBox();
            this.groupStats = new System.Windows.Forms.GroupBox();
            this.lblStockTotal = new System.Windows.Forms.Label();
            this.lblNbMedicaments = new System.Windows.Forms.Label();
            this.lblNbUtilisateurs = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.dtpRevenusFin = new System.Windows.Forms.DateTimePicker();
            this.btnCalculerRevenus = new System.Windows.Forms.Button();
            this.lblRevenusTotal = new System.Windows.Forms.Label();
            this.btnMoisEnCours = new System.Windows.Forms.Button();
            this.lblChiffreAffaires = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabUtilisateurs.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).BeginInit();
            this.tabMedicaments.SuspendLayout();
            this.panelMedicaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).BeginInit();
            this.tabDashboard.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.groupRevenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).BeginInit();
            this.groupStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.qToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateursToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicamentsToolStripMenuItem});
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.utilisateursToolStripMenuItem.Text = "Utilisateurs";
            this.utilisateursToolStripMenuItem.Click += new System.EventHandler(this.utilisateursToolStripMenuItem_Click);
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            this.médicamentsToolStripMenuItem.Click += new System.EventHandler(this.médicamentsToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableauDeBordToolStripMenuItem});
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // tableauDeBordToolStripMenuItem
            // 
            this.tableauDeBordToolStripMenuItem.Name = "tableauDeBordToolStripMenuItem";
            this.tableauDeBordToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.tableauDeBordToolStripMenuItem.Text = "Tableau de bord";
            this.tableauDeBordToolStripMenuItem.Click += new System.EventHandler(this.tableauDeBordToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUtilisateurs);
            this.tabControl1.Controls.Add(this.tabMedicaments);
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 575);
            this.tabControl1.TabIndex = 1;
            // 
            // tabUtilisateurs
            // 
            this.tabUtilisateurs.Controls.Add(this.panelButtons);
            this.tabUtilisateurs.Controls.Add(this.dgvUtilisateurs);
            this.tabUtilisateurs.Location = new System.Drawing.Point(4, 25);
            this.tabUtilisateurs.Name = "tabUtilisateurs";
            this.tabUtilisateurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabUtilisateurs.Size = new System.Drawing.Size(974, 546);
            this.tabUtilisateurs.TabIndex = 0;
            this.tabUtilisateurs.Text = "👥 Utilisateurs";
            this.tabUtilisateurs.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnSupprimer);
            this.panelButtons.Controls.Add(this.btnActualiser);
            this.panelButtons.Controls.Add(this.btnModifier);
            this.panelButtons.Controls.Add(this.btnAjouter);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(3, 443);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(968, 100);
            this.panelButtons.TabIndex = 1;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(327, 39);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 42);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "❌ Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(485, 39);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(117, 42);
            this.btnActualiser.TabIndex = 2;
            this.btnActualiser.Text = "🔄 Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(181, 39);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(117, 42);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "✏️ Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(44, 39);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(114, 42);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "➕ Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvUtilisateurs
            // 
            this.dgvUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilisateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUtilisateurs.Location = new System.Drawing.Point(3, 3);
            this.dgvUtilisateurs.Name = "dgvUtilisateurs";
            this.dgvUtilisateurs.RowHeadersWidth = 51;
            this.dgvUtilisateurs.RowTemplate.Height = 24;
            this.dgvUtilisateurs.Size = new System.Drawing.Size(968, 540);
            this.dgvUtilisateurs.TabIndex = 0;
            // 
            // tabMedicaments
            // 
            this.tabMedicaments.Controls.Add(this.panelMedicaments);
            this.tabMedicaments.Controls.Add(this.dgvMedicaments);
            this.tabMedicaments.Location = new System.Drawing.Point(4, 25);
            this.tabMedicaments.Name = "tabMedicaments";
            this.tabMedicaments.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedicaments.Size = new System.Drawing.Size(974, 546);
            this.tabMedicaments.TabIndex = 1;
            this.tabMedicaments.Text = "💊 Médicaments";
            this.tabMedicaments.UseVisualStyleBackColor = true;
            // 
            // panelMedicaments
            // 
            this.panelMedicaments.Controls.Add(this.btnMedocActualiser);
            this.panelMedicaments.Controls.Add(this.btnMedocSupprimer);
            this.panelMedicaments.Controls.Add(this.btnMedocModifier);
            this.panelMedicaments.Controls.Add(this.btnMedocAjouter);
            this.panelMedicaments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMedicaments.Location = new System.Drawing.Point(3, 443);
            this.panelMedicaments.Name = "panelMedicaments";
            this.panelMedicaments.Size = new System.Drawing.Size(968, 100);
            this.panelMedicaments.TabIndex = 1;
            // 
            // btnMedocActualiser
            // 
            this.btnMedocActualiser.BackColor = System.Drawing.Color.LightGray;
            this.btnMedocActualiser.Location = new System.Drawing.Point(575, 28);
            this.btnMedocActualiser.Name = "btnMedocActualiser";
            this.btnMedocActualiser.Size = new System.Drawing.Size(147, 50);
            this.btnMedocActualiser.TabIndex = 3;
            this.btnMedocActualiser.Text = "Actualiser";
            this.btnMedocActualiser.UseVisualStyleBackColor = false;
            this.btnMedocActualiser.Click += new System.EventHandler(this.btnMedocActualiser_Click);
            // 
            // btnMedocSupprimer
            // 
            this.btnMedocSupprimer.BackColor = System.Drawing.Color.LightCoral;
            this.btnMedocSupprimer.Location = new System.Drawing.Point(408, 28);
            this.btnMedocSupprimer.Name = "btnMedocSupprimer";
            this.btnMedocSupprimer.Size = new System.Drawing.Size(139, 50);
            this.btnMedocSupprimer.TabIndex = 2;
            this.btnMedocSupprimer.Text = "Supprimer";
            this.btnMedocSupprimer.UseVisualStyleBackColor = false;
            this.btnMedocSupprimer.Click += new System.EventHandler(this.btnMedocSupprimer_Click);
            // 
            // btnMedocModifier
            // 
            this.btnMedocModifier.BackColor = System.Drawing.Color.LightBlue;
            this.btnMedocModifier.Location = new System.Drawing.Point(233, 28);
            this.btnMedocModifier.Name = "btnMedocModifier";
            this.btnMedocModifier.Size = new System.Drawing.Size(142, 50);
            this.btnMedocModifier.TabIndex = 1;
            this.btnMedocModifier.Text = "Modifier";
            this.btnMedocModifier.UseVisualStyleBackColor = false;
            this.btnMedocModifier.Click += new System.EventHandler(this.btnMedocModifier_Click);
            // 
            // btnMedocAjouter
            // 
            this.btnMedocAjouter.BackColor = System.Drawing.Color.LightGreen;
            this.btnMedocAjouter.Location = new System.Drawing.Point(53, 28);
            this.btnMedocAjouter.Name = "btnMedocAjouter";
            this.btnMedocAjouter.Size = new System.Drawing.Size(139, 50);
            this.btnMedocAjouter.TabIndex = 0;
            this.btnMedocAjouter.Text = "Ajouter";
            this.btnMedocAjouter.UseVisualStyleBackColor = false;
            this.btnMedocAjouter.Click += new System.EventHandler(this.btnMedocAjouter_Click);
            // 
            // dgvMedicaments
            // 
            this.dgvMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicaments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicaments.Location = new System.Drawing.Point(3, 3);
            this.dgvMedicaments.Name = "dgvMedicaments";
            this.dgvMedicaments.RowHeadersWidth = 51;
            this.dgvMedicaments.RowTemplate.Height = 24;
            this.dgvMedicaments.Size = new System.Drawing.Size(968, 540);
            this.dgvMedicaments.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.panelDashboard);
            this.tabDashboard.Location = new System.Drawing.Point(4, 25);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(974, 546);
            this.tabDashboard.TabIndex = 2;
            this.tabDashboard.Text = "📊 Tableau de bord";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDashboard.Controls.Add(this.groupRevenus);
            this.panelDashboard.Controls.Add(this.btnRafraichirStats);
            this.panelDashboard.Controls.Add(this.dgvAlertes);
            this.panelDashboard.Controls.Add(this.groupAlertes);
            this.panelDashboard.Controls.Add(this.groupStats);
            this.panelDashboard.Controls.Add(this.lblTitre);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(3, 3);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(968, 540);
            this.panelDashboard.TabIndex = 0;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(13, 69);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(29, 16);
            this.lblDateFin.TabIndex = 6;
            this.lblDateFin.Text = "Au :";
            // 
            // dtpRevenusDebut
            // 
            this.dtpRevenusDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRevenusDebut.Location = new System.Drawing.Point(48, 29);
            this.dtpRevenusDebut.Name = "dtpRevenusDebut";
            this.dtpRevenusDebut.Size = new System.Drawing.Size(120, 22);
            this.dtpRevenusDebut.TabIndex = 1;
            // 
            // groupRevenus
            // 
            this.groupRevenus.Controls.Add(this.btnMoisEnCours);
            this.groupRevenus.Controls.Add(this.lblRevenusTotal);
            this.groupRevenus.Controls.Add(this.btnCalculerRevenus);
            this.groupRevenus.Controls.Add(this.lblDateDebut);
            this.groupRevenus.Controls.Add(this.dtpRevenusFin);
            this.groupRevenus.Controls.Add(this.dtpRevenusDebut);
            this.groupRevenus.Controls.Add(this.lblDateFin);
            this.groupRevenus.Location = new System.Drawing.Point(255, 265);
            this.groupRevenus.Name = "groupRevenus";
            this.groupRevenus.Size = new System.Drawing.Size(400, 150);
            this.groupRevenus.TabIndex = 5;
            this.groupRevenus.TabStop = false;
            this.groupRevenus.Text = "💰 Revenus sur période";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(12, 35);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(30, 16);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "Du :";
            // 
            // btnRafraichirStats
            // 
            this.btnRafraichirStats.Location = new System.Drawing.Point(20, 265);
            this.btnRafraichirStats.Name = "btnRafraichirStats";
            this.btnRafraichirStats.Size = new System.Drawing.Size(120, 35);
            this.btnRafraichirStats.TabIndex = 4;
            this.btnRafraichirStats.Text = "🔄 Rafraîchir";
            this.btnRafraichirStats.UseVisualStyleBackColor = true;
            this.btnRafraichirStats.Click += new System.EventHandler(this.btnRafraichirStats_Click);
            // 
            // dgvAlertes
            // 
            this.dgvAlertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlertes.Location = new System.Drawing.Point(460, 90);
            this.dgvAlertes.Name = "dgvAlertes";
            this.dgvAlertes.RowHeadersWidth = 51;
            this.dgvAlertes.RowTemplate.Height = 24;
            this.dgvAlertes.Size = new System.Drawing.Size(380, 148);
            this.dgvAlertes.TabIndex = 3;
            // 
            // groupAlertes
            // 
            this.groupAlertes.Location = new System.Drawing.Point(450, 60);
            this.groupAlertes.Name = "groupAlertes";
            this.groupAlertes.Size = new System.Drawing.Size(400, 199);
            this.groupAlertes.TabIndex = 2;
            this.groupAlertes.TabStop = false;
            this.groupAlertes.Text = "Alertes";
            // 
            // groupStats
            // 
            this.groupStats.Controls.Add(this.lblChiffreAffaires);
            this.groupStats.Controls.Add(this.lblStockTotal);
            this.groupStats.Controls.Add(this.lblNbMedicaments);
            this.groupStats.Controls.Add(this.lblNbUtilisateurs);
            this.groupStats.Location = new System.Drawing.Point(20, 60);
            this.groupStats.Name = "groupStats";
            this.groupStats.Size = new System.Drawing.Size(400, 199);
            this.groupStats.TabIndex = 1;
            this.groupStats.TabStop = false;
            this.groupStats.Text = "\tStatistiques générales";
            // 
            // lblStockTotal
            // 
            this.lblStockTotal.AutoSize = true;
            this.lblStockTotal.Location = new System.Drawing.Point(30, 104);
            this.lblStockTotal.Name = "lblStockTotal";
            this.lblStockTotal.Size = new System.Drawing.Size(85, 16);
            this.lblStockTotal.TabIndex = 2;
            this.lblStockTotal.Text = "Stock total : 0";
            // 
            // lblNbMedicaments
            // 
            this.lblNbMedicaments.AutoSize = true;
            this.lblNbMedicaments.Location = new System.Drawing.Point(30, 74);
            this.lblNbMedicaments.Name = "lblNbMedicaments";
            this.lblNbMedicaments.Size = new System.Drawing.Size(175, 16);
            this.lblNbMedicaments.TabIndex = 1;
            this.lblNbMedicaments.Text = "Nombre de médicaments : 0";
            // 
            // lblNbUtilisateurs
            // 
            this.lblNbUtilisateurs.AutoSize = true;
            this.lblNbUtilisateurs.Location = new System.Drawing.Point(30, 41);
            this.lblNbUtilisateurs.Name = "lblNbUtilisateurs";
            this.lblNbUtilisateurs.Size = new System.Drawing.Size(149, 16);
            this.lblNbUtilisateurs.TabIndex = 0;
            this.lblNbUtilisateurs.Text = "Nombre d\'utilisateurs : 0";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(20, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(236, 32);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Tableau de bord";
            // 
            // dtpRevenusFin
            // 
            this.dtpRevenusFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRevenusFin.Location = new System.Drawing.Point(48, 63);
            this.dtpRevenusFin.Name = "dtpRevenusFin";
            this.dtpRevenusFin.Size = new System.Drawing.Size(120, 22);
            this.dtpRevenusFin.TabIndex = 7;
            // 
            // btnCalculerRevenus
            // 
            this.btnCalculerRevenus.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalculerRevenus.Location = new System.Drawing.Point(225, 29);
            this.btnCalculerRevenus.Name = "btnCalculerRevenus";
            this.btnCalculerRevenus.Size = new System.Drawing.Size(120, 35);
            this.btnCalculerRevenus.TabIndex = 8;
            this.btnCalculerRevenus.Text = "💰 Calculer";
            this.btnCalculerRevenus.UseVisualStyleBackColor = false;
            this.btnCalculerRevenus.Click += new System.EventHandler(this.btnCalculerRevenus_Click);
            // 
            // lblRevenusTotal
            // 
            this.lblRevenusTotal.AutoSize = true;
            this.lblRevenusTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenusTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRevenusTotal.Location = new System.Drawing.Point(13, 108);
            this.lblRevenusTotal.Name = "lblRevenusTotal";
            this.lblRevenusTotal.Size = new System.Drawing.Size(119, 16);
            this.lblRevenusTotal.TabIndex = 9;
            this.lblRevenusTotal.Text = "Total : 0.00 TND";
            // 
            // btnMoisEnCours
            // 
            this.btnMoisEnCours.BackColor = System.Drawing.Color.LightBlue;
            this.btnMoisEnCours.Location = new System.Drawing.Point(225, 89);
            this.btnMoisEnCours.Name = "btnMoisEnCours";
            this.btnMoisEnCours.Size = new System.Drawing.Size(120, 35);
            this.btnMoisEnCours.TabIndex = 10;
            this.btnMoisEnCours.Text = "📅 Mois en cours";
            this.btnMoisEnCours.UseVisualStyleBackColor = false;
            this.btnMoisEnCours.Click += new System.EventHandler(this.btnMoisEnCours_Click);
            // 
            // lblChiffreAffaires
            // 
            this.lblChiffreAffaires.AutoSize = true;
            this.lblChiffreAffaires.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiffreAffaires.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblChiffreAffaires.Location = new System.Drawing.Point(30, 131);
            this.lblChiffreAffaires.Name = "lblChiffreAffaires";
            this.lblChiffreAffaires.Size = new System.Drawing.Size(230, 16);
            this.lblChiffreAffaires.TabIndex = 11;
            this.lblChiffreAffaires.Text = "Chiffre d\'affaires total : 0.00 TND";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrateur - Clinique Vétérinaire";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabUtilisateurs.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).EndInit();
            this.tabMedicaments.ResumeLayout(false);
            this.panelMedicaments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).EndInit();
            this.tabDashboard.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.groupRevenus.ResumeLayout(false);
            this.groupRevenus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).EndInit();
            this.groupStats.ResumeLayout(false);
            this.groupStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableauDeBordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUtilisateurs;
        private System.Windows.Forms.TabPage tabMedicaments;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvUtilisateurs;
        private System.Windows.Forms.Panel panelMedicaments;
        private System.Windows.Forms.Button btnMedocActualiser;
        private System.Windows.Forms.Button btnMedocSupprimer;
        private System.Windows.Forms.Button btnMedocModifier;
        private System.Windows.Forms.Button btnMedocAjouter;
        private System.Windows.Forms.DataGridView dgvMedicaments;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.GroupBox groupStats;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNbUtilisateurs;
        private System.Windows.Forms.Label lblNbMedicaments;
        private System.Windows.Forms.GroupBox groupAlertes;
        private System.Windows.Forms.Label lblStockTotal;
        private System.Windows.Forms.Button btnRafraichirStats;
        private System.Windows.Forms.DataGridView dgvAlertes;
        private System.Windows.Forms.GroupBox groupRevenus;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.DateTimePicker dtpRevenusDebut;
        private System.Windows.Forms.Button btnCalculerRevenus;
        private System.Windows.Forms.DateTimePicker dtpRevenusFin;
        private System.Windows.Forms.Label lblRevenusTotal;
        private System.Windows.Forms.Button btnMoisEnCours;
        private System.Windows.Forms.Label lblChiffreAffaires;
    }
}