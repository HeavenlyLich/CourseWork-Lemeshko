using CourseWork.forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CourseWork
{
    public partial class LoginForm : Form
    {
        private MySqlConnection conn;

        public LoginForm()
        {
            InitializeComponent();
            conn = DBUtils.GetDBConnection();
            conn.Open();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOK1_Click(object sender, EventArgs e)
        {
            string username = LoginBox.Text;
            string password = PasswordBox.Text;

            string role = AuthenticateUser(username, password);

            if (!string.IsNullOrEmpty(role))
            {
                OpenFormByRole(role, username);
            }
            else
            {
                MessageBox.Show("Неправильний логін або пароль");
            }
        }

        private string AuthenticateUser(string username, string password)
        {
            string sql = "SELECT RoleName FROM Users INNER JOIN UserRoles ON Users.RoleID = UserRoles.RoleID WHERE Username=@Username AND Password=@Password";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            object result = cmd.ExecuteScalar();
            return result?.ToString();
        }

        private void OpenFormByRole(string role, string username)
        {
            Form nextForm;

            switch (role)
            {
                case "Guest":
                case "Client":
                    nextForm = new MainMenuClient(conn, username, role);
                    break;
                case "Warehouse Clerk":
                    nextForm = new MainMenuWarehouse(conn, username, role);
                    break;
                case "Seller":
                    nextForm = new MainMenuSeller(conn, username, role);
                    break;
                case "Manager":
                    nextForm = new MainMenuManager(conn, username, role);
                    break;
                default:
                    MessageBox.Show("Невідома роль");
                    return;
            }

            nextForm.Show();
            this.Hide();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(conn);
            registrationForm.Show();
            this.Hide();
        }
    }
}
