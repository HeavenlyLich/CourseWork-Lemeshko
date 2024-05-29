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

namespace CourseWork
{
    public partial class RegistrationForm : Form
    {
        private MySqlConnection conn;

        public RegistrationForm(MySqlConnection connection)
        {
            InitializeComponent();
            this.conn = connection;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Helper.Logout(this);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string rePassword = textBoxRPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(rePassword))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля");
                return;
            }

            if (password != rePassword)
            {
                MessageBox.Show("Паролі не співпадають");
                return;
            }

            if (IsLoginUnique(login))
            {
                RegisterUser(login, password);
            }
            else
            {
                MessageBox.Show("Логін вже існує");
            }

        }
        private bool IsLoginUnique(string login)
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE Username=@Username";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", login);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count == 0;
        }

        private void RegisterUser(string login, string password)
        {
            string sql = "INSERT INTO users (Username, Password, RoleID) VALUES (@Username, @Password, (SELECT RoleID FROM userroles WHERE RoleName='Client'))";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", login);
            cmd.Parameters.AddWithValue("@Password", password);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Реєстрація успішна");
                LoginForm mainForm = new LoginForm();
                mainForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при реєстрації: " + ex.Message);
            }
        }
    }
    
}
