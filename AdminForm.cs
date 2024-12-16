using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace RestoranApp
{
    public partial class AdminForm : Form
    {
        private CartesianChart cartesianChart;

        public AdminForm()
        {
            InitializeComponent();

            // CartesianChart'ı ElementHost içine yerleştirin
            cartesianChart = new CartesianChart();
            elementHost1.Child = cartesianChart;
            this.Width = 1079;
            this.Height = 742;

            // Formun sabit bir boyutta olmasını sağla
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Formu ekranın ortasında aç
            this.StartPosition = FormStartPosition.CenterScreen;


            LoadProducts();
            LoadDailyRevenueChart();
        }

        private void LoadProducts()
        {
            using (var connection = new SQLiteConnection("Data Source=Database.db"))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Products", connection);
                var adapter = new SQLiteDataAdapter(command);

                var table = new DataTable();
                adapter.Fill(table);

                dgvProducts.DataSource = table;
                dgvProducts.Columns["Id"].Visible = false; // ID sütununu gizle
                dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void LoadDailyRevenueChart()
        {
            using (var connection = new SQLiteConnection("Data Source=Database.db"))
            {
                connection.Open();
                var command = new SQLiteCommand(
                    "SELECT strftime('%Y-%m-%d', datetime('now')) AS Today, SUM(TotalPrice) AS Revenue FROM Orders WHERE IsPaid = 1",
                    connection);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    double revenue = Convert.ToDouble(reader["Revenue"] ?? 0);

                    // Grafik verilerini oluştur
                    var chartValues = new ChartValues<double> { revenue };
                    var series = new ColumnSeries
                    {
                        Title = "Günlük Ciro",
                        Values = chartValues
                    };

                    // Grafiği güncelle
                    cartesianChart.Series.Clear();
                    cartesianChart.Series.Add(series);

                    cartesianChart.AxisX.Clear();
                    cartesianChart.AxisX.Add(new Axis
                    {
                        Title = "Tarih",
                        Labels = new[] { reader["Today"].ToString() }
                    });

                    cartesianChart.AxisY.Clear();
                    cartesianChart.AxisY.Add(new Axis
                    {
                        Title = "Gelir",
                        LabelFormatter = value => $"₺{value:N2}"
                    });
                }
            }
        }

        // Yeni ürün ekleme
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source=Database.db"))
            {
                connection.Open();

                // Kullanıcıdan ürün adı ve fiyatı al
                string productName = txtProductName.Text.Trim();
                if (string.IsNullOrEmpty(productName))
                {
                    MessageBox.Show("Ürün adı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double price;
                if (!double.TryParse(txtProductPrice.Text, out price) || price <= 0)
                {
                    MessageBox.Show("Geçerli bir fiyat girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var command = new SQLiteCommand("INSERT INTO Products (ProductName, Price) VALUES (@name, @price)", connection);
                command.Parameters.AddWithValue("@name", productName);
                command.Parameters.AddWithValue("@price", price);
                command.ExecuteNonQuery();

                MessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts(); // Ürün listesini güncelle
                txtProductName.Clear();
                txtProductPrice.Clear();
            }
        }

        // Ürün fiyatını güncelleme
        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                using (var connection = new SQLiteConnection("Data Source=Database.db"))
                {
                    connection.Open();

                    var selectedRow = dgvProducts.SelectedRows[0];
                    int productId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    double newPrice;
                    if (!double.TryParse(txtProductPrice1.Text, out newPrice) || newPrice <= 0)
                    {
                        MessageBox.Show("Geçerli bir fiyat girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var command = new SQLiteCommand("UPDATE Products SET Price = @price WHERE Id = @id", connection);
                    command.Parameters.AddWithValue("@price", newPrice);
                    command.Parameters.AddWithValue("@id", productId);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Ürün fiyatı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts(); // Ürün listesini güncelle
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir ürün seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
