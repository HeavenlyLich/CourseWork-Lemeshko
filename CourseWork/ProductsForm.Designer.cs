namespace CourseWork.forms
{
    partial class ProductsForm
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
            dataGridView1 = new DataGridView();
            ButtonBack = new Button();
            buttonEdit = new Button();
            buttonCreate = new Button();
            buttonDelete = new Button();
            buttonConfirmE = new Button();
            buttonCheckStock = new Button();
            buttonCheckProducts = new Button();
            textBoxPtoductName = new TextBox();
            label2 = new Label();
            textBoxExpiryDate = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxProductID = new TextBox();
            label5 = new Label();
            textBoxPrice = new TextBox();
            label6 = new Label();
            textBoxQuantity = new TextBox();
            label7 = new Label();
            buttonConfirmC = new Button();
            comboBoxCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Продукція на складі:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(748, 173);
            dataGridView1.TabIndex = 1;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 396);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(182, 42);
            ButtonBack.TabIndex = 6;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(216, 396);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(109, 42);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Редагувати обране";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(331, 396);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(109, 42);
            buttonCreate.TabIndex = 8;
            buttonCreate.Text = "Створити новий запис";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(679, 396);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(109, 42);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Видалити запис";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonConfirmE
            // 
            buttonConfirmE.Location = new Point(458, 396);
            buttonConfirmE.Name = "buttonConfirmE";
            buttonConfirmE.Size = new Size(109, 42);
            buttonConfirmE.TabIndex = 10;
            buttonConfirmE.Text = "Підтвердити зміни";
            buttonConfirmE.UseVisualStyleBackColor = true;
            buttonConfirmE.Visible = false;
            buttonConfirmE.Click += buttonConfirmE_Click;
            // 
            // buttonCheckStock
            // 
            buttonCheckStock.Location = new Point(138, 12);
            buttonCheckStock.Name = "buttonCheckStock";
            buttonCheckStock.Size = new Size(165, 42);
            buttonCheckStock.TabIndex = 11;
            buttonCheckStock.Text = "Переглянути продукцію";
            buttonCheckStock.UseVisualStyleBackColor = true;
            buttonCheckStock.Click += buttonCheckStock_Click;
            // 
            // buttonCheckProducts
            // 
            buttonCheckProducts.Location = new Point(595, 12);
            buttonCheckProducts.Name = "buttonCheckProducts";
            buttonCheckProducts.Size = new Size(165, 42);
            buttonCheckProducts.TabIndex = 12;
            buttonCheckProducts.Text = "Переглянути категорії";
            buttonCheckProducts.UseVisualStyleBackColor = true;
            buttonCheckProducts.Click += buttonCheckProducts_Click;
            // 
            // textBoxPtoductName
            // 
            textBoxPtoductName.Location = new Point(20, 367);
            textBoxPtoductName.Name = "textBoxPtoductName";
            textBoxPtoductName.Size = new Size(112, 23);
            textBoxPtoductName.TabIndex = 13;
            textBoxPtoductName.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 349);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 14;
            label2.Text = "Назва продукціїї";
            label2.Visible = false;
            // 
            // textBoxExpiryDate
            // 
            textBoxExpiryDate.Location = new Point(138, 314);
            textBoxExpiryDate.Name = "textBoxExpiryDate";
            textBoxExpiryDate.Size = new Size(112, 23);
            textBoxExpiryDate.TabIndex = 15;
            textBoxExpiryDate.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 349);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 16;
            label3.Text = "Категорія";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 349);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 18;
            label4.Text = "Ціна";
            label4.Visible = false;
            // 
            // textBoxProductID
            // 
            textBoxProductID.Location = new Point(20, 314);
            textBoxProductID.Name = "textBoxProductID";
            textBoxProductID.Size = new Size(112, 23);
            textBoxProductID.TabIndex = 19;
            textBoxProductID.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 296);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 20;
            label5.Text = "Айді продукта";
            label5.Visible = false;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(256, 367);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(112, 23);
            textBoxPrice.TabIndex = 21;
            textBoxPrice.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 296);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 22;
            label6.Text = "Термін споживання";
            label6.Visible = false;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(256, 314);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(112, 23);
            textBoxQuantity.TabIndex = 23;
            textBoxQuantity.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(260, 296);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 24;
            label7.Text = "Кількість";
            label7.Visible = false;
            // 
            // buttonConfirmC
            // 
            buttonConfirmC.Location = new Point(458, 367);
            buttonConfirmC.Name = "buttonConfirmC";
            buttonConfirmC.Size = new Size(109, 42);
            buttonConfirmC.TabIndex = 25;
            buttonConfirmC.Text = "Підтвердити зміни";
            buttonConfirmC.UseVisualStyleBackColor = true;
            buttonConfirmC.Visible = false;
            buttonConfirmC.Click += buttonConfirmC_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Fruit", "Vegetable", "Dairy" });
            comboBoxCategory.Location = new Point(138, 367);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(112, 23);
            comboBoxCategory.TabIndex = 26;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxCategory);
            Controls.Add(buttonConfirmC);
            Controls.Add(label7);
            Controls.Add(textBoxQuantity);
            Controls.Add(label6);
            Controls.Add(textBoxPrice);
            Controls.Add(label5);
            Controls.Add(textBoxProductID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxExpiryDate);
            Controls.Add(label2);
            Controls.Add(textBoxPtoductName);
            Controls.Add(buttonCheckProducts);
            Controls.Add(buttonCheckStock);
            Controls.Add(buttonConfirmE);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCreate);
            Controls.Add(buttonEdit);
            Controls.Add(ButtonBack);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Продукція";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button ButtonBack;
        private Button buttonEdit;
        private Button buttonCreate;
        private Button buttonDelete;
        private Button buttonConfirmE;
        private Button buttonCheckStock;
        private Button buttonCheckProducts;
        private TextBox textBoxPtoductName;
        private Label label2;
        private TextBox textBoxExpiryDate;
        private Label label3;
        private Label label4;
        private TextBox textBoxProductID;
        private Label label5;
        private TextBox textBoxPrice;
        private Label label6;
        private TextBox textBoxQuantity;
        private Label label7;
        private Button buttonConfirmC;
        private ComboBox comboBoxCategory;
    }
}