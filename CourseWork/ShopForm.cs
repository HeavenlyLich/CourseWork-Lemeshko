using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ShopForm : Form
    {
        private MySqlConnection conn;
        private string username;
        private string userRole;
        private int userId;

        public ShopForm(MySqlConnection connection, string user, string role)
        {
            InitializeComponent();
            this.conn = connection;
            this.username = user;
            this.userRole = role;

            this.userId = GetUserIdByUsername(user); // Отримуємо userId за ім'ям користувача

            LoadProducts();

            if (userRole == "Guest")
            {
                buttonAddToCart.Click += (s, e) => MessageBox.Show("Будь ласка, зареєструйтеся, щоб додавати товари до кошика.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonDeleteFromCart.Click += (s, e) => MessageBox.Show("Будь ласка, зареєструйтеся, щоб видаляти товари з кошика.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonCheckout.Click += (s, e) => MessageBox.Show("Будь ласка, зареєструйтеся, щоб оформити замовлення.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void LoadProducts()
        {
            try
            {
                string query = @"
            SELECT p.ProductID, p.ProductName, p.Category, p.Price, SUM(ps.Quantity) AS TotalQuantity
            FROM products p
            JOIN product_stock ps ON p.ProductID = ps.ProductID
            GROUP BY p.ProductID, p.ProductName, p.Category, p.Price";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewProducts.DataSource = table;
                dataGridViewProducts.ReadOnly = true;
                dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                string productName = selectedRow.Cells["ProductName"].Value.ToString();
                float price = Convert.ToSingle(selectedRow.Cells["Price"].Value);

                // Перевірка, чи товар уже в кошику
                bool itemExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["ProductID"].Value) == productId)
                    {
                        int currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        row.Cells["Quantity"].Value = currentQuantity + 1;
                        row.Cells["TotalPrice"].Value = price * (currentQuantity + 1);
                        itemExists = true;
                        break;
                    }
                }

                // Якщо товару немає в кошику, додаємо новий рядок
                if (!itemExists)
                {
                    int quantity = 1; // Початкова кількість
                    float totalPrice = price * quantity;
                    dataGridView1.Rows.Add(productId, productName, quantity, totalPrice);
                }

                // Оновлення загальної вартості
                UpdateTotalCost();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть товар для додавання до кошика.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Helper.GoToMainClientForm(this, conn, username, userRole);
        }

        private void buttonDeleteFromCart_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }

                // Оновлення загальної вартості
                UpdateTotalCost();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть товар для видалення з кошика.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateTotalCost()
        {
            float totalCost = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalCost += Convert.ToSingle(row.Cells["TotalPrice"].Value);
            }

            labelTotalCost.Text = $"Загальна Вартість: {totalCost:C}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Increase")
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    float pricePerUnit = Convert.ToSingle(row.Cells["TotalPrice"].Value) / currentQuantity;
                    row.Cells["Quantity"].Value = currentQuantity + 1;
                    row.Cells["TotalPrice"].Value = pricePerUnit * (currentQuantity + 1);

                    UpdateTotalCost();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Decrease")
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    if (currentQuantity > 1)
                    {
                        float pricePerUnit = Convert.ToSingle(row.Cells["TotalPrice"].Value) / currentQuantity;
                        row.Cells["Quantity"].Value = currentQuantity - 1;
                        row.Cells["TotalPrice"].Value = pricePerUnit * (currentQuantity - 1);

                        UpdateTotalCost();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити продукт з кошика?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                            UpdateTotalCost();
                        }
                    }
                }
            }
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateCart();
        }

        private void UpdateCart()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Quantity"].Value != null && row.Cells["ProductID"].Value != null)
                {
                    int quantity;
                    if (int.TryParse(row.Cells["Quantity"].Value.ToString(), out quantity) && quantity > 0)
                    {
                        float productPrice = GetProductPriceById(Convert.ToInt32(row.Cells["ProductID"].Value));
                        row.Cells["TotalPrice"].Value = productPrice * quantity;
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, введіть дійсне значення кількості.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        row.Cells["Quantity"].Value = 1;  // Повертаємо до 1, якщо введене значення було недійсним
                        float productPrice = GetProductPriceById(Convert.ToInt32(row.Cells["ProductID"].Value));
                        row.Cells["TotalPrice"].Value = productPrice;
                    }
                }
            }
            UpdateTotalCost();
        }

        private float GetProductPriceById(int productId)
        {
            float price = 0;
            try
            {
                string query = "SELECT Price FROM products WHERE ProductID = @ProductID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                conn.Open();
                price = Convert.ToSingle(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving product price: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return price;
        }

        private int GetUserIdByUsername(string username)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            int userId = -1;
            try
            {
                string query = "SELECT UserID FROM users WHERE Username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving user ID: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return userId;
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Кошик порожній. Додайте товари до кошика перед оформленням замовлення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = GetUserIdByUsername(username);
            if (userId == -1)
            {
                MessageBox.Show("Помилка при отриманні UserID.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка, чи з'єднання відкрите
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            using (MySqlTransaction transaction = conn.BeginTransaction())
            {
                try
                {
                    // Обчислення загальної вартості замовлення
                    decimal orderTotalPrice = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        orderTotalPrice += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                    }

                    // Вставка нового замовлення
                    string insertOrderQuery = "INSERT INTO orders (UserID, OrderDate, OrderStatus, OrderPrice) VALUES (@UserID, @OrderDate, @OrderStatus, @OrderPrice)";
                    MySqlCommand cmd = new MySqlCommand(insertOrderQuery, conn, transaction);
                    cmd.Parameters.AddWithValue("@UserID", userId); // Поточний користувач
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@OrderStatus", "Processing");
                    cmd.Parameters.AddWithValue("@OrderPrice", orderTotalPrice);

                    cmd.ExecuteNonQuery();
                    long orderId = cmd.LastInsertedId;

                    // Вставка деталей замовлення
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        decimal totalPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value);

                        string insertOrderDetailsQuery = "INSERT INTO orderdetails (OrderID, ProductID, Quantity, TotalPrice, Discount) VALUES (@OrderID, @ProductID, @Quantity, @TotalPrice, @Discount)";
                        MySqlCommand detailsCmd = new MySqlCommand(insertOrderDetailsQuery, conn, transaction);
                        detailsCmd.Parameters.AddWithValue("@OrderID", orderId);
                        detailsCmd.Parameters.AddWithValue("@ProductID", productId);
                        detailsCmd.Parameters.AddWithValue("@Quantity", quantity);
                        detailsCmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        detailsCmd.Parameters.AddWithValue("@Discount", 0); // Припустимо, знижки немає

                        detailsCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Замовлення успішно оформлено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Очищення кошика після успішного замовлення
                    dataGridView1.Rows.Clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Помилка під час оформлення замовлення: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close(); // Закриваємо з'єднання після завершення операції
                }
            }
        }



    }
}

