using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CliniqueVeterinaire
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

         
            this.Text = "👑 Administration - Clinique Vétérinaire";
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);

           
            tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            tabControl1.ItemSize = new System.Drawing.Size(150, 45);
            tabControl1.Padding = new System.Drawing.Point(15, 5);

           
            StyleDataGridView(dgvUtilisateurs);
            StyleDataGridView(dgvMedicaments);
            StyleDataGridView(dgvAlertes);

            btnAjouter.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            btnModifier.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            btnSupprimer.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            btnActualiser.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);

            btnMedocAjouter.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            btnMedocModifier.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            btnMedocSupprimer.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            btnMedocActualiser.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);

            btnRafraichirStats.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);

            foreach (Button btn in new Button[] { btnAjouter, btnModifier, btnSupprimer, btnActualiser,
                                          btnMedocAjouter, btnMedocModifier, btnMedocSupprimer, btnMedocActualiser,
                                          btnRafraichirStats })
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

            btnAjouter.Text = "➕ Ajouter";
            btnModifier.Text = "✏️ Modifier";
            btnSupprimer.Text = "🗑️ Supprimer";
            btnActualiser.Text = "🔄 Actualiser";
            btnMedocAjouter.Text = "➕ Ajouter";
            btnMedocModifier.Text = "✏️ Modifier";
            btnMedocSupprimer.Text = "🗑️ Supprimer";
            btnMedocActualiser.Text = "🔄 Actualiser";
            btnRafraichirStats.Text = "🔄 Rafraîchir";


            ChargerUtilisateurs();
            ChargerMedicaments();
            ChargerStats();
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

        private void ChargerUtilisateurs()
        {
   
            DataGridView dgv = tabUtilisateurs.Controls.OfType<DataGridView>().FirstOrDefault();
            if (dgv == null) return;

            string query = "SELECT Id, Nom, Email, Role FROM Utilisateurs";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv.DataSource = table;
                if (dgvUtilisateurs.Columns["Id"] != null)
                {
                    dgvUtilisateurs.Columns["Id"].Visible = false;
                }
            }
        }

       
        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabUtilisateurs;
            ChargerUtilisateurs();
        }

       
        private void médicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabMedicaments;
        }

        
        private void tableauDeBordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabDashboard;
        }

       
        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clinique Vétérinaire\nVersion 1.0\n© 2026", "À propos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
        }

        private void btnActualiser_Click_1(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Form formAjout = new Form();
            formAjout.Text = "Ajouter un utilisateur";
            formAjout.Size = new System.Drawing.Size(400, 280);
            formAjout.StartPosition = FormStartPosition.CenterParent;
            formAjout.BackColor = System.Drawing.Color.White;

            
            Label lblNom = new Label() { Text = "Nom :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(80, 25) };
            TextBox txtNom = new TextBox() { Location = new System.Drawing.Point(120, 20), Size = new System.Drawing.Size(230, 25) };

            
            Label lblEmail = new Label() { Text = "Email :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(80, 25) };
            TextBox txtEmail = new TextBox() { Location = new System.Drawing.Point(120, 60), Size = new System.Drawing.Size(230, 25) };

            
            Label lblMdp = new Label() { Text = "Mot de passe :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 25) };
            TextBox txtMdp = new TextBox() { Location = new System.Drawing.Point(120, 100), Size = new System.Drawing.Size(230, 25), PasswordChar = '*' };

            
            Label lblRole = new Label() { Text = "Rôle :", Location = new System.Drawing.Point(20, 140), Size = new System.Drawing.Size(80, 25) };
            ComboBox cmbRole = new ComboBox() { Location = new System.Drawing.Point(120, 140), Size = new System.Drawing.Size(150, 25) };
            cmbRole.Items.AddRange(new string[] { "Admin", "Secretaire", "Veterinaire" });
            cmbRole.SelectedIndex = 0;

            
            Button btnValider = new Button() { Text = "Ajouter", Location = new System.Drawing.Point(120, 190), Size = new System.Drawing.Size(100, 30), BackColor = System.Drawing.Color.LightGreen };

            btnValider.Click += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtMdp.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                    return;
                }

                string query = "INSERT INTO Utilisateurs (Nom, Email, MotDePasse, Role) VALUES (@Nom, @Email, @Mdp, @Role)";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Mdp", txtMdp.Text);
                    cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Utilisateur ajouté !");
                formAjout.Close();
                ChargerUtilisateurs();
            };

            formAjout.Controls.AddRange(new Control[] { lblNom, txtNom, lblEmail, txtEmail, lblMdp, txtMdp, lblRole, cmbRole, btnValider });
            formAjout.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
            if (dgvUtilisateurs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            int id = Convert.ToInt32(dgvUtilisateurs.SelectedRows[0].Cells["Id"].Value);
            string nom = dgvUtilisateurs.SelectedRows[0].Cells["Nom"].Value.ToString();

            
            DialogResult result = MessageBox.Show($"Supprimer l'utilisateur '{nom}' ?\n\nCette action est irréversible.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Utilisateurs WHERE Id = @Id";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    int lignes = cmd.ExecuteNonQuery();

                    if (lignes > 0)
                    {
                        MessageBox.Show("✓ Utilisateur supprimé !");
                        ChargerUtilisateurs(); 
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression");
                    }
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            
            if (dgvUtilisateurs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           
            int id = Convert.ToInt32(dgvUtilisateurs.SelectedRows[0].Cells["Id"].Value);
            string nomActuel = dgvUtilisateurs.SelectedRows[0].Cells["Nom"].Value.ToString();
            string emailActuel = dgvUtilisateurs.SelectedRows[0].Cells["Email"].Value.ToString();
            string roleActuel = dgvUtilisateurs.SelectedRows[0].Cells["Role"].Value.ToString();

            
            Form formModif = new Form();
            formModif.Text = "Modifier un utilisateur";
            formModif.Size = new System.Drawing.Size(420, 320);
            formModif.StartPosition = FormStartPosition.CenterParent;

            
            Label lblNom = new Label() { Text = "Nom :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(80, 25) };
            TextBox txtNom = new TextBox() { Text = nomActuel, Location = new System.Drawing.Point(120, 20), Size = new System.Drawing.Size(250, 25) };

           
            Label lblEmail = new Label() { Text = "Email :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(80, 25) };
            TextBox txtEmail = new TextBox() { Text = emailActuel, Location = new System.Drawing.Point(120, 60), Size = new System.Drawing.Size(250, 25) };

           
            Label lblMdp = new Label() { Text = "Nouveau mot de passe :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(140, 25) };
            TextBox txtMdp = new TextBox() { Location = new System.Drawing.Point(170, 100), Size = new System.Drawing.Size(200, 25), PasswordChar = '*' };
            Label lblInfo = new Label() { Text = "(laisser vide pour ne pas changer)", Location = new System.Drawing.Point(170, 125), Size = new System.Drawing.Size(180, 20), Font = new System.Drawing.Font("Microsoft Sans Serif", 7F) };

            
            Label lblRole = new Label() { Text = "Rôle :", Location = new System.Drawing.Point(20, 155), Size = new System.Drawing.Size(80, 25) };
            ComboBox cmbRole = new ComboBox() { Location = new System.Drawing.Point(120, 155), Size = new System.Drawing.Size(150, 25) };
            cmbRole.Items.AddRange(new string[] { "Admin", "Secretaire", "Veterinaire" });
            cmbRole.SelectedItem = roleActuel;

            
            Button btnValider = new Button() { Text = "Enregistrer", Location = new System.Drawing.Point(120, 210), Size = new System.Drawing.Size(100, 35), BackColor = System.Drawing.Color.LightBlue };

            btnValider.Click += (s, ev) =>
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd;

                    if (string.IsNullOrWhiteSpace(txtMdp.Text))
                    {
                       
                        string query = "UPDATE Utilisateurs SET Nom = @Nom, Email = @Email, Role = @Role WHERE Id = @Id";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());
                    }
                    else
                    {
                        
                        string query = "UPDATE Utilisateurs SET Nom = @Nom, Email = @Email, MotDePasse = @Mdp, Role = @Role WHERE Id = @Id";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Mdp", txtMdp.Text);
                        cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());
                    }
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Utilisateur modifié !");
                formModif.Close();
                ChargerUtilisateurs();
            };

            formModif.Controls.AddRange(new Control[] { lblNom, txtNom, lblEmail, txtEmail, lblMdp, txtMdp, lblInfo, lblRole, cmbRole, btnValider });
            formModif.ShowDialog();
        }

        private void btnMedocActualiser_Click(object sender, EventArgs e)
        {
            ChargerMedicaments();
        }

        private void btnMedocAjouter_Click(object sender, EventArgs e)
        {
            Form formAjout = new Form();
            formAjout.Text = "Ajouter un médicament";
            formAjout.Size = new System.Drawing.Size(400, 250);
            formAjout.StartPosition = FormStartPosition.CenterParent;
            formAjout.BackColor = System.Drawing.Color.White;

            
            Label lblNom = new Label() { Text = "Nom :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(80, 25) };
            TextBox txtNom = new TextBox() { Location = new System.Drawing.Point(120, 20), Size = new System.Drawing.Size(230, 25) };

            
            Label lblStock = new Label() { Text = "Stock :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(80, 25) };
            NumericUpDown numStock = new NumericUpDown() { Location = new System.Drawing.Point(120, 60), Size = new System.Drawing.Size(100, 25), Minimum = 0, Maximum = 1000 };

            
            Label lblExp = new Label() { Text = "Expiration :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 25) };
            DateTimePicker dtpExp = new DateTimePicker() { Location = new System.Drawing.Point(120, 100), Size = new System.Drawing.Size(150, 25), Format = DateTimePickerFormat.Short };

            
            Button btnValider = new Button() { Text = "Ajouter", Location = new System.Drawing.Point(120, 160), Size = new System.Drawing.Size(100, 35), BackColor = System.Drawing.Color.LightGreen };

            btnValider.Click += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtNom.Text))
                {
                    MessageBox.Show("Veuillez entrer un nom");
                    return;
                }

                string query = "INSERT INTO Medicaments (Nom, StockQuantite, DateExpiration) VALUES (@Nom, @Stock, @Exp)";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@Stock", numStock.Value);
                    cmd.Parameters.AddWithValue("@Exp", dtpExp.Value);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Médicament ajouté !");
                formAjout.Close();
                ChargerMedicaments();
            };

            formAjout.Controls.AddRange(new Control[] { lblNom, txtNom, lblStock, numStock, lblExp, dtpExp, btnValider });
            formAjout.ShowDialog();
        }

        private void btnMedocModifier_Click(object sender, EventArgs e)
        {
            if (dgvMedicaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un médicament");
                return;
            }

            int id = Convert.ToInt32(dgvMedicaments.SelectedRows[0].Cells["Id"].Value);
            string nomActuel = dgvMedicaments.SelectedRows[0].Cells["Nom"].Value.ToString();
            int stockActuel = Convert.ToInt32(dgvMedicaments.SelectedRows[0].Cells["StockQuantite"].Value);
            DateTime expActuelle = Convert.ToDateTime(dgvMedicaments.SelectedRows[0].Cells["DateExpiration"].Value);

            Form formModif = new Form();
            formModif.Text = "Modifier un médicament";
            formModif.Size = new System.Drawing.Size(400, 270);
            formModif.StartPosition = FormStartPosition.CenterParent;
            formModif.BackColor = System.Drawing.Color.White;

            
            Label lblNom = new Label() { Text = "Nom :", Location = new System.Drawing.Point(20, 20), Size = new System.Drawing.Size(80, 25) };
            TextBox txtNom = new TextBox() { Text = nomActuel, Location = new System.Drawing.Point(120, 20), Size = new System.Drawing.Size(230, 25) };

            Label lblStock = new Label() { Text = "Stock :", Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(80, 25) };
            NumericUpDown numStock = new NumericUpDown() { Location = new System.Drawing.Point(120, 60), Size = new System.Drawing.Size(100, 25), Minimum = 0, Maximum = 1000, Value = stockActuel };

           
            Label lblExp = new Label() { Text = "Expiration :", Location = new System.Drawing.Point(20, 100), Size = new System.Drawing.Size(100, 25) };
            DateTimePicker dtpExp = new DateTimePicker() { Location = new System.Drawing.Point(120, 100), Size = new System.Drawing.Size(150, 25), Format = DateTimePickerFormat.Short, Value = expActuelle };

            
            Button btnValider = new Button() { Text = "Modifier", Location = new System.Drawing.Point(120, 160), Size = new System.Drawing.Size(100, 35), BackColor = System.Drawing.Color.LightBlue };

            btnValider.Click += (s, ev) =>
            {
                string query = "UPDATE Medicaments SET Nom=@Nom, StockQuantite=@Stock, DateExpiration=@Exp WHERE Id=@Id";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@Stock", numStock.Value);
                    cmd.Parameters.AddWithValue("@Exp", dtpExp.Value);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Médicament modifié !");
                formModif.Close();
                ChargerMedicaments();
            };

            formModif.Controls.AddRange(new Control[] { lblNom, txtNom, lblStock, numStock, lblExp, dtpExp, btnValider });
            formModif.ShowDialog();
        }

        private void btnMedocSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvMedicaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un médicament");
                return;
            }

            int id = Convert.ToInt32(dgvMedicaments.SelectedRows[0].Cells["Id"].Value);
            string nom = dgvMedicaments.SelectedRows[0].Cells["Nom"].Value.ToString();

            DialogResult result = MessageBox.Show($"Supprimer '{nom}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Medicaments WHERE Id=@Id";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Médicament supprimé !");
                ChargerMedicaments();
            }
        }

        private void ChargerMedicaments()
        {
            string query = "SELECT Id, Nom, StockQuantite, DateExpiration FROM Medicaments";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvMedicaments.DataSource = table;

                
                if (dgvMedicaments.Columns["Id"] != null)
                {
                    dgvMedicaments.Columns["Id"].Visible = false;
                }
            }
        }
        private void ChargerStats()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                   
                    SqlCommand cmdUtilisateurs = new SqlCommand("SELECT COUNT(*) FROM Utilisateurs", conn);
                    int nbUtilisateurs = (int)cmdUtilisateurs.ExecuteScalar();
                    lblNbUtilisateurs.Text = "👥 Nombre d'utilisateurs : " + nbUtilisateurs;

                   
                    SqlCommand cmdMedicaments = new SqlCommand("SELECT COUNT(*) FROM Medicaments", conn);
                    int nbMedicaments = (int)cmdMedicaments.ExecuteScalar();
                    lblNbMedicaments.Text = "💊 Nombre de médicaments : " + nbMedicaments;

                    
                    SqlCommand cmdStock = new SqlCommand("SELECT SUM(StockQuantite) FROM Medicaments", conn);
                    object stockResult = cmdStock.ExecuteScalar();
                    int stockTotal = (stockResult == DBNull.Value) ? 0 : Convert.ToInt32(stockResult);
                    lblStockTotal.Text = "📦 Stock total : " + stockTotal + " unités";

                   
                    SqlCommand cmdCA = new SqlCommand("SELECT SUM(Montant) FROM Factures WHERE Paye = 1", conn);
                    object caResult = cmdCA.ExecuteScalar();
                    decimal caTotal = (caResult == DBNull.Value) ? 0 : Convert.ToDecimal(caResult);
                    lblChiffreAffaires.Text = $"💰 Chiffre d'affaires total : {caTotal:0.00} TND";

                   
                    string queryAlertes = @"
                SELECT Nom, StockQuantite, DateExpiration,
                    CASE 
                        WHEN StockQuantite < 10 THEN '⚠️ Stock faible'
                        WHEN DateExpiration <= DATEADD(day, 30, GETDATE()) THEN '⚠️ Expiration proche'
                        ELSE 'OK'
                    END as Alerte
                FROM Medicaments
                WHERE StockQuantite < 10 OR DateExpiration <= DATEADD(day, 30, GETDATE())";

                    SqlDataAdapter adapter = new SqlDataAdapter(queryAlertes, conn);
                    DataTable tableAlertes = new DataTable();
                    adapter.Fill(tableAlertes);
                    dgvAlertes.DataSource = tableAlertes;

                    
                    if (dgvAlertes.Columns.Count > 0)
                    {
                        dgvAlertes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des statistiques : " + ex.Message);
            }
        }

        private void btnRafraichirStats_Click(object sender, EventArgs e)
        {
            ChargerStats();
        }

        private void CalculerRevenus(DateTime dateDebut, DateTime dateFin)
        {
            string query = @"
        SELECT SUM(Montant) as Total
        FROM Factures f
        INNER JOIN Consultations c ON f.IdConsultation = c.Id
        WHERE f.DateFacture >= @DateDebut AND f.DateFacture <= @DateFin";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DateDebut", dateDebut);
                cmd.Parameters.AddWithValue("@DateFin", dateFin.AddDays(1));

                object result = cmd.ExecuteScalar();
                decimal total = (result == DBNull.Value) ? 0 : Convert.ToDecimal(result);

                lblRevenusTotal.Text = $"💰 Total : {total:0.00} TND";

                if (total > 0)
                    lblRevenusTotal.ForeColor = System.Drawing.Color.Green;
                else
                    lblRevenusTotal.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void btnCalculerRevenus_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = dtpRevenusDebut.Value;
            DateTime dateFin = dtpRevenusFin.Value;

            if (dateDebut > dateFin)
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CalculerRevenus(dateDebut, dateFin);
        }
        private void btnMoisEnCours_Click(object sender, EventArgs e)
        {
            DateTime debutMois = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime finMois = debutMois.AddMonths(1).AddDays(-1);

            dtpRevenusDebut.Value = debutMois;
            dtpRevenusFin.Value = finMois;

            CalculerRevenus(debutMois, finMois);
        }
    }
}