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
    public partial class MainMenuManager : Form
    {
        private MySqlConnection conn;
        private string username;
        private string userRole;

        public MainMenuManager(MySqlConnection connection, string user, string role)
        {
            InitializeComponent();
            this.conn = connection;
            username = user;
            userRole = role;
            labelWelcome.Text = $"Вітаю, менеджере {username}!";
        }

        private void buttonCheckOrder_Click(object sender, EventArgs e)
        {
            Helper.OpenOrderForm(this, conn, username, userRole);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Helper.Logout(this);
        }

        private void buttonCheckUsers_Click(object sender, EventArgs e)
        {
            Helper.OpenUsersForm(this, conn, username, userRole);
        }

        private void buttonCheckProducts_Click(object sender, EventArgs e)
        {
            Helper.OpenProductsForm(this, conn, username, userRole);

        }
    }
}
