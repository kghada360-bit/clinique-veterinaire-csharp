using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Font = iTextSharp.text.Font;
using PdfFont = iTextSharp.text.Font;

namespace CliniqueVeterinaire
{
    public partial class SecretaireForm : Form
    {
        public SecretaireForm()
        {
            InitializeComponent();

            this.Text = "📋 Secrétaire - Clinique Vétérinaire";
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);

            tabControlSecretaire.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            tabControlSecretaire.ItemSize = new System.Drawing.Size(150, 45);
            tabControlSecretaire.Padding = new System.Drawing.Point(15, 5);

            StyleDataGridView(dgvProprietaires);
            StyleDataGridView(dgvAnimaux);
            StyleDataGridView(dgvRendezVous);

            StyleButtons(new Button[] { btnPropAjouter, btnPropModifier, btnPropSupprimer, btnPropActualiser });

            StyleButtons(new Button[] { btnAnimauxAjouter, btnAnimauxModifier, btnAnimauxSupprimer, btnAnimauxActualiser });

            StyleButtons(new Button[] { btnRdvAjouter, btnRdvModifier, btnRdvSupprimer, btnRdvActualiser });

            SetButtonIcons();

            ChargerProprietaires();
            ChargerAnimaux();
            ChargerRendezVous();
            ChargerFactures();
            ChargerFiltres();
          
            if (btnMarquerPaye != null)
            {
                btnMarquerPaye.FlatStyle = FlatStyle.Flat;
                btnMarquerPaye.FlatAppearance.BorderSize = 0;
                btnMarquerPaye.Cursor = Cursors.Hand;
                btnMarquerPaye.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                btnMarquerPaye.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
                btnMarquerPaye.ForeColor = System.Drawing.Color.White;
                btnMarquerPaye.Text = "✅ Marquer comme payé";
                btnMarquerPaye.Size = new System.Drawing.Size(150, 38);
            }

            if (btnActualiserFactures != null)
            {
                btnActualiserFactures.FlatStyle = FlatStyle.Flat;
                btnActualiserFactures.FlatAppearance.BorderSize = 0;
                btnActualiserFactures.Cursor = Cursors.Hand;
                btnActualiserFactures.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                btnActualiserFactures.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
                btnActualiserFactures.ForeColor = System.Drawing.Color.White;
                btnActualiserFactures.Text = "🔄 Actualiser";
                btnActualiserFactures.Size = new System.Drawing.Size(110, 38);
            }
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

        private void StyleButtons(Button[] buttons)
        {
            foreach (Button btn in buttons)
            {
                if (btn != null)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.Size = new System.Drawing.Size(110, 38);
                }
            }
        }

        private void SetButtonIcons()
        {

            if (btnPropAjouter != null) { btnPropAjouter.BackColor = System.Drawing.Color.FromArgb(46, 125, 50); btnPropAjouter.Text = "➕ Ajouter"; }
            if (btnPropModifier != null) { btnPropModifier.BackColor = System.Drawing.Color.FromArgb(33, 150, 243); btnPropModifier.Text = "✏️ Modifier"; }
            if (btnPropSupprimer != null) { btnPropSupprimer.BackColor = System.Drawing.Color.FromArgb(244, 67, 54); btnPropSupprimer.Text = "🗑️ Supprimer"; }
            if (btnPropActualiser != null) { btnPropActualiser.BackColor = System.Drawing.Color.FromArgb(100, 100, 100); btnPropActualiser.Text = "🔄 Actualiser"; }

      
            if (btnAnimauxAjouter != null) { btnAnimauxAjouter.BackColor = System.Drawing.Color.FromArgb(46, 125, 50); btnAnimauxAjouter.Text = "➕ Ajouter"; }
            if (btnAnimauxModifier != null) { btnAnimauxModifier.BackColor = System.Drawing.Color.FromArgb(33, 150, 243); btnAnimauxModifier.Text = "✏️ Modifier"; }
            if (btnAnimauxSupprimer != null) { btnAnimauxSupprimer.BackColor = System.Drawing.Color.FromArgb(244, 67, 54); btnAnimauxSupprimer.Text = "🗑️ Supprimer"; }
            if (btnAnimauxActualiser != null) { btnAnimauxActualiser.BackColor = System.Drawing.Color.FromArgb(100, 100, 100); btnAnimauxActualiser.Text = "🔄 Actualiser"; }

          
            if (btnRdvAjouter != null) { btnRdvAjouter.BackColor = System.Drawing.Color.FromArgb(46, 125, 50); btnRdvAjouter.Text = "➕ Ajouter"; }
            if (btnRdvModifier != null) { btnRdvModifier.BackColor = System.Drawing.Color.FromArgb(33, 150, 243); btnRdvModifier.Text = "✏️ Modifier"; }
            if (btnRdvSupprimer != null) { btnRdvSupprimer.BackColor = System.Drawing.Color.FromArgb(244, 67, 54); btnRdvSupprimer.Text = "🗑️ Supprimer"; }
            if (btnRdvActualiser != null) { btnRdvActualiser.BackColor = System.Drawing.Color.FromArgb(100, 100, 100); btnRdvActualiser.Text = "🔄 Actualiser"; }
        }

       
        private void ChargerProprietaires()
        {
            string query = "SELECT Id, NomComplet, Telephone, Email, Adresse FROM Proprietaires";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProprietaires.DataSource = table;

                if (dgvProprietaires.Columns["Id"] != null)
                {
                    dgvProprietaires.Columns["Id"].Visible = false;
                }
            }
        }

       
        private void btnPropActualiser_Click(object sender, EventArgs e)
        {
            ChargerProprietaires();
        }

      
        private void btnPropAjouter_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Ajouter un propriétaire";
            form.Size = new System.Drawing.Size(450, 300);
            form.StartPosition = FormStartPosition.CenterParent;

            Label lblNom = new Label() { Text = "Nom complet :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(100, 25) };
            TextBox txtNom = new TextBox() { Location = new System.Drawing.Point(140, 20), Size = new System.Drawing.Size(250, 25) };

            Label lblTel = new Label() { Text = "Téléphone :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(100, 25) };
            TextBox txtTel = new TextBox() { Location = new System.Drawing.Point(140, 60), Size = new System.Drawing.Size(250, 25) };

            Label lblEmail = new Label() { Text = "Email :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 25) };
            TextBox txtEmail = new TextBox() { Location = new System.Drawing.Point(140, 100), Size = new System.Drawing.Size(250, 25) };

            Label lblAdresse = new Label() { Text = "Adresse :", Location = new System.Drawing.Point(20, 140), Size = new System.Drawing.Size(100, 25) };
            TextBox txtAdresse = new TextBox() { Location = new System.Drawing.Point(140, 140), Size = new System.Drawing.Size(250, 60), Multiline = true, Height = 60 };

            Button btnValider = new Button() { Text = "Ajouter", Location = new System.Drawing.Point(140, 220), Size = new System.Drawing.Size(100, 35), BackColor = System.Drawing.Color.LightGreen };

            btnValider.Click += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtNom.Text))
                {
                    MessageBox.Show("Veuillez entrer un nom");
                    return;
                }

                string query = "INSERT INTO Proprietaires (NomComplet, Telephone, Email, Adresse) VALUES (@Nom, @Tel, @Email, @Adresse)";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@Tel", txtTel.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Adresse", txtAdresse.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Propriétaire ajouté !");
                form.Close();
                ChargerProprietaires();
            };

            form.Controls.AddRange(new Control[] { lblNom, txtNom, lblTel, txtTel, lblEmail, txtEmail, lblAdresse, txtAdresse, btnValider });
            form.ShowDialog();
        }

      
        private void btnPropModifier_Click(object sender, EventArgs e)
        {
            if (dgvProprietaires.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un propriétaire");
                return;
            }

            int id = Convert.ToInt32(dgvProprietaires.SelectedRows[0].Cells["Id"].Value);
            string nomActuel = dgvProprietaires.SelectedRows[0].Cells["NomComplet"].Value.ToString();
            string telActuel = dgvProprietaires.SelectedRows[0].Cells["Telephone"].Value.ToString();
            string emailActuel = dgvProprietaires.SelectedRows[0].Cells["Email"].Value.ToString();
            string adresseActuelle = dgvProprietaires.SelectedRows[0].Cells["Adresse"].Value.ToString();

            Form form = new Form();
            form.Text = "Modifier un propriétaire";
            form.Size = new System.Drawing.Size(450, 300);
            form.StartPosition = FormStartPosition.CenterParent;

            Label lblNom = new Label() { Text = "Nom complet :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(100, 25) };
            TextBox txtNom = new TextBox() { Text = nomActuel, Location = new System.Drawing.Point(140, 20), Size = new System.Drawing.Size(250, 25) };

            Label lblTel = new Label() { Text = "Téléphone :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(100, 25) };
            TextBox txtTel = new TextBox() { Text = telActuel, Location = new System.Drawing.Point(140, 60), Size = new System.Drawing.Size(250, 25) };

            Label lblEmail = new Label() { Text = "Email :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 25) };
            TextBox txtEmail = new TextBox() { Text = emailActuel, Location = new System.Drawing.Point(140, 100), Size = new System.Drawing.Size(250, 25) };

            Label lblAdresse = new Label() { Text = "Adresse :", Location = new System.Drawing.Point(20, 140), Size = new System.Drawing.Size(100, 25) };
            TextBox txtAdresse = new TextBox() { Text = adresseActuelle, Location = new System.Drawing.Point(140, 140), Size = new System.Drawing.Size(250, 60), Multiline = true, Height = 60 };

            Button btnValider = new Button() { Text = "Modifier", Location = new System.Drawing.Point(140, 220), Size = new System.Drawing.Size(100, 35), BackColor = System.Drawing.Color.LightBlue };

            btnValider.Click += (s, ev) =>
            {
                string query = "UPDATE Proprietaires SET NomComplet=@Nom, Telephone=@Tel, Email=@Email, Adresse=@Adresse WHERE Id=@Id";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@Tel", txtTel.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Adresse", txtAdresse.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Propriétaire modifié !");
                form.Close();
                ChargerProprietaires();
            };

            form.Controls.AddRange(new Control[] { lblNom, txtNom, lblTel, txtTel, lblEmail, txtEmail, lblAdresse, txtAdresse, btnValider });
            form.ShowDialog();
        }

        private void btnPropSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvProprietaires.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un propriétaire");
                return;
            }

            int id = Convert.ToInt32(dgvProprietaires.SelectedRows[0].Cells["Id"].Value);
            string nom = dgvProprietaires.SelectedRows[0].Cells["NomComplet"].Value.ToString();

            DialogResult result = MessageBox.Show($"Supprimer '{nom}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Proprietaires WHERE Id=@Id";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Propriétaire supprimé !");
                ChargerProprietaires();
            }
        }
        
        private void ChargerAnimaux()
        {
            string query = @"
        SELECT a.Id, a.Nom, a.Espece, a.Race, a.DateNaissance, p.NomComplet as Proprietaire
        FROM Animaux a
        INNER JOIN Proprietaires p ON a.IdProprietaire = p.Id";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvAnimaux.DataSource = table;

                if (dgvAnimaux.Columns["Id"] != null)
                {
                    dgvAnimaux.Columns["Id"].Visible = false;
                }
            }
        }

       
        private void btnAnimauxActualiser_Click(object sender, EventArgs e)
        {
            ChargerAnimaux();
        }

       
        private void btnAnimauxAjouter_Click(object sender, EventArgs e)
        {
            
            DataTable proprietaires = new DataTable();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, NomComplet FROM Proprietaires", conn);
                adapter.Fill(proprietaires);
            }

            Form form = new Form();
            form.Text = "Ajouter un animal";
            form.Size = new System.Drawing.Size(450, 350);
            form.StartPosition = FormStartPosition.CenterParent;

            Label lblNom = new Label() { Text = "Nom :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(100, 25) };
            TextBox txtNom = new TextBox() { Location = new System.Drawing.Point(140, 20), Size = new System.Drawing.Size(250, 25) };

            Label lblEspece = new Label() { Text = "Espèce :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(100, 25) };
            TextBox txtEspece = new TextBox() { Location = new System.Drawing.Point(140, 60), Size = new System.Drawing.Size(250, 25) };

            Label lblRace = new Label() { Text = "Race :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 25) };
            TextBox txtRace = new TextBox() { Location = new System.Drawing.Point(140, 100), Size = new System.Drawing.Size(250, 25) };

            Label lblDate = new Label() { Text = "Date naissance :", Location = new System.Drawing.Point(20, 140), Size = new System.Drawing.Size(120, 25) };
            DateTimePicker dtpDate = new DateTimePicker() { Location = new System.Drawing.Point(140, 140), Size = new System.Drawing.Size(150, 25), Format = DateTimePickerFormat.Short };

            Label lblProp = new Label() { Text = "Propriétaire :", Location = new System.Drawing.Point(20, 180), Size = new System.Drawing.Size(100, 25) };
            ComboBox cmbProp = new ComboBox() { Location = new System.Drawing.Point(140, 180), Size = new System.Drawing.Size(250, 25) };
            cmbProp.DisplayMember = "NomComplet";
            cmbProp.ValueMember = "Id";
            cmbProp.DataSource = proprietaires;

            Button btnValider = new Button() { Text = "Ajouter", Location = new System.Drawing.Point(140, 240), Size = new System.Drawing.Size(100, 35), BackColor = System.Drawing.Color.LightGreen };

            btnValider.Click += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtNom.Text) || cmbProp.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez remplir les champs obligatoires");
                    return;
                }

                string query = "INSERT INTO Animaux (Nom, Espece, Race, DateNaissance, IdProprietaire) VALUES (@Nom, @Espece, @Race, @Date, @IdProp)";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@Espece", txtEspece.Text);
                    cmd.Parameters.AddWithValue("@Race", txtRace.Text);
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@IdProp", cmbProp.SelectedValue);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Animal ajouté !");
                form.Close();
                ChargerAnimaux();
            };

            form.Controls.AddRange(new Control[] { lblNom, txtNom, lblEspece, txtEspece, lblRace, txtRace, lblDate, dtpDate, lblProp, cmbProp, btnValider });
            form.ShowDialog();
        }

      
        private void btnAnimauxModifier_Click(object sender, EventArgs e)
        {
            if (dgvAnimaux.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un animal");
                return;
            }

            int id = Convert.ToInt32(dgvAnimaux.SelectedRows[0].Cells["Id"].Value);
            string nomActuel = dgvAnimaux.SelectedRows[0].Cells["Nom"].Value.ToString();
            string especeActuelle = dgvAnimaux.SelectedRows[0].Cells["Espece"].Value.ToString();
            string raceActuelle = dgvAnimaux.SelectedRows[0].Cells["Race"].Value.ToString();
            DateTime dateActuelle = Convert.ToDateTime(dgvAnimaux.SelectedRows[0].Cells["DateNaissance"].Value);

            DataTable proprietaires = new DataTable();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, NomComplet FROM Proprietaires", conn);
                adapter.Fill(proprietaires);
            }

            Form form = new Form();
            form.Text = "Modifier un animal";
            form.Size = new System.Drawing.Size(450, 350);
            form.StartPosition = FormStartPosition.CenterParent;

            Label lblNom = new Label() { Text = "Nom :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(100, 25) };
            TextBox txtNom = new TextBox() { Text = nomActuel, Location = new System.Drawing.Point(140, 20), Size = new System.Drawing.Size(250, 25) };

            Label lblEspece = new Label() { Text = "Espèce :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(100, 25) };
            TextBox txtEspece = new TextBox() { Text = especeActuelle, Location = new System.Drawing.Point(140, 60), Size = new System.Drawing.Size(250, 25) };

            Label lblRace = new Label() { Text = "Race :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 25) };
            TextBox txtRace = new TextBox() { Text = raceActuelle, Location = new System.Drawing.Point(140, 100), Size = new System.Drawing.Size(250, 25) };

            Label lblDate = new Label() { Text = "Date naissance :", Location = new System.Drawing.Point(20, 140), Size = new System.Drawing.Size(120, 25) };
            DateTimePicker dtpDate = new DateTimePicker() { Location = new System.Drawing.Point(140, 140), Size = new System.Drawing.Size(150, 25), Format = DateTimePickerFormat.Short, Value = dateActuelle };

            Label lblProp = new Label() { Text = "Propriétaire :", Location = new System.Drawing.Point(20, 180), Size = new System.Drawing.Size(100, 25) };
            ComboBox cmbProp = new ComboBox() { Location = new System.Drawing.Point(140, 180), Size = new System.Drawing.Size(250, 25) };
            cmbProp.DisplayMember = "NomComplet";
            cmbProp.ValueMember = "Id";
            cmbProp.DataSource = proprietaires;

            Button btnValider = new Button() { Text = "Modifier", Location = new System.Drawing.Point(140, 240), Size = new System.Drawing.Size(100, 35), BackColor = System.Drawing.Color.LightBlue };

            btnValider.Click += (s, ev) =>
            {
                string query = "UPDATE Animaux SET Nom=@Nom, Espece=@Espece, Race=@Race, DateNaissance=@Date, IdProprietaire=@IdProp WHERE Id=@Id";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@Espece", txtEspece.Text);
                    cmd.Parameters.AddWithValue("@Race", txtRace.Text);
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@IdProp", cmbProp.SelectedValue);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Animal modifié !");
                form.Close();
                ChargerAnimaux();
            };

            form.Controls.AddRange(new Control[] { lblNom, txtNom, lblEspece, txtEspece, lblRace, txtRace, lblDate, dtpDate, lblProp, cmbProp, btnValider });
            form.ShowDialog();
        }

      
        private void btnAnimauxSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAnimaux.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un animal");
                return;
            }

            int id = Convert.ToInt32(dgvAnimaux.SelectedRows[0].Cells["Id"].Value);
            string nom = dgvAnimaux.SelectedRows[0].Cells["Nom"].Value.ToString();

            DialogResult result = MessageBox.Show($"Supprimer '{nom}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Animaux WHERE Id=@Id";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Animal supprimé !");
                ChargerAnimaux();
            }
        }
       
        private void ChargerRendezVous(DateTime? dateDebut = null, DateTime? dateFin = null, int? idAnimal = null, string statut = null)
        {
            string query = @"
        SELECT r.Id, r.DateHeure, a.Nom as Animal, p.NomComplet as Proprietaire, 
               r.Motif, r.Statut, u.Nom as Veterinaire
        FROM RendezVous r
        INNER JOIN Animaux a ON r.IdAnimal = a.Id
        INNER JOIN Proprietaires p ON a.IdProprietaire = p.Id
        INNER JOIN Utilisateurs u ON r.IdVeterinaire = u.Id
        WHERE 1=1";

            List<string> conditions = new List<string>();
            List<SqlParameter> parameters = new List<SqlParameter>();

           
            if (dateDebut.HasValue)
            {
                conditions.Add("CAST(r.DateHeure AS DATE) >= @DateDebut");
                parameters.Add(new SqlParameter("@DateDebut", dateDebut.Value));
            }

            
            if (dateFin.HasValue)
            {
                conditions.Add("CAST(r.DateHeure AS DATE) <= @DateFin");
                parameters.Add(new SqlParameter("@DateFin", dateFin.Value));
            }

            
            if (idAnimal.HasValue && idAnimal.Value > 0)
            {
                conditions.Add("r.IdAnimal = @IdAnimal");
                parameters.Add(new SqlParameter("@IdAnimal", idAnimal.Value));
            }

            
            if (!string.IsNullOrEmpty(statut) && statut != "Tous")
            {
                conditions.Add("r.Statut = @Statut");
                parameters.Add(new SqlParameter("@Statut", statut));
            }

            if (conditions.Count > 0)
            {
                query += " AND " + string.Join(" AND ", conditions);
            }

            query += " ORDER BY r.DateHeure DESC";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters.ToArray());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvRendezVous.DataSource = table;

                if (dgvRendezVous.Columns["Id"] != null)
                    dgvRendezVous.Columns["Id"].Visible = false;
            }

            
            if (dgvRendezVous.Rows.Count == 0)
            {
                MessageBox.Show("Aucun rendez-vous trouvé avec ces critères.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            DateTime? dateDebut = dtpDateDebut.Checked ? dtpDateDebut.Value : (DateTime?)null;
            DateTime? dateFin = dtpDateFin.Checked ? dtpDateFin.Value : (DateTime?)null;
            int? idAnimal = null;
            string statut = null;

            
            if (cmbFiltreAnimal.SelectedValue != null && cmbFiltreAnimal.SelectedValue.ToString() != "0")
            {
                idAnimal = (int)cmbFiltreAnimal.SelectedValue;
            }

           
            if (cmbFiltreStatut.SelectedItem != null && cmbFiltreStatut.SelectedItem.ToString() != "Tous")
            {
                statut = cmbFiltreStatut.SelectedItem.ToString();
            }

            ChargerRendezVous(dateDebut, dateFin, idAnimal, statut);
        }
       
        private void btnRdvActualiser_Click(object sender, EventArgs e)
        {
            ChargerRendezVous();
        }

        
        private void btnRdvAjouter_Click(object sender, EventArgs e)
        {
           
            DataTable animaux = new DataTable();
            DataTable veterinaires = new DataTable();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapterAnimaux = new SqlDataAdapter("SELECT Id, Nom FROM Animaux", conn);
                adapterAnimaux.Fill(animaux);

                SqlDataAdapter adapterVeto = new SqlDataAdapter("SELECT Id, Nom FROM Utilisateurs WHERE Role = 'Veterinaire'", conn);
                adapterVeto.Fill(veterinaires);
            }

            Form form = new Form();
            form.Text = "Ajouter un rendez-vous";
            form.Size = new System.Drawing.Size(480, 350);
            form.StartPosition = FormStartPosition.CenterParent;

            Label lblDate = new Label() { Text = "Date et heure :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(120, 25) };
            DateTimePicker dtpDate = new DateTimePicker() { Location = new System.Drawing.Point(150, 20), Size = new System.Drawing.Size(250, 25), Format = DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy HH:mm", ShowUpDown = true };

            Label lblMotif = new Label() { Text = "Motif :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(100, 25) };
            TextBox txtMotif = new TextBox() { Location = new System.Drawing.Point(150, 60), Size = new System.Drawing.Size(250, 25) };

            Label lblAnimal = new Label() { Text = "Animal :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 25) };
            ComboBox cmbAnimal = new ComboBox() { Location = new System.Drawing.Point(150, 100), Size = new System.Drawing.Size(250, 25) };
            cmbAnimal.DisplayMember = "Nom";
            cmbAnimal.ValueMember = "Id";
            cmbAnimal.DataSource = animaux;

            Label lblVeto = new Label() { Text = "Vétérinaire :", Location = new System.Drawing.Point(20, 140), Size = new System.Drawing.Size(100, 25) };
            ComboBox cmbVeto = new ComboBox() { Location = new System.Drawing.Point(150, 140), Size = new System.Drawing.Size(250, 25) };
            cmbVeto.DisplayMember = "Nom";
            cmbVeto.ValueMember = "Id";
            cmbVeto.DataSource = veterinaires;

            Label lblStatut = new Label() { Text = "Statut :", Location = new System.Drawing.Point(20, 180), Size = new System.Drawing.Size(100, 25) };
            ComboBox cmbStatut = new ComboBox() { Location = new System.Drawing.Point(150, 180), Size = new System.Drawing.Size(150, 25) };
            cmbStatut.Items.AddRange(new string[] { "Planifié", "Confirmé", "Annulé", "Terminé" });
            cmbStatut.SelectedIndex = 0;

            Button btnValider = new Button() { Text = "Ajouter", Location = new System.Drawing.Point(150, 240), Size = new System.Drawing.Size(100, 35), BackColor = System.Drawing.Color.LightGreen };

            btnValider.Click += (s, ev) =>
            {
                if (cmbAnimal.SelectedValue == null || cmbVeto.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner un animal et un vétérinaire");
                    return;
                }

                string query = "INSERT INTO RendezVous (DateHeure, Motif, IdAnimal, IdVeterinaire, Statut) VALUES (@Date, @Motif, @IdAnimal, @IdVeto, @Statut)";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@Motif", txtMotif.Text);
                    cmd.Parameters.AddWithValue("@IdAnimal", cmbAnimal.SelectedValue);
                    cmd.Parameters.AddWithValue("@IdVeto", cmbVeto.SelectedValue);
                    cmd.Parameters.AddWithValue("@Statut", cmbStatut.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Rendez-vous ajouté !");
                form.Close();
                ChargerRendezVous();
            };

            form.Controls.AddRange(new Control[] { lblDate, dtpDate, lblMotif, txtMotif, lblAnimal, cmbAnimal, lblVeto, cmbVeto, lblStatut, cmbStatut, btnValider });
            form.ShowDialog();
        }

        
        private void btnRdvModifier_Click(object sender, EventArgs e)
        {
            if (dgvRendezVous.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous");
                return;
            }

            int id = Convert.ToInt32(dgvRendezVous.SelectedRows[0].Cells["Id"].Value);
            DateTime dateActuelle = Convert.ToDateTime(dgvRendezVous.SelectedRows[0].Cells["DateHeure"].Value);
            string motifActuel = dgvRendezVous.SelectedRows[0].Cells["Motif"].Value.ToString();
            string statutActuel = dgvRendezVous.SelectedRows[0].Cells["Statut"].Value.ToString();

            DataTable animaux = new DataTable();
            DataTable veterinaires = new DataTable();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapterAnimaux = new SqlDataAdapter("SELECT Id, Nom FROM Animaux", conn);
                adapterAnimaux.Fill(animaux);

                SqlDataAdapter adapterVeto = new SqlDataAdapter("SELECT Id, Nom FROM Utilisateurs WHERE Role = 'Veterinaire'", conn);
                adapterVeto.Fill(veterinaires);
            }

            Form form = new Form();
            form.Text = "Modifier un rendez-vous";
            form.Size = new System.Drawing.Size(480, 350);
            form.StartPosition = FormStartPosition.CenterParent;

            Label lblDate = new Label() { Text = "Date et heure :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(120, 25) };
            DateTimePicker dtpDate = new DateTimePicker() { Location = new System.Drawing.Point(150, 20), Size = new System.Drawing.Size(250, 25), Format = DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy HH:mm", ShowUpDown = true, Value = dateActuelle };

            Label lblMotif = new Label() { Text = "Motif :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(100, 25) };
            TextBox txtMotif = new TextBox() { Text = motifActuel, Location = new System.Drawing.Point(150, 60), Size = new System.Drawing.Size(250, 25) };

            Label lblStatut = new Label() { Text = "Statut :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 25) };
            ComboBox cmbStatut = new ComboBox() { Location = new System.Drawing.Point(150, 100), Size = new System.Drawing.Size(150, 25) };
            cmbStatut.Items.AddRange(new string[] { "Planifié", "Confirmé", "Annulé", "Terminé" });
            cmbStatut.SelectedItem = statutActuel;

            Button btnValider = new Button() { Text = "Modifier", Location = new System.Drawing.Point(150, 160), Size = new System.Drawing.Size(100, 35), BackColor = System.Drawing.Color.LightBlue };

            btnValider.Click += (s, ev) =>
            {
                string query = "UPDATE RendezVous SET DateHeure=@Date, Motif=@Motif, Statut=@Statut WHERE Id=@Id";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value);
                    cmd.Parameters.AddWithValue("@Motif", txtMotif.Text);
                    cmd.Parameters.AddWithValue("@Statut", cmbStatut.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Rendez-vous modifié !");
                form.Close();
                ChargerRendezVous();
            };

            form.Controls.AddRange(new Control[] { lblDate, dtpDate, lblMotif, txtMotif, lblStatut, cmbStatut, btnValider });
            form.ShowDialog();
        }

        
        private void btnRdvSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvRendezVous.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous");
                return;
            }

            int id = Convert.ToInt32(dgvRendezVous.SelectedRows[0].Cells["Id"].Value);
            string animal = dgvRendezVous.SelectedRows[0].Cells["Animal"].Value.ToString();

            DialogResult result = MessageBox.Show($"Supprimer le rendez-vous pour '{animal}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM RendezVous WHERE Id=@Id", conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Rendez-vous supprimé !");
                ChargerRendezVous();
            }
        }
       
        private void ChargerFactures()
        {
            string query = @"
        SELECT f.Id, a.Nom as Animal, p.NomComplet as Proprietaire, 
               f.Montant, f.DateFacture,
               CASE WHEN f.Paye = 1 THEN '✅ Payé' ELSE '⏳ Non payé' END as Statut
        FROM Factures f
        INNER JOIN Consultations c ON f.IdConsultation = c.Id
        INNER JOIN RendezVous r ON c.IdRendezVous = r.Id
        INNER JOIN Animaux a ON r.IdAnimal = a.Id
        INNER JOIN Proprietaires p ON a.IdProprietaire = p.Id
        ORDER BY f.DateFacture DESC";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvFactures.DataSource = table;

                if (dgvFactures.Columns["Id"] != null)
                    dgvFactures.Columns["Id"].Visible = false;

                dgvFactures.BackgroundColor = System.Drawing.Color.White;
                dgvFactures.BorderStyle = BorderStyle.None;
                dgvFactures.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvFactures.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
                dgvFactures.RowHeadersVisible = false;
                dgvFactures.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvFactures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvFactures.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);

               
                dgvFactures.EnableHeadersVisualStyles = false;
                dgvFactures.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
                dgvFactures.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgvFactures.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                dgvFactures.ColumnHeadersHeight = 40;
            }
        }

        
        private void btnActualiserFactures_Click(object sender, EventArgs e)
        {
            ChargerFactures();
        }

        
        private void btnMarquerPaye_Click(object sender, EventArgs e)
        {
            if (dgvFactures.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une facture", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idFacture = Convert.ToInt32(dgvFactures.SelectedRows[0].Cells["Id"].Value);
            string statutActuel = dgvFactures.SelectedRows[0].Cells["Statut"].Value.ToString();

            if (statutActuel.Contains("Payé"))
            {
                MessageBox.Show("Cette facture est déjà payée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Marquer cette facture comme payée ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Factures SET Paye = 1 WHERE Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", idFacture);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Facture marquée comme payée", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChargerFactures(); 
            }
        }

        private void ChargerFiltres()
        {
            
            DataTable animaux = new DataTable();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Nom FROM Animaux ORDER BY Nom", conn);
                adapter.Fill(animaux);
            }

            DataRow row = animaux.NewRow();
            row["Id"] = 0;
            row["Nom"] = "-- Tous les animaux --";
            animaux.Rows.InsertAt(row, 0);

            cmbFiltreAnimal.DisplayMember = "Nom";
            cmbFiltreAnimal.ValueMember = "Id";
            cmbFiltreAnimal.DataSource = animaux;
            cmbFiltreAnimal.SelectedIndex = 0;  

            
            cmbFiltreStatut.Items.Clear();
            cmbFiltreStatut.Items.Add("Tous");
            cmbFiltreStatut.Items.Add("Planifié");
            cmbFiltreStatut.Items.Add("Confirmé");
            cmbFiltreStatut.Items.Add("Annulé");
            cmbFiltreStatut.Items.Add("Terminé");
            cmbFiltreStatut.SelectedIndex = 0;

            
            dtpDateDebut.Checked = false;
            dtpDateFin.Checked = false;
        }
        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            dtpDateDebut.Checked = false;
            dtpDateFin.Checked = false;
            cmbFiltreAnimal.SelectedIndex = 0;
            cmbFiltreStatut.SelectedIndex = 0;
            ChargerRendezVous();  
        }
        private void btnExporterPDF_Click(object sender, EventArgs e)
        {
            if (dgvFactures.Rows.Count == 0)
            {
                MessageBox.Show("Aucune facture à exporter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF fichiers (*.pdf)|*.pdf";
            sfd.FileName = "Factures_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
            sfd.Title = "Exporter les factures en PDF";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 20, 20, 20, 20);
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    
                    iTextSharp.text.Paragraph titre = new iTextSharp.text.Paragraph("LISTE DES FACTURES");
                    titre.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titre);
                    doc.Add(new iTextSharp.text.Paragraph(" "));
                    doc.Add(new iTextSharp.text.Paragraph("Date d'export : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
                    doc.Add(new iTextSharp.text.Paragraph("Clinique Vétérinaire - Tous droits réservés"));
                    doc.Add(new iTextSharp.text.Paragraph(" "));
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    
                    PdfPTable table = new PdfPTable(5);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 1.5f, 2.5f, 2f, 1.5f, 1.5f });

                    
                    PdfPCell cell1 = new PdfPCell(new Phrase("Date"));
                    cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell1);

                    PdfPCell cell2 = new PdfPCell(new Phrase("Animal"));
                    cell2.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell2);

                    PdfPCell cell3 = new PdfPCell(new Phrase("Propriétaire"));
                    cell3.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell3);

                    PdfPCell cell4 = new PdfPCell(new Phrase("Montant (TND)"));
                    cell4.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell4);

                    PdfPCell cell5 = new PdfPCell(new Phrase("Statut"));
                    cell5.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell5);

                    
                    foreach (DataGridViewRow row in dgvFactures.Rows)
                    {
                        if (row.IsNewRow) continue;

                        table.AddCell(row.Cells["DateFacture"].Value?.ToString() ?? "");
                        table.AddCell(row.Cells["Animal"].Value?.ToString() ?? "");
                        table.AddCell(row.Cells["Proprietaire"].Value?.ToString() ?? "");
                        table.AddCell(row.Cells["Montant"].Value?.ToString() ?? "0");
                        table.AddCell(row.Cells["Statut"].Value?.ToString() ?? "");
                    }

                    doc.Add(table);
                    doc.Add(new iTextSharp.text.Paragraph(" "));
                    doc.Add(new iTextSharp.text.Paragraph("--- Fin du document ---"));

                    doc.Close();

                    MessageBox.Show($"✓ PDF exporté avec succès !\nEmplacement : {sfd.FileName}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'export : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}