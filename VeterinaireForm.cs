using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CliniqueVeterinaire
{
    public partial class VeterinaireForm : Form
    {
        private int vétérinaireId;

        public VeterinaireForm(int idVétérinaire)
        {
            InitializeComponent();

            this.Text = "🩺 Vétérinaire - Clinique Vétérinaire";
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);

            tabControlVeto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            tabControlVeto.ItemSize = new System.Drawing.Size(160, 45);
            tabControlVeto.Padding = new System.Drawing.Point(15, 5);

            StyleDataGridView(dgvRdvVeto);
            StyleDataGridView(dgvConsultations);
            StyleDataGridView(dgvVaccinations);

           
            if (btnConsulter != null)
            {
                btnConsulter.FlatStyle = FlatStyle.Flat;
                btnConsulter.FlatAppearance.BorderSize = 0;
                btnConsulter.Cursor = Cursors.Hand;
                btnConsulter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                btnConsulter.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
                btnConsulter.ForeColor = System.Drawing.Color.White;
                btnConsulter.Text = "📋 Consulter";
                btnConsulter.Size = new System.Drawing.Size(120, 40);
            }

            if (btnAjouterVaccination != null)
            {
                btnAjouterVaccination.FlatStyle = FlatStyle.Flat;
                btnAjouterVaccination.FlatAppearance.BorderSize = 0;
                btnAjouterVaccination.Cursor = Cursors.Hand;
                btnAjouterVaccination.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                btnAjouterVaccination.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
                btnAjouterVaccination.ForeColor = System.Drawing.Color.White;
                btnAjouterVaccination.Text = "💉 Ajouter vaccination";
                btnAjouterVaccination.Size = new System.Drawing.Size(160, 40);
            }

            if (btnActualiserConsultations != null)
            {
                btnActualiserConsultations.FlatStyle = FlatStyle.Flat;
                btnActualiserConsultations.FlatAppearance.BorderSize = 0;
                btnActualiserConsultations.Cursor = Cursors.Hand;
                btnActualiserConsultations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                btnActualiserConsultations.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
                btnActualiserConsultations.ForeColor = System.Drawing.Color.White;
                btnActualiserConsultations.Text = "🔄 Actualiser";
                btnActualiserConsultations.Size = new System.Drawing.Size(110, 40);
            }

            if (btnActualiserVaccinations != null)
            {
                btnActualiserVaccinations.FlatStyle = FlatStyle.Flat;
                btnActualiserVaccinations.FlatAppearance.BorderSize = 0;
                btnActualiserVaccinations.Cursor = Cursors.Hand;
                btnActualiserVaccinations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                btnActualiserVaccinations.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
                btnActualiserVaccinations.ForeColor = System.Drawing.Color.White;
                btnActualiserVaccinations.Text = "🔄 Actualiser";
                btnActualiserVaccinations.Size = new System.Drawing.Size(110, 40);
            }

            

            vétérinaireId = idVétérinaire;
            ChargerRendezVous();
            ChargerConsultations();
            ChargerVaccinations();
        }

     
        private void StyleDataGridView(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);

            
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
        }

      
        private void ChargerRendezVous()
        {
            string query = @"
                SELECT r.Id, r.DateHeure, a.Nom as Animal, p.NomComplet as Proprietaire, r.Motif, r.Statut
                FROM RendezVous r
                INNER JOIN Animaux a ON r.IdAnimal = a.Id
                INNER JOIN Proprietaires p ON a.IdProprietaire = p.Id
                WHERE r.IdVeterinaire = @IdVeto AND CAST(r.DateHeure AS DATE) = CAST(GETDATE() AS DATE)
                ORDER BY r.DateHeure";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdVeto", vétérinaireId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvRdvVeto.DataSource = table;

                if (dgvRdvVeto.Columns["Id"] != null)
                    dgvRdvVeto.Columns["Id"].Visible = false;
            }
        }

      
        private void ChargerConsultations()
        {
            string query = @"
                SELECT c.Id, c.DateConsultation, a.Nom as Animal, c.Diagnostic, c.Traitement, c.Remarques
                FROM Consultations c
                INNER JOIN RendezVous r ON c.IdRendezVous = r.Id
                INNER JOIN Animaux a ON r.IdAnimal = a.Id
                ORDER BY c.DateConsultation DESC";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvConsultations.DataSource = table;

                if (dgvConsultations.Columns["Id"] != null)
                    dgvConsultations.Columns["Id"].Visible = false;
            }
        }

        
        private void ChargerVaccinations()
        {
            string query = @"
                SELECT v.Id, a.Nom as Animal, v.Vaccin, v.DateAdmin, v.DateRappel,
                    CASE 
                        WHEN v.DateRappel < GETDATE() THEN 'Expiré'
                        WHEN v.DateRappel <= DATEADD(day, 30, GETDATE()) THEN 'Rappel imminent'
                        ELSE 'À jour'
                    END as Statut
                FROM Vaccinations v
                INNER JOIN Animaux a ON v.IdAnimal = a.Id
                ORDER BY v.DateRappel";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvVaccinations.DataSource = table;

                if (dgvVaccinations.Columns["Id"] != null)
                    dgvVaccinations.Columns["Id"].Visible = false;
            }
        }

        
        private void btnConsulter_Click(object sender, EventArgs e)
        {
            if (dgvRdvVeto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous");
                return;
            }

            int rdvId = Convert.ToInt32(dgvRdvVeto.SelectedRows[0].Cells["Id"].Value);
            string animal = dgvRdvVeto.SelectedRows[0].Cells["Animal"].Value.ToString();

            Form formConsultation = new Form();
            formConsultation.Text = "🩺 Consultation - " + animal;
            formConsultation.Size = new System.Drawing.Size(550, 520);
            formConsultation.StartPosition = FormStartPosition.CenterParent;

            Label lblDiagnostic = new Label() { Text = "Diagnostic :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(100, 25) };
            TextBox txtDiagnostic = new TextBox() { Location = new System.Drawing.Point(130, 20), Size = new System.Drawing.Size(380, 25) };

            Label lblTraitement = new Label() { Text = "Traitement :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(100, 25) };
            TextBox txtTraitement = new TextBox() { Location = new System.Drawing.Point(130, 60), Size = new System.Drawing.Size(380, 25) };

            Label lblRemarques = new Label() { Text = "Remarques :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 25) };
            TextBox txtRemarques = new TextBox() { Location = new System.Drawing.Point(130, 100), Size = new System.Drawing.Size(380, 60), Multiline = true, Height = 60 };

            Label lblMedicament = new Label() { Text = "Médicament :", Location = new System.Drawing.Point(20, 180), Size = new System.Drawing.Size(100, 25) };
            ComboBox cmbMedicament = new ComboBox() { Location = new System.Drawing.Point(130, 180), Size = new System.Drawing.Size(250, 25) };

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Nom FROM Medicaments WHERE StockQuantite > 0", conn);
                DataTable medocs = new DataTable();
                adapter.Fill(medocs);
                cmbMedicament.DisplayMember = "Nom";
                cmbMedicament.ValueMember = "Id";
                cmbMedicament.DataSource = medocs;
                cmbMedicament.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            Label lblQuantite = new Label() { Text = "Quantité :", Location = new System.Drawing.Point(20, 220), Size = new System.Drawing.Size(100, 25) };
            NumericUpDown numQuantite = new NumericUpDown() { Location = new System.Drawing.Point(130, 220), Size = new System.Drawing.Size(80, 25), Minimum = 1, Maximum = 50, Value = 1 };

            Label lblMontant = new Label() { Text = "Montant (TND) :", Location = new System.Drawing.Point(20, 260), Size = new System.Drawing.Size(120, 25) };
            NumericUpDown numMontant = new NumericUpDown() { Location = new System.Drawing.Point(150, 260), Size = new System.Drawing.Size(120, 25), Minimum = 0, Maximum = 1000, Value = 50, DecimalPlaces = 2 };

            CheckBox chkPaye = new CheckBox() { Text = "Payé", Location = new System.Drawing.Point(20, 300), Size = new System.Drawing.Size(100, 25) };

            Button btnValider = new Button() { Text = "Enregistrer", Location = new System.Drawing.Point(130, 350), Size = new System.Drawing.Size(150, 40), BackColor = System.Drawing.Color.LightGreen };

            btnValider.Click += (s, ev) =>
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        if (cmbMedicament.SelectedValue != null && numQuantite.Value > 0)
                        {
                            int idMedoc = (int)cmbMedicament.SelectedValue;
                            int quantite = (int)numQuantite.Value;

                            SqlCommand cmdCheck = new SqlCommand("SELECT StockQuantite FROM Medicaments WHERE Id = @Id", conn, transaction);
                            cmdCheck.Parameters.AddWithValue("@Id", idMedoc);
                            int stock = (int)cmdCheck.ExecuteScalar();

                            if (stock < quantite)
                            {
                                MessageBox.Show($"Stock insuffisant ! Disponible : {stock}");
                                transaction.Rollback();
                                return;
                            }

                            SqlCommand cmdStock = new SqlCommand("UPDATE Medicaments SET StockQuantite = StockQuantite - @Qte WHERE Id = @Id", conn, transaction);
                            cmdStock.Parameters.AddWithValue("@Qte", quantite);
                            cmdStock.Parameters.AddWithValue("@Id", idMedoc);
                            cmdStock.ExecuteNonQuery();
                        }

                        string queryConsult = @"
                    INSERT INTO Consultations (IdRendezVous, Diagnostic, Traitement, Remarques, DateConsultation)
                    VALUES (@IdRdv, @Diag, @Trait, @Rem, @Date);
                    SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdConsult = new SqlCommand(queryConsult, conn, transaction);
                        cmdConsult.Parameters.AddWithValue("@IdRdv", rdvId);
                        cmdConsult.Parameters.AddWithValue("@Diag", txtDiagnostic.Text);
                        cmdConsult.Parameters.AddWithValue("@Trait", txtTraitement.Text);
                        cmdConsult.Parameters.AddWithValue("@Rem", txtRemarques.Text);
                        cmdConsult.Parameters.AddWithValue("@Date", DateTime.Now);

                        int consultId = Convert.ToInt32(cmdConsult.ExecuteScalar());

                       
                        string queryFacture = @"
                    INSERT INTO Factures (IdConsultation, Montant, DateFacture, Paye)
                    VALUES (@IdConsult, @Montant, @Date, @Paye)";

                        SqlCommand cmdFacture = new SqlCommand(queryFacture, conn, transaction);
                        cmdFacture.Parameters.AddWithValue("@IdConsult", consultId);
                        cmdFacture.Parameters.AddWithValue("@Montant", numMontant.Value);
                        cmdFacture.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmdFacture.Parameters.AddWithValue("@Paye", chkPaye.Checked);
                        cmdFacture.ExecuteNonQuery();

                        SqlCommand cmdRdv = new SqlCommand("UPDATE RendezVous SET Statut = 'Terminé' WHERE Id = @IdRdv", conn, transaction);
                        cmdRdv.Parameters.AddWithValue("@IdRdv", rdvId);
                        cmdRdv.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show($"✓ Consultation enregistrée !\n💰 Montant : {numMontant.Value} TND\n{(chkPaye.Checked ? "✓ Payé" : "⏳ En attente de paiement")}");
                        formConsultation.Close();
                        ChargerRendezVous();
                        ChargerConsultations();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            };

            formConsultation.Controls.AddRange(new Control[] {
        lblDiagnostic, txtDiagnostic, lblTraitement, txtTraitement,
        lblRemarques, txtRemarques, lblMedicament, cmbMedicament,
        lblQuantite, numQuantite, lblMontant, numMontant, chkPaye, btnValider
    });
            formConsultation.ShowDialog();
        }

        
        private void btnAjouterVaccination_Click(object sender, EventArgs e)
        {
            DataTable animaux = new DataTable();
            DataTable vaccins = new DataTable();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapterAnimaux = new SqlDataAdapter("SELECT Id, Nom FROM Animaux", conn);
                adapterAnimaux.Fill(animaux);

                SqlDataAdapter adapterVaccins = new SqlDataAdapter("SELECT Id, Nom, StockQuantite FROM Medicaments WHERE StockQuantite > 0", conn);
                adapterVaccins.Fill(vaccins);
            }

            Form form = new Form();
            form.Text = "Ajouter une vaccination";
            form.Size = new System.Drawing.Size(450, 350);
            form.StartPosition = FormStartPosition.CenterParent;

            Label lblAnimal = new Label() { Text = "Animal :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(100, 25) };
            ComboBox cmbAnimal = new ComboBox() { Location = new System.Drawing.Point(130, 20), Size = new System.Drawing.Size(250, 25) };
            cmbAnimal.DisplayMember = "Nom";
            cmbAnimal.ValueMember = "Id";
            cmbAnimal.DataSource = animaux;

            Label lblVaccin = new Label() { Text = "Vaccin :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(100, 25) };
            ComboBox cmbVaccin = new ComboBox() { Location = new System.Drawing.Point(130, 60), Size = new System.Drawing.Size(250, 25) };
            cmbVaccin.DisplayMember = "Nom";
            cmbVaccin.ValueMember = "Id";
            cmbVaccin.DataSource = vaccins;

            Label lblDateAdmin = new Label() { Text = "Date admin :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 25) };
            DateTimePicker dtpAdmin = new DateTimePicker() { Location = new System.Drawing.Point(130, 100), Size = new System.Drawing.Size(150, 25), Format = DateTimePickerFormat.Short };

            Label lblDateRappel = new Label() { Text = "Date rappel :", Location = new System.Drawing.Point(20, 140), Size = new System.Drawing.Size(100, 25) };
            DateTimePicker dtpRappel = new DateTimePicker() { Location = new System.Drawing.Point(130, 140), Size = new System.Drawing.Size(150, 25), Format = DateTimePickerFormat.Short };

            Button btnValider = new Button() { Text = "Ajouter", Location = new System.Drawing.Point(130, 200), Size = new System.Drawing.Size(120, 40), BackColor = System.Drawing.Color.LightGreen };

            btnValider.Click += (s, ev) =>
            {
                if (cmbAnimal.SelectedValue == null || cmbVaccin.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner un animal et un vaccin");
                    return;
                }

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        int idVaccin = (int)cmbVaccin.SelectedValue;

                       
                        SqlCommand cmdCheck = new SqlCommand("SELECT StockQuantite FROM Medicaments WHERE Id = @Id", conn, transaction);
                        cmdCheck.Parameters.AddWithValue("@Id", idVaccin);
                        int stock = (int)cmdCheck.ExecuteScalar();

                        if (stock < 1)
                        {
                            MessageBox.Show("Stock insuffisant pour ce vaccin !");
                            transaction.Rollback();
                            return;
                        }

                       
                        string queryVaccin = @"
                    INSERT INTO Vaccinations (IdAnimal, Vaccin, DateAdmin, DateRappel)
                    VALUES (@IdAnimal, @Vaccin, @DateAdmin, @DateRappel)";

                        SqlCommand cmdVaccin = new SqlCommand(queryVaccin, conn, transaction);
                        cmdVaccin.Parameters.AddWithValue("@IdAnimal", cmbAnimal.SelectedValue);
                        cmdVaccin.Parameters.AddWithValue("@Vaccin", cmbVaccin.Text);
                        cmdVaccin.Parameters.AddWithValue("@DateAdmin", dtpAdmin.Value);
                        cmdVaccin.Parameters.AddWithValue("@DateRappel", dtpRappel.Value);
                        cmdVaccin.ExecuteNonQuery();

                       
                        SqlCommand cmdStock = new SqlCommand("UPDATE Medicaments SET StockQuantite = StockQuantite - 1 WHERE Id = @Id", conn, transaction);
                        cmdStock.Parameters.AddWithValue("@Id", idVaccin);
                        cmdStock.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show($"✓ Vaccination ajoutée !\nStock restant : {stock - 1}");
                        form.Close();
                        ChargerVaccinations();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            };

            form.Controls.AddRange(new Control[] { lblAnimal, cmbAnimal, lblVaccin, cmbVaccin, lblDateAdmin, dtpAdmin, lblDateRappel, dtpRappel, btnValider });
            form.ShowDialog();
        }

       
        private void btnActualiserConsultations_Click(object sender, EventArgs e)
        {
            ChargerConsultations();
        }

        private void btnActualiserVaccinations_Click(object sender, EventArgs e)
        {
            ChargerVaccinations();
        }
    }
}