using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace RestoranApp
{
    public partial class WaiterForm : Form
    {
        public WaiterForm()
        {
            InitializeComponent();
            LoadTables();

            this.Width = 1079;
            this.Height = 742;

            // Formun sabit bir boyutta olmasını sağla
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Formu ekranın ortasında aç
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void LoadTables()
        {
            flowLayoutPanelTables.Controls.Clear();
            flowLayoutPanelTables.FlowDirection = FlowDirection.LeftToRight; // Butonları yatay yerleştir

            // Görsellerin bulunduğu klasör yolu
            string imagesPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\", "resim\\");

            using (var connection = new SQLiteConnection("Data Source=Database.db"))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Tables", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Id alanını güvenli şekilde al
                        int tableId = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0;

                        // Rezerve durumuna göre görsel seç
                        string imagePath = (bool)reader["IsReserved"]
                            ? imagesPath + "rezerved.png"
                            : imagesPath + "free.png";

                        // Buton oluştur ve özelliklerini ayarla
                        var button = new Button
                        {
                            Text = $"Masa {reader["TableNumber"]}",
                            TextAlign = ContentAlignment.BottomCenter,
                            BackgroundImage = Image.FromFile(imagePath),
                            BackgroundImageLayout = ImageLayout.Stretch,
                            Width = 150,
                            Height = 150,
                            Margin = new Padding(10), // Butonlar arasında boşluk ekleyin
                        };

                        // Click olayını ekle
                        button.Click += (s, e) =>
                        {
                            if (tableId > 0)
                            {
                                OpenTableDetails(tableId);
                            }
                            else
                            {
                                MessageBox.Show("Masa Id bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        };

                        // FlowLayoutPanel'e butonu ekle
                        flowLayoutPanelTables.Controls.Add(button);
                    }

                    // Çıkış Butonu
                    var buttonExit = new Button
                    {
                        Text = "Çıkış Yap",
                        ForeColor = Color.Black,
                        TextAlign = ContentAlignment.BottomCenter,
                        Width = 150,
                        Height = 150,
                        BackgroundImage = Image.FromFile(imagesPath + "exit.png"),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Margin = new Padding(10), // Butonlar arasında boşluk ekleyin
                    };

                    buttonExit.Click += (s, e) =>
                    {
                        // LoginForm'u göster ve WaiterForm'u kapat
                        var loginForm = new LoginForm();
                        loginForm.Show();
                        this.Close();
                    };

                    // Çıkış butonunu FlowLayoutPanel'e ekle
                    flowLayoutPanelTables.Controls.Add(buttonExit);
                }
            }

            // FlowLayoutPanel içeriğini ortalamak için
            flowLayoutPanelTables.AutoScroll = true; // İçeriğin kaydırılabilmesini sağla
            flowLayoutPanelTables.WrapContents = true; // İçeriği sararak yeni satırlara geçmesini sağla
        }

        private void OpenTableDetails(int tableId)
        {
            this.Hide(); // WaiterForm'u gizle
            var tableDetailsForm = new TableDetailsForm(tableId);
            tableDetailsForm.FormClosed += (s, e) =>
            {
                this.Show(); // TableDetailsForm kapandığında WaiterForm'u geri göster
                LoadTables(); // Tabloları yeniden yükle
            };
            tableDetailsForm.ShowDialog();
        }
    }
}
