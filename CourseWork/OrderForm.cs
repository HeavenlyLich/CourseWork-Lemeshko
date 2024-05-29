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

namespace CourseWork.forms
{
    public partial class OrderForm : Form
    {
        private MySqlConnection conn;
        private string userRole;
        private string username;

        public OrderForm(MySqlConnection connection, string user, string role)
        {
            InitializeComponent();
            conn = connection;
            userRole = role;
            username = user;

        }


        private void LoadOrders(string status)
        {
            try
            {
                string query = @"
            SELECT o.OrderID, o.OrderDate, o.OrderStatus, od.ProductID, od.Quantity, od.TotalPrice, od.Discount
            FROM orders o
            JOIN orderdetails od ON o.OrderID = od.OrderID";

                if (status != null)
                {
                    query += " WHERE o.OrderStatus = @status";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (status != null)
                {
                    cmd.Parameters.AddWithValue("@status", status);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.Rows.Clear(); // Очищення існуючих рядків

                foreach (DataRow row in table.Rows)
                {
                    int orderId = Convert.ToInt32(row["OrderID"]);
                    DateTime orderDate = Convert.ToDateTime(row["OrderDate"]);
                    string orderStatus = row["OrderStatus"].ToString();
                    int productId = Convert.ToInt32(row["ProductID"]);
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    float totalPrice = Convert.ToSingle(row["TotalPrice"]);
                    float discount = Convert.ToSingle(row["Discount"]);

                    dataGridView1.Rows.Add(orderId, orderDate, orderStatus, productId, quantity, totalPrice, discount);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (userRole == "Seller")
            {
                Helper.GoToMainSellerForm(this, conn, username, userRole);
            }
            else if (userRole == "Manager")
            {
                Helper.GoToMainManagerForm(this, conn, username, userRole);
            }
        }

        private void buttonOProcessing_Click(object sender, EventArgs e)
        {
            LoadOrders("Processing");
        }

        private void buttonOPending_Click(object sender, EventArgs e)
        {
            LoadOrders("Pending");
        }

        private void buttonOShipped_Click(object sender, EventArgs e)
        {
            LoadOrders("Shipped");
        }

        private void buttonOCompleted_Click(object sender, EventArgs e)
        {
            LoadOrders("Completed");
        }

        private void buttonOCancelled_Click(object sender, EventArgs e)
        {
            LoadOrders("Cancelled");
        }

        private void buttonOAll_Click(object sender, EventArgs e)
        {
            LoadOrders(null);
        }

        private void ChangeOrderStatus(int orderId, string newStatus)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "UPDATE orders SET OrderStatus = @status WHERE OrderID = @orderId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@orderId", orderId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Order status updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error updating order status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        private void UpdateOrderStatus(string newStatus)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int orderId = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);

                var result = MessageBox.Show($"Ви впевнені, що хочете змінити статус замовлення {orderId} на {newStatus}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ChangeOrderStatus(orderId, newStatus);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть замовлення для зміни статусу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonInProcessing_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Processing");
        }

        private void buttonInPending_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Pending");
        }

        private void buttonInShipped_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Shipped");
        }

        private void buttonInCompleted_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Completed");
        }

        private void buttonInCancelled_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Cancelled");
        }
    }
}
