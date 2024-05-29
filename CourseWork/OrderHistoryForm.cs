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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CourseWork.forms
{
    public partial class OrderHistoryForm : Form
    {
        private MySqlConnection conn;
        private string userRole;
        private string username;

        public OrderHistoryForm(MySqlConnection connection, string user, string role)
        {
            InitializeComponent();
            conn = connection;
            userRole = role;
            username = user;
            LoadOrderHistory();
        }
        private void LoadOrderHistory()
        {
            try
            {
                string query = @"
            SELECT o.OrderID, o.OrderDate, o.OrderStatus, o.OrderPrice
            FROM orders o
            WHERE o.UserID = (SELECT UserID FROM users WHERE Username = @username)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewHistory.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading order history: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            Helper.GoToMainClientForm(this, conn, username, userRole);
        }
    }
}
