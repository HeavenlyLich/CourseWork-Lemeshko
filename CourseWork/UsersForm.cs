using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class UsersForm : Form
    {
        private MySqlConnection conn;
        private string userRole;
        private string username;
        string connectionString = "your_connection_string_here";


        public UsersForm(MySqlConnection connection, string user, string role)
        {
            InitializeComponent();
            conn = connection;
            userRole = role;
            username = user;
        }

        private void ExecuteQuery(string query)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error executing query: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Helper.GoToMainManagerForm(this, conn, username, userRole);
        }

        private void buttonSelectUsers_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users";
            ExecuteQuery(query);

            buttonGiveRClient.Visible = true;
            buttonGiveRWC.Visible = true;
            buttonGiveRSeller.Visible = true;
            buttonGiveRManager.Visible = true;
            buttonUproved.Visible = false;
        }

        private void buttonSelectClients_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM clients";
            ExecuteQuery(query);

            buttonGiveRClient.Visible = false;
            buttonGiveRWC.Visible = false;
            buttonGiveRSeller.Visible = false;
            buttonGiveRManager.Visible = false;
            buttonUproved.Visible = true;
        }

        private void buttonSelectStaff_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM staff";
            ExecuteQuery(query);

            buttonGiveRClient.Visible = false;
            buttonGiveRWC.Visible = false;
            buttonGiveRSeller.Visible = false;
            buttonGiveRManager.Visible = false;
            buttonUproved.Visible = true;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

                var result = MessageBox.Show($"Ви впевнені, що хочете видалити користувача з ID {userId}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteUser(userId);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть користувача для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteUser(int userId)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "DELETE FROM users WHERE UserID = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Користувача успішно видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void ChangeUserRole(int userId, int roleId)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "UPDATE users SET RoleID = @roleId WHERE UserID = @userId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@roleId", roleId);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Роль користувача успішно змінено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error changing user role: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void buttonGiveRClient_Click(object sender, EventArgs e)
        {
            ChangeUserRoleWithConfirmation(2, "клієнт");
        }

        private void buttonGiveRWC_Click(object sender, EventArgs e)
        {
            ChangeUserRoleWithConfirmation(3, "працівник складу");

        }

        private void buttonGiveRSeller_Click(object sender, EventArgs e)
        {
            ChangeUserRoleWithConfirmation(4, "продавець");
        }

        private void buttonGiveRManager_Click(object sender, EventArgs e)
        {
            ChangeUserRoleWithConfirmation(5, "менеджер");
        }

        private void ChangeUserRoleWithConfirmation(int roleId, string roleName)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

                var result = MessageBox.Show($"Ви впевнені, що хочете змінити роль користувача {userId} на {roleName}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ChangeUserRole(userId, roleId);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть користувача для зміни ролі.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
