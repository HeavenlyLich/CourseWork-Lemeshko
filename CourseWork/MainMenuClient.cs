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
    public partial class MainMenuClient : Form
    {
        private MySqlConnection conn;
        private string username;
        private string userRole;

        public MainMenuClient(MySqlConnection connection, string user, string role)
        {
            InitializeComponent();
            conn = connection;
            username = user;
            userRole = role;
            labelWelcome.Text = $"Радий тебе бачити, {username}!";
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            Helper.OpenShopForm(this, conn, username, userRole);
        }

        private void buttonOrderHistory_Click(object sender, EventArgs e)
        {
            Helper.OpenOrderHistoryForm(this, conn, username, userRole);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Helper.Logout(this);
        }
    }
}
