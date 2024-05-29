﻿using MySql.Data.MySqlClient;
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
    public partial class MainMenuSeller : Form
    {
        private MySqlConnection conn;
        private string username;
        private string userRole;

        public MainMenuSeller(MySqlConnection connection, string user, string role)
        {
            InitializeComponent();
            this.conn = connection;
            username = user;
            userRole = role;
            labelWelcome.Text = $"Радий тебе бачити, {username}!";
        }

        private void buttonCheckOrder_Click(object sender, EventArgs e)
        {
            Helper.OpenOrderForm(this, conn, username, userRole);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Helper.Logout(this);
        }

        private void buttonCheckProducts_Click(object sender, EventArgs e)
        {
            Helper.OpenProductsForm(this, conn, username, userRole);
        }
    }
}
