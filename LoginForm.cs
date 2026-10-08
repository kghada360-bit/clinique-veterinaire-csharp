using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CliniqueVeterinaire
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            // === SUPPRIME InitializeComponent() car on crée tout en code ===
            // InitializeComponent();

            // === STYLE DE LA FENÊTRE ===
            this.Text = "🏥 Clinique Vétérinaire - Connexion";
            this.BackColor = Color.FromArgb(46, 125, 50); // Vert clinique
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Size = new Size(500, 500);

            // === PANNEAU BLANC CENTRAL ===
            Panel panelLogin = new Panel();
            panelLogin.BackColor = Color.White;
            panelLogin.Size = new Size(380, 350);
            panelLogin.Location = new Point(60, 50);
            panelLogin.BorderStyle = BorderStyle.FixedSingle;

            // === TITRE ===
            Label lblTitre = new Label();
            lblTitre.Text = "🏥 CLINIQUE VÉTÉRINAIRE";
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.ForeColor = Color.FromArgb(46, 125, 50);
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            lblTitre.Size = new Size(340, 40);
            lblTitre.Location = new Point(20, 20);

            // === SOUS-TITRE ===
            Label lblSousTitre = new Label();
            lblSousTitre.Text = "Veuillez saisir vos identifiants";
            lblSousTitre.Font = new Font("Segoe UI", 9F);
            lblSousTitre.ForeColor = Color.Gray;
            lblSousTitre.TextAlign = ContentAlignment.MiddleCenter;
            lblSousTitre.Size = new Size(340, 25);
            lblSousTitre.Location = new Point(20, 65);

            // === CHAMP EMAIL ===
            Label lblEmail = new Label();
            lblEmail.Text = "📧 Email :";
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(40, 110);
            lblEmail.Size = new Size(100, 25);

            txtEmail = new TextBox();
            txtEmail.Location = new Point(40, 135);
            txtEmail.Size = new Size(300, 25);
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;

            // === CHAMP MOT DE PASSE ===
            Label lblMdp = new Label();
            lblMdp.Text = "🔒 Mot de passe :";
            lblMdp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMdp.Location = new Point(40, 175);
            lblMdp.Size = new Size(150, 25);

            txtMotDePasse = new TextBox();
            txtMotDePasse.Location = new Point(40, 200);
            txtMotDePasse.Size = new Size(300, 25);
            txtMotDePasse.Font = new Font("Segoe UI", 10F);
            txtMotDePasse.PasswordChar = '*';
            txtMotDePasse.BorderStyle = BorderStyle.FixedSingle;

            // === BOUTON CONNEXION ===
            btnConnexion = new Button();
            btnConnexion.Text = "🔓 SE CONNECTER";
            btnConnexion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConnexion.BackColor = Color.FromArgb(46, 125, 50);
            btnConnexion.ForeColor = Color.White;
            btnConnexion.FlatStyle = FlatStyle.Flat;
            btnConnexion.FlatAppearance.BorderSize = 0;
            btnConnexion.Size = new Size(200, 45);
            btnConnexion.Location = new Point(90, 260);
            btnConnexion.Cursor = Cursors.Hand;
            btnConnexion.Click += btnConnexion_Click; // Relie l'événement

            // === PIED DE PAGE ===
            Label lblFooter = new Label();
            lblFooter.Text = "© 2026 Clinique Vétérinaire - Tous droits réservés";
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.White;
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            lblFooter.Size = new Size(460, 20);
            lblFooter.Location = new Point(20, 430);

            // === AJOUT DE TOUS LES CONTRÔLES ===
            panelLogin.Controls.AddRange(new Control[] {
                lblTitre, lblSousTitre,
                lblEmail, txtEmail,
                lblMdp, txtMotDePasse,
                btnConnexion
            });

            this.Controls.Add(panelLogin);
            this.Controls.Add(lblFooter);
        }

        // === MÉTHODE DE CONNEXION ===
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string motDePasse = txtMotDePasse.Text;

            string query = "SELECT Role FROM Utilisateurs WHERE Email=@Email AND MotDePasse=@Mdp";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Mdp", motDePasse);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString();
                    MessageBox.Show("Connexion réussie ! Rôle : " + role);

                    if (role == "Admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (role == "Secretaire")
                    {
                        SecretaireForm secretaireForm = new SecretaireForm();
                        secretaireForm.Show();
                        this.Hide();
                    }
                    else if (role == "Veterinaire")
                    {
                        int idVeto = 0;
                        string queryId = "SELECT Id FROM Utilisateurs WHERE Email=@Email";
                        using (SqlConnection conn2 = DatabaseHelper.GetConnection())
                        {
                            conn2.Open();
                            SqlCommand cmd2 = new SqlCommand(queryId, conn2);
                            cmd2.Parameters.AddWithValue("@Email", email);
                            idVeto = (int)cmd2.ExecuteScalar();
                        }
                        VeterinaireForm veterinaireForm = new VeterinaireForm(idVeto);
                        veterinaireForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Email ou mot de passe incorrect");
                }
            }
        }
    }
}