using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RestoranApp
{
    public partial class TableDetailsForm : Form
    {
        private int TableId;
        private DataTable cartTable;

        public TableDetailsForm(int tableId)
        {
            InitializeComponent();
            TableId = tableId;
            InitializeCart();
            LoadProducts();
            LoadOrders();
        }

        // Sepet için tablo yapısı oluşturuluyor
        private void InitializeCart()
        {
            cartTable = new DataTable();
            cartTable.Columns.Add("ProductName");
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("Price", typeof(double));
            cartTable.Columns.Add("Total", typeof(double), "Quantity * Price");

            dgvCart.DataSource = cartTable;
        }

        // Ürünleri listele
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

        // Siparişleri listele
        private void LoadOrders()
        {
            using (var connection = new SQLiteConnection("Data Source=Database.db"))
            {
                connection.Open();

                var command = new SQLiteCommand(
                    "SELECT ProductName, Quantity, TotalPrice, IsPaid FROM Orders WHERE TableId=@tableId AND IsPaid=0",
                    connection);
                command.Parameters.AddWithValue("@tableId", TableId);

                var adapter = new SQLiteDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                // DataGridView'in sütunlarını temizle
                dgvOrders.Columns.Clear();

                // Yeni veriyi bağla
                dgvOrders.DataSource = table;

                // Sütun özelliklerini ayarla
                dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        // Sepete ürün ekle
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dgvProducts.SelectedRows[0];
                var productName = selectedRow.Cells["ProductName"].Value.ToString();
                var price = Convert.ToDouble(selectedRow.Cells["Price"].Value);
                var quantity = (int)nudQuantity.Value;

                // Sepete eklenen ürünü kontrol et
                var existingRow = cartTable.AsEnumerable()
                                           .FirstOrDefault(row => row.Field<string>("ProductName") == productName);

                if (existingRow != null)
                {
                    // Mevcut ürüne miktar ekle
                    existingRow.SetField("Quantity", existingRow.Field<int>("Quantity") + quantity);
                }
                else
                {
                    // Yeni ürün ekle
                    var row = cartTable.NewRow();
                    row["ProductName"] = productName;
                    row["Quantity"] = quantity;
                    row["Price"] = price;
                    cartTable.Rows.Add(row);
                }

                dgvCart.DataSource = cartTable; // Sepeti güncelle
                nudQuantity.Value = 1; // Miktarı sıfırla
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sipariş oluştur
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Sepet boş. Lütfen ürün ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var connection = new SQLiteConnection("Data Source=Database.db"))
            {
                connection.Open();
                foreach (DataRow row in cartTable.Rows)
                {
                    var command = new SQLiteCommand(
                        "INSERT INTO Orders (TableId, ProductName, Quantity, TotalPrice, IsPaid) VALUES (@tableId, @productName, @quantity, @totalPrice, 0)",
                        connection);

                    command.Parameters.AddWithValue("@tableId", TableId);
                    command.Parameters.AddWithValue("@productName", row["ProductName"]);
                    command.Parameters.AddWithValue("@quantity", row["Quantity"]);
                    command.Parameters.AddWithValue("@totalPrice", row["Total"]);

                    command.ExecuteNonQuery();
                }

                // Masayı "rezervasyonlu" yap
                var updateTableCommand = new SQLiteCommand(
                    "UPDATE Tables SET IsReserved = 1 WHERE Id = @tableId",
                    connection);
                updateTableCommand.Parameters.AddWithValue("@tableId", TableId);
                updateTableCommand.ExecuteNonQuery();
            }

            // Sipariş sonrası sepeti temizle
            cartTable.Clear();
            dgvCart.DataSource = cartTable; // Sepeti güncelle
            LoadOrders();
            MessageBox.Show("Sipariş başarıyla eklendi ve masa rezerve edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Ödeme al
        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source=Database.db"))
            {
                connection.Open();
                var command = new SQLiteCommand(
                    "UPDATE Orders SET IsPaid = 1 WHERE TableId=@tableId AND IsPaid=0",
                    connection);

                command.Parameters.AddWithValue("@tableId", TableId);
                var rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Ödeme alındıktan sonra masanın rezervasyonunu kaldır
                    var updateTableCommand = new SQLiteCommand(
                        "UPDATE Tables SET IsReserved = 0 WHERE Id = @tableId",
                        connection);
                    updateTableCommand.Parameters.AddWithValue("@tableId", TableId);
                    updateTableCommand.ExecuteNonQuery();

                    MessageBox.Show("Ödeme alındı ve masa rezervasyonu kaldırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrders();
                }
                else
                {
                    MessageBox.Show("Ödenecek sipariş bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        //Sepetten Sil
        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                var selectedRowIndex = dgvCart.SelectedRows[0].Index;
                cartTable.Rows[selectedRowIndex].Delete(); // Satırı sil
            }
            else
            {
                MessageBox.Show("Lütfen sepetten bir ürün seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close(); // TableDetailsForm'u kapat
        }
    }
}
