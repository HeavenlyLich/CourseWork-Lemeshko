namespace CourseWork.forms
{
    partial class ShopForm
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
            label1 = new Label();
            dataGridViewProducts = new DataGridView();
            buttonAddToCart = new Button();
            buttonCheckout = new Button();
            ButtonBack = new Button();
            buttonDeleteFromCart = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            labelTotalCost = new Label();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Каталог Товарів";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(12, 27);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.Size = new Size(660, 208);
            dataGridViewProducts.TabIndex = 1;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Location = new Point(406, 406);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(182, 32);
            buttonAddToCart.TabIndex = 2;
            buttonAddToCart.Text = "Додати до кошика";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // buttonCheckout
            // 
            buttonCheckout.Location = new Point(606, 406);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(182, 32);
            buttonCheckout.TabIndex = 3;
            buttonCheckout.Text = "Оформити замовлення";
            buttonCheckout.UseVisualStyleBackColor = true;
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 406);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(182, 32);
            ButtonBack.TabIndex = 4;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // buttonDeleteFromCart
            // 
            buttonDeleteFromCart.Location = new Point(218, 406);
            buttonDeleteFromCart.Name = "buttonDeleteFromCart";
            buttonDeleteFromCart.Size = new Size(182, 32);
            buttonDeleteFromCart.TabIndex = 5;
            buttonDeleteFromCart.Text = "Видалити з кошика";
            buttonDeleteFromCart.UseVisualStyleBackColor = true;
            buttonDeleteFromCart.Click += buttonDeleteFromCart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 238);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Кошик";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, Quantity, TotalPrice });
            dataGridView1.Location = new Point(12, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(660, 144);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "ProductID";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            // 
            // labelTotalCost
            // 
            labelTotalCost.AutoSize = true;
            labelTotalCost.Location = new Point(555, 238);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(108, 15);
            labelTotalCost.TabIndex = 8;
            labelTotalCost.Text = "Загальна Вартість:";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(679, 260);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(69, 52);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Оновити";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUpdate);
            Controls.Add(labelTotalCost);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(buttonDeleteFromCart);
            Controls.Add(ButtonBack);
            Controls.Add(buttonCheckout);
            Controls.Add(buttonAddToCart);
            Controls.Add(dataGridViewProducts);
            Controls.Add(label1);
            Name = "ShopForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазин";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewProducts;
        private Button buttonAddToCart;
        private Button buttonCheckout;
        private Button ButtonBack;
        private Button buttonDeleteFromCart;
        private Label label2;
        private DataGridView dataGridView1;
        private Label labelTotalCost;
        private Button buttonUpdate;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TotalPrice;
    }
}