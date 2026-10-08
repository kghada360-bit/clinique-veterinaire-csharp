namespace CliniqueVeterinaire
{
    partial class VeterinaireForm
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
            this.tabControlVeto = new System.Windows.Forms.TabControl();
            this.tabRendezVous = new System.Windows.Forms.TabPage();
            this.panelRdvVeto = new System.Windows.Forms.Panel();
            this.btnConsulter = new System.Windows.Forms.Button();
            this.dgvRdvVeto = new System.Windows.Forms.DataGridView();
            this.tabConsultations = new System.Windows.Forms.TabPage();
            this.panelConsultations = new System.Windows.Forms.Panel();
            this.btnActualiserConsultations = new System.Windows.Forms.Button();
            this.dgvConsultations = new System.Windows.Forms.DataGridView();
            this.tabVaccinations = new System.Windows.Forms.TabPage();
            this.panelVaccinations = new System.Windows.Forms.Panel();
            this.btnActualiserVaccinations = new System.Windows.Forms.Button();
            this.btnAjouterVaccination = new System.Windows.Forms.Button();
            this.dgvVaccinations = new System.Windows.Forms.DataGridView();
            this.tabControlVeto.SuspendLayout();
            this.tabRendezVous.SuspendLayout();
            this.panelRdvVeto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRdvVeto)).BeginInit();
            this.tabConsultations.SuspendLayout();
            this.panelConsultations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).BeginInit();
            this.tabVaccinations.SuspendLayout();
            this.panelVaccinations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccinations)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlVeto
            // 
            this.tabControlVeto.Controls.Add(this.tabRendezVous);
            this.tabControlVeto.Controls.Add(this.tabConsultations);
            this.tabControlVeto.Controls.Add(this.tabVaccinations);
            this.tabControlVeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVeto.Location = new System.Drawing.Point(0, 0);
            this.tabControlVeto.Name = "tabControlVeto";
            this.tabControlVeto.SelectedIndex = 0;
            this.tabControlVeto.Size = new System.Drawing.Size(982, 603);
            this.tabControlVeto.TabIndex = 0;
            // 
            // tabRendezVous
            // 
            this.tabRendezVous.Controls.Add(this.panelRdvVeto);
            this.tabRendezVous.Controls.Add(this.dgvRdvVeto);
            this.tabRendezVous.Location = new System.Drawing.Point(4, 25);
            this.tabRendezVous.Name = "tabRendezVous";
            this.tabRendezVous.Padding = new System.Windows.Forms.Padding(3);
            this.tabRendezVous.Size = new System.Drawing.Size(974, 574);
            this.tabRendezVous.TabIndex = 0;
            this.tabRendezVous.Text = "📅 Rendez-vous du jour";
            this.tabRendezVous.UseVisualStyleBackColor = true;
            // 
            // panelRdvVeto
            // 
            this.panelRdvVeto.Controls.Add(this.btnConsulter);
            this.panelRdvVeto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRdvVeto.Location = new System.Drawing.Point(3, 471);
            this.panelRdvVeto.Name = "panelRdvVeto";
            this.panelRdvVeto.Size = new System.Drawing.Size(968, 100);
            this.panelRdvVeto.TabIndex = 1;
            // 
            // btnConsulter
            // 
            this.btnConsulter.BackColor = System.Drawing.Color.LightBlue;
            this.btnConsulter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulter.Location = new System.Drawing.Point(276, 22);
            this.btnConsulter.Name = "btnConsulter";
            this.btnConsulter.Size = new System.Drawing.Size(205, 58);
            this.btnConsulter.TabIndex = 0;
            this.btnConsulter.Text = "📋 Consulter";
            this.btnConsulter.UseVisualStyleBackColor = false;
            this.btnConsulter.Click += new System.EventHandler(this.btnConsulter_Click);
            // 
            // dgvRdvVeto
            // 
            this.dgvRdvVeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRdvVeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRdvVeto.Location = new System.Drawing.Point(3, 3);
            this.dgvRdvVeto.Name = "dgvRdvVeto";
            this.dgvRdvVeto.RowHeadersWidth = 51;
            this.dgvRdvVeto.RowTemplate.Height = 24;
            this.dgvRdvVeto.Size = new System.Drawing.Size(968, 568);
            this.dgvRdvVeto.TabIndex = 0;
            // 
            // tabConsultations
            // 
            this.tabConsultations.Controls.Add(this.panelConsultations);
            this.tabConsultations.Controls.Add(this.dgvConsultations);
            this.tabConsultations.Location = new System.Drawing.Point(4, 25);
            this.tabConsultations.Name = "tabConsultations";
            this.tabConsultations.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultations.Size = new System.Drawing.Size(974, 574);
            this.tabConsultations.TabIndex = 1;
            this.tabConsultations.Text = "📝 Consultations";
            this.tabConsultations.UseVisualStyleBackColor = true;
            // 
            // panelConsultations
            // 
            this.panelConsultations.Controls.Add(this.btnActualiserConsultations);
            this.panelConsultations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelConsultations.Location = new System.Drawing.Point(3, 471);
            this.panelConsultations.Name = "panelConsultations";
            this.panelConsultations.Size = new System.Drawing.Size(968, 100);
            this.panelConsultations.TabIndex = 1;
            // 
            // btnActualiserConsultations
            // 
            this.btnActualiserConsultations.BackColor = System.Drawing.Color.LightGray;
            this.btnActualiserConsultations.Location = new System.Drawing.Point(286, 31);
            this.btnActualiserConsultations.Name = "btnActualiserConsultations";
            this.btnActualiserConsultations.Size = new System.Drawing.Size(168, 51);
            this.btnActualiserConsultations.TabIndex = 1;
            this.btnActualiserConsultations.Text = "🔄 Actualiser";
            this.btnActualiserConsultations.UseVisualStyleBackColor = false;
            this.btnActualiserConsultations.Click += new System.EventHandler(this.btnActualiserConsultations_Click);
            // 
            // dgvConsultations
            // 
            this.dgvConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultations.Location = new System.Drawing.Point(3, 3);
            this.dgvConsultations.Name = "dgvConsultations";
            this.dgvConsultations.RowHeadersWidth = 51;
            this.dgvConsultations.RowTemplate.Height = 24;
            this.dgvConsultations.Size = new System.Drawing.Size(968, 568);
            this.dgvConsultations.TabIndex = 0;
            // 
            // tabVaccinations
            // 
            this.tabVaccinations.Controls.Add(this.panelVaccinations);
            this.tabVaccinations.Controls.Add(this.dgvVaccinations);
            this.tabVaccinations.Location = new System.Drawing.Point(4, 25);
            this.tabVaccinations.Name = "tabVaccinations";
            this.tabVaccinations.Padding = new System.Windows.Forms.Padding(3);
            this.tabVaccinations.Size = new System.Drawing.Size(974, 574);
            this.tabVaccinations.TabIndex = 2;
            this.tabVaccinations.Text = "💉 Vaccinations";
            this.tabVaccinations.UseVisualStyleBackColor = true;
            // 
            // panelVaccinations
            // 
            this.panelVaccinations.Controls.Add(this.btnActualiserVaccinations);
            this.panelVaccinations.Controls.Add(this.btnAjouterVaccination);
            this.panelVaccinations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVaccinations.Location = new System.Drawing.Point(3, 471);
            this.panelVaccinations.Name = "panelVaccinations";
            this.panelVaccinations.Size = new System.Drawing.Size(968, 100);
            this.panelVaccinations.TabIndex = 1;
            // 
            // btnActualiserVaccinations
            // 
            this.btnActualiserVaccinations.BackColor = System.Drawing.Color.LightGray;
            this.btnActualiserVaccinations.Location = new System.Drawing.Point(398, 30);
            this.btnActualiserVaccinations.Name = "btnActualiserVaccinations";
            this.btnActualiserVaccinations.Size = new System.Drawing.Size(158, 50);
            this.btnActualiserVaccinations.TabIndex = 1;
            this.btnActualiserVaccinations.Text = "🔄 Actualiser";
            this.btnActualiserVaccinations.UseVisualStyleBackColor = false;
            this.btnActualiserVaccinations.Click += new System.EventHandler(this.btnActualiserVaccinations_Click);
            // 
            // btnAjouterVaccination
            // 
            this.btnAjouterVaccination.BackColor = System.Drawing.Color.LightGreen;
            this.btnAjouterVaccination.Location = new System.Drawing.Point(110, 30);
            this.btnAjouterVaccination.Name = "btnAjouterVaccination";
            this.btnAjouterVaccination.Size = new System.Drawing.Size(158, 50);
            this.btnAjouterVaccination.TabIndex = 0;
            this.btnAjouterVaccination.Text = "💉 Ajouter vaccination";
            this.btnAjouterVaccination.UseVisualStyleBackColor = false;
            this.btnAjouterVaccination.Click += new System.EventHandler(this.btnAjouterVaccination_Click);
            // 
            // dgvVaccinations
            // 
            this.dgvVaccinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaccinations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVaccinations.Location = new System.Drawing.Point(3, 3);
            this.dgvVaccinations.Name = "dgvVaccinations";
            this.dgvVaccinations.RowHeadersWidth = 51;
            this.dgvVaccinations.RowTemplate.Height = 24;
            this.dgvVaccinations.Size = new System.Drawing.Size(968, 568);
            this.dgvVaccinations.TabIndex = 0;
            // 
            // VeterinaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.tabControlVeto);
            this.Name = "VeterinaireForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vétérinaire - Clinique Vétérinaire";
            this.tabControlVeto.ResumeLayout(false);
            this.tabRendezVous.ResumeLayout(false);
            this.panelRdvVeto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRdvVeto)).EndInit();
            this.tabConsultations.ResumeLayout(false);
            this.panelConsultations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).EndInit();
            this.tabVaccinations.ResumeLayout(false);
            this.panelVaccinations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccinations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVeto;
        private System.Windows.Forms.TabPage tabRendezVous;
        private System.Windows.Forms.TabPage tabConsultations;
        private System.Windows.Forms.TabPage tabVaccinations;
        private System.Windows.Forms.DataGridView dgvRdvVeto;
        private System.Windows.Forms.Panel panelRdvVeto;
        private System.Windows.Forms.Button btnConsulter;
        private System.Windows.Forms.Panel panelConsultations;
        private System.Windows.Forms.Button btnActualiserConsultations;
        private System.Windows.Forms.DataGridView dgvConsultations;
        private System.Windows.Forms.DataGridView dgvVaccinations;
        private System.Windows.Forms.Panel panelVaccinations;
        private System.Windows.Forms.Button btnActualiserVaccinations;
        private System.Windows.Forms.Button btnAjouterVaccination;
    }
}