using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CourseWork.forms
{
    public partial class ProductsForm : Form
    {
        private MySqlConnection conn;
        private string userRole;
        private string username;
        private TextBox hiddenStockID = new TextBox { Visible = false };

        public ProductsForm(MySqlConnection connection, string user, string role)
        {
            InitializeComponent();
            conn = connection;
            userRole = role;
            username = user;
            this.Controls.Add(hiddenStockID); // Додаємо приховане поле до форми
        }

        private void LoadProducts()
        {
            try
            {
                string query = "SELECT ProductID, ProductName, Category, Price FROM products";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductStock()
        {
            try
            {
                string query = "SELECT StockID, ProductID, ExpiryDate, Quantity FROM product_stock";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading product stock: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (userRole == "Seller")
            {
                Helper.GoToMainSellerForm(this, conn, username, userRole);
            }
            else if (userRole == "Manager")
            {
                Helper.GoToMainManagerForm(this, conn, username, userRole);
            }
            else if (userRole == "Warehouse Clerk")
            {
                Helper.GoToMainWarehouseForm(this, conn, username, userRole);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                if (label5.Visible) // Виведення з product_stock
                {
                    textBoxProductID.Text = dataGridView1.Rows[selectedRowIndex].Cells["ProductID"].Value.ToString();
                    textBoxExpiryDate.Text = dataGridView1.Rows[selectedRowIndex].Cells["ExpiryDate"].Value.ToString();
                    textBoxQuantity.Text = dataGridView1.Rows[selectedRowIndex].Cells["Quantity"].Value.ToString();
                    hiddenStockID.Text = dataGridView1.Rows[selectedRowIndex].Cells["StockID"].Value.ToString(); // Зберігаємо StockID в приховане поле
                }
                else // Виведення з products
                {
                    textBoxPtoductName.Text = dataGridView1.Rows[selectedRowIndex].Cells["ProductName"].Value.ToString();
                    comboBoxCategory.Text = dataGridView1.Rows[selectedRowIndex].Cells["Category"].Value.ToString();
                    textBoxPrice.Text = dataGridView1.Rows[selectedRowIndex].Cells["Price"].Value.ToString();
                }

                buttonConfirmC.Visible = false;
                buttonConfirmE.Visible = true;
            }
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // Очистка полів
            textBoxProductID.Text = textBoxExpiryDate.Text = textBoxQuantity.Text = string.Empty;
            textBoxPtoductName.Text = comboBoxCategory.Text = textBoxPrice.Text = string.Empty;
            comboBoxCategory.SelectedIndex = -1;

            MessageBox.Show("Після введення данних в текстові поля, натисність на кнопку \"Підтвердити зміни\".", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

            buttonConfirmC.Visible = true;
            buttonConfirmE.Visible = false;
        }


        private void buttonConfirmE_Click(object sender, EventArgs e)
        {
            if (label5.Visible) // product_stock
            {
                if (string.IsNullOrEmpty(textBoxProductID.Text) || string.IsNullOrEmpty(textBoxExpiryDate.Text) || string.IsNullOrEmpty(textBoxQuantity.Text))
                {
                    MessageBox.Show("Заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Перетворення дати в формат YYYY-MM-DD
                if (!DateTime.TryParseExact(textBoxExpiryDate.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime expiryDate))
                {
                    MessageBox.Show("Неправильний формат дати. Введіть дату у форматі DD.MM.YYYY.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int originalStockID = Convert.ToInt32(hiddenStockID.Text); // Використання StockID для точної ідентифікації запису

                string query = "UPDATE product_stock SET ProductID = @ProductID, ExpiryDate = @ExpiryDate, Quantity = @Quantity WHERE StockID = @OriginalStockID";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", textBoxProductID.Text);
                    cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate.ToString("yyyy-MM-dd")); // Використання формату YYYY-MM-DD
                    cmd.Parameters.AddWithValue("@Quantity", textBoxQuantity.Text);
                    cmd.Parameters.AddWithValue("@OriginalStockID", originalStockID); // Використання StockID для точної ідентифікації запису

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadProductStock();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else // products
            {
                if (string.IsNullOrEmpty(textBoxPtoductName.Text) || string.IsNullOrEmpty(comboBoxCategory.Text) || string.IsNullOrEmpty(textBoxPrice.Text))
                {
                    MessageBox.Show("Заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int originalProductID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ProductID"].Value);

                string query = "UPDATE products SET ProductName = @ProductName, Category = @Category, Price = @Price WHERE ProductID = @OriginalProductID";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductName", textBoxPtoductName.Text);
                    cmd.Parameters.AddWithValue("@Category", comboBoxCategory.Text);
                    cmd.Parameters.AddWithValue("@Price", textBoxPrice.Text);
                    cmd.Parameters.AddWithValue("@OriginalProductID", originalProductID);

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadProducts();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int productId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ProductID"].Value);

                string query = label5.Visible ? "DELETE FROM product_stock WHERE ProductID = @ProductID"
                                              : "DELETE FROM products WHERE ProductID = @ProductID";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", productId);

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.Rows.RemoveAt(selectedRowIndex);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }


        private void buttonCheckStock_Click(object sender, EventArgs e)
        {
            LoadProductStock();
            label5.Visible = label6.Visible = label7.Visible = true;
            textBoxProductID.Visible = textBoxExpiryDate.Visible = textBoxQuantity.Visible = true;

            label2.Visible = label3.Visible = label4.Visible = false;
            textBoxPtoductName.Visible = comboBoxCategory.Visible = textBoxPrice.Visible = false;

            // Очистка полів
            textBoxProductID.Text = textBoxExpiryDate.Text = textBoxQuantity.Text = string.Empty;

            buttonConfirmC.Visible = false;
            buttonConfirmE.Visible = false;
        }


        private void buttonCheckProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
            label5.Visible = label6.Visible = label7.Visible = false;
            textBoxProductID.Visible = textBoxExpiryDate.Visible = textBoxQuantity.Visible = false;

            label2.Visible = label3.Visible = label4.Visible = true;
            textBoxPtoductName.Visible = comboBoxCategory.Visible = textBoxPrice.Visible = true;

            // Очистка полів
            textBoxPtoductName.Text = comboBoxCategory.Text = textBoxPrice.Text = string.Empty;
            comboBoxCategory.SelectedIndex = -1;

            buttonConfirmC.Visible = false;
            buttonConfirmE.Visible = false;
        }


        private void buttonConfirmC_Click(object sender, EventArgs e)
        {
            if (label5.Visible) // product_stock
            {
                if (string.IsNullOrEmpty(textBoxProductID.Text) || string.IsNullOrEmpty(textBoxExpiryDate.Text) || string.IsNullOrEmpty(textBoxQuantity.Text))
                {
                    MessageBox.Show("Заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Перетворення дати в формат YYYY-MM-DD
                if (!DateTime.TryParseExact(textBoxExpiryDate.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime expiryDate))
                {
                    MessageBox.Show("Неправильний формат дати. Введіть дату у форматі DD.MM.YYYY.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO product_stock (ProductID, ExpiryDate, Quantity) VALUES (@ProductID, @ExpiryDate, @Quantity)";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", textBoxProductID.Text);
                    cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate.ToString("yyyy-MM-dd")); // Використання формату YYYY-MM-DD
                    cmd.Parameters.AddWithValue("@Quantity", textBoxQuantity.Text);

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadProductStock();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error adding record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else // products
            {
                if (string.IsNullOrEmpty(textBoxPtoductName.Text) || string.IsNullOrEmpty(comboBoxCategory.Text) || string.IsNullOrEmpty(textBoxPrice.Text))
                {
                    MessageBox.Show("Заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO products (ProductName, Category, Price) VALUES (@ProductName, @Category, @Price)";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductName", textBoxPtoductName.Text);
                    cmd.Parameters.AddWithValue("@Category", comboBoxCategory.Text);
                    cmd.Parameters.AddWithValue("@Price", textBoxPrice.Text);

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadProducts();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error adding record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}
