namespace CourseWork.forms
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            buttonOProcessing = new Button();
            buttonOPending = new Button();
            buttonOShipped = new Button();
            buttonOCompleted = new Button();
            buttonOCancelled = new Button();
            buttonOAll = new Button();
            buttonBack = new Button();
            dataGridView1 = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            label2 = new Label();
            buttonInProcessing = new Button();
            buttonInPending = new Button();
            buttonInShipped = new Button();
            buttonInCompleted = new Button();
            buttonInCancelled = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Закази:";
            // 
            // buttonOProcessing
            // 
            buttonOProcessing.Location = new Point(65, 9);
            buttonOProcessing.Name = "buttonOProcessing";
            buttonOProcessing.Size = new Size(99, 48);
            buttonOProcessing.TabIndex = 1;
            buttonOProcessing.Text = "В обробці";
            buttonOProcessing.UseVisualStyleBackColor = true;
            buttonOProcessing.Click += buttonOProcessing_Click;
            // 
            // buttonOPending
            // 
            buttonOPending.Location = new Point(170, 9);
            buttonOPending.Name = "buttonOPending";
            buttonOPending.Size = new Size(99, 48);
            buttonOPending.TabIndex = 2;
            buttonOPending.Text = "В очікуванні";
            buttonOPending.UseVisualStyleBackColor = true;
            buttonOPending.Click += buttonOPending_Click;
            // 
            // buttonOShipped
            // 
            buttonOShipped.Location = new Point(275, 9);
            buttonOShipped.Name = "buttonOShipped";
            buttonOShipped.Size = new Size(99, 48);
            buttonOShipped.TabIndex = 3;
            buttonOShipped.Text = "Відправлені";
            buttonOShipped.UseVisualStyleBackColor = true;
            buttonOShipped.Click += buttonOShipped_Click;
            // 
            // buttonOCompleted
            // 
            buttonOCompleted.Location = new Point(380, 9);
            buttonOCompleted.Name = "buttonOCompleted";
            buttonOCompleted.Size = new Size(99, 48);
            buttonOCompleted.TabIndex = 4;
            buttonOCompleted.Text = "Виконані";
            buttonOCompleted.UseVisualStyleBackColor = true;
            buttonOCompleted.Click += buttonOCompleted_Click;
            // 
            // buttonOCancelled
            // 
            buttonOCancelled.Location = new Point(485, 9);
            buttonOCancelled.Name = "buttonOCancelled";
            buttonOCancelled.Size = new Size(99, 48);
            buttonOCancelled.TabIndex = 5;
            buttonOCancelled.Text = "Скасовані";
            buttonOCancelled.UseVisualStyleBackColor = true;
            buttonOCancelled.Click += buttonOCancelled_Click;
            // 
            // buttonOAll
            // 
            buttonOAll.Location = new Point(590, 9);
            buttonOAll.Name = "buttonOAll";
            buttonOAll.Size = new Size(99, 48);
            buttonOAll.TabIndex = 6;
            buttonOAll.Text = "Всі";
            buttonOAll.UseVisualStyleBackColor = true;
            buttonOAll.Click += buttonOAll_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 390);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(99, 48);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Повернутися";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderID, OrderDate, OrderStatus, ProductID, Quantity, TotalPrice, Discount });
            dataGridView1.Location = new Point(12, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 229);
            dataGridView1.TabIndex = 8;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "Order ID";
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "Order Date";
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Resizable = DataGridViewTriState.True;
            OrderStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "Product ID";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            // 
            // Discount
            // 
            Discount.HeaderText = "Discount";
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 304);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 10;
            label2.Text = "Змінити статус на:";
            // 
            // buttonInProcessing
            // 
            buttonInProcessing.Location = new Point(93, 336);
            buttonInProcessing.Name = "buttonInProcessing";
            buttonInProcessing.Size = new Size(99, 48);
            buttonInProcessing.TabIndex = 11;
            buttonInProcessing.Text = "В обробці";
            buttonInProcessing.UseVisualStyleBackColor = true;
            buttonInProcessing.Click += buttonInProcessing_Click;
            // 
            // buttonInPending
            // 
            buttonInPending.Location = new Point(219, 336);
            buttonInPending.Name = "buttonInPending";
            buttonInPending.Size = new Size(99, 48);
            buttonInPending.TabIndex = 12;
            buttonInPending.Text = "В очікуванні";
            buttonInPending.UseVisualStyleBackColor = true;
            buttonInPending.Click += buttonInPending_Click;
            // 
            // buttonInShipped
            // 
            buttonInShipped.Location = new Point(358, 336);
            buttonInShipped.Name = "buttonInShipped";
            buttonInShipped.Size = new Size(99, 48);
            buttonInShipped.TabIndex = 13;
            buttonInShipped.Text = "Відправлено";
            buttonInShipped.UseVisualStyleBackColor = true;
            buttonInShipped.Click += buttonInShipped_Click;
            // 
            // buttonInCompleted
            // 
            buttonInCompleted.Location = new Point(496, 336);
            buttonInCompleted.Name = "buttonInCompleted";
            buttonInCompleted.Size = new Size(99, 48);
            buttonInCompleted.TabIndex = 14;
            buttonInCompleted.Text = "Виконано";
            buttonInCompleted.UseVisualStyleBackColor = true;
            buttonInCompleted.Click += buttonInCompleted_Click;
            // 
            // buttonInCancelled
            // 
            buttonInCancelled.Location = new Point(629, 336);
            buttonInCancelled.Name = "buttonInCancelled";
            buttonInCancelled.Size = new Size(99, 48);
            buttonInCancelled.TabIndex = 15;
            buttonInCancelled.Text = "Скасовано";
            buttonInCancelled.UseVisualStyleBackColor = true;
            buttonInCancelled.Click += buttonInCancelled_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInCancelled);
            Controls.Add(buttonInCompleted);
            Controls.Add(buttonInShipped);
            Controls.Add(buttonInPending);
            Controls.Add(buttonInProcessing);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBack);
            Controls.Add(buttonOAll);
            Controls.Add(buttonOCancelled);
            Controls.Add(buttonOCompleted);
            Controls.Add(buttonOShipped);
            Controls.Add(buttonOPending);
            Controls.Add(buttonOProcessing);
            Controls.Add(label1);
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню заказів";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonOProcessing;
        private Button buttonOPending;
        private Button buttonOShipped;
        private Button buttonOCompleted;
        private Button buttonOCancelled;
        private Button buttonOAll;
        private Button buttonBack;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn Discount;
        private Label label2;
        private Button buttonInProcessing;
        private Button buttonInPending;
        private Button buttonInShipped;
        private Button buttonInCompleted;
        private Button buttonInCancelled;
    }
}
