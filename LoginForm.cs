using System;
using System.Data.SQLite;
using System.Windows.Controls;
using System.Windows.Forms;

namespace RestoranApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Width = 1079;
            this.Height = 742;

            // Formun sabit bir boyutta olmasını sağla
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Formu ekranın ortasında aç
            this.StartPosition = FormStartPosition.CenterScreen;

            CenterComponents();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (var connection = new SQLiteConnection("Data Source=Database.db"))
            {
                connection.Open();
                var command = new SQLiteCommand(
                    "SELECT Role FROM Users WHERE Username=@username AND Password=@password",
                    connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                var role = command.ExecuteScalar();

                if (role == null)
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre.");
                }
                else if (role.ToString() == "admin")
                {
                    new AdminForm().Show();
                    this.Hide();
                }
                else if (role.ToString() == "garson")
                {
                    new WaiterForm().Show();
                    this.Hide();
                }
            }
        }
        private void CenterComponents()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}