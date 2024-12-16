namespace RestoranApp
{
    partial class TableDetailsForm
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
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(559, 66);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(492, 185);
            this.dgvCart.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(16, 66);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(517, 185);
            this.dgvProducts.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 23);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Ürünler";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(559, 23);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Sepet";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(229, 325);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(160, 22);
            this.nudQuantity.TabIndex = 3;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(119, 402);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(320, 51);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Sepete Ekle";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(16, 596);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(263, 51);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Siparişi Oluştur";
            this.metroButton1.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(406, 596);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(263, 51);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Ödeme Al";
            this.metroButton2.Click += new System.EventHandler(this.btnPayOrder_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(172, 327);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Adet";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(785, 596);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(263, 51);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Geri Dön";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(559, 354);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.Size = new System.Drawing.Size(492, 185);
            this.dgvOrders.TabIndex = 0;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(559, 327);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 20);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Siparişler";
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(728, 259);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(320, 51);
            this.metroButton4.TabIndex = 4;
            this.metroButton4.Text = "Sepetten Sil";
            this.metroButton4.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // TableDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestoranApp.Properties.Resources.yeni;
            this.ClientSize = new System.Drawing.Size(1061, 695);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.dgvCart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TableDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridView dgvProducts;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private MetroFramework.Controls.MetroButton btnAddToCart;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.DataGridView dgvOrders;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}