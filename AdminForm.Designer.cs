namespace RestoranApp
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.txtProductPrice = new MetroFramework.Controls.MetroTextBox();
            this.btnAddProduct = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtProductPrice1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(13, 378);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(717, 261);
            this.dgvProducts.TabIndex = 0;
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.White;
            this.elementHost1.Location = new System.Drawing.Point(13, 55);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(4);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(717, 250);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(739, 73);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(283, 28);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(739, 131);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(283, 28);
            this.txtProductPrice.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(739, 180);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(283, 74);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Ürün Ekle";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(739, 49);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Ürün Adı";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(739, 107);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 20);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Tutar";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(738, 359);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(283, 74);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Tutar Güncelle";
            this.metroButton1.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // txtProductPrice1
            // 
            this.txtProductPrice1.Location = new System.Drawing.Point(738, 310);
            this.txtProductPrice1.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductPrice1.Name = "txtProductPrice1";
            this.txtProductPrice1.Size = new System.Drawing.Size(283, 28);
            this.txtProductPrice1.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(738, 284);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Güncel Tutar";
            // 
            // exitButton
            // 
            this.exitButton.Highlight = true;
            this.exitButton.Location = new System.Drawing.Point(738, 559);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(283, 74);
            this.exitButton.Style = MetroFramework.MetroColorStyle.Red;
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Çıkış Yap";
            this.exitButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::RestoranApp.Properties.Resources.adminbackground1;
            this.ClientSize = new System.Drawing.Size(1061, 695);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductPrice1);
            this.Controls.Add(this.txtProductPrice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroTextBox txtProductPrice;
        private MetroFramework.Controls.MetroButton btnAddProduct;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtProductPrice1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton exitButton;
    }
}