using CourseWork.forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public static class Helper
    {
        // Перехід до допоміжних форм
        public static void OpenOrderForm(Form currentForm, MySqlConnection conn, string username, string userRole)
        {
            currentForm.Close();
            OrderForm orderForm = new OrderForm(conn, username, userRole);
            orderForm.Show();
        }
        public static void OpenOrderHistoryForm(Form currentForm, MySqlConnection conn, string username, string userRole)
        {
            currentForm.Close();
            OrderHistoryForm orderHistoryForm = new OrderHistoryForm(conn, username, userRole);
            orderHistoryForm.Show();
        }

        public static void OpenShopForm(Form currentForm, MySqlConnection conn, string username, string userRole)
        {
            currentForm.Close();
            ShopForm shopForm = new ShopForm(conn, username, userRole);
            shopForm.Show();
        }

        public static void OpenUsersForm(Form currentForm, MySqlConnection conn, string username, string userRole)
        {
            currentForm.Close();
            UsersForm usersForm = new UsersForm(conn, username, userRole);
            usersForm.Show();
        }

        public static void OpenProductsForm(Form currentForm, MySqlConnection conn, string username, string userRole)
        {
            currentForm.Close();
            ProductsForm productsForm = new ProductsForm(conn, username, userRole);
            productsForm.Show();
        }


        // Перехід до меню логіну
        public static void Logout(Form currentForm)
        {
            currentForm.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        // Перехід до головних форм
        public static void GoToMainClientForm(Form currentForm, MySqlConnection conn, string username, string userRole)
        {
            currentForm.Close();
            MainMenuClient mainMenuClient = new MainMenuClient(conn, username, userRole);
            mainMenuClient.Show();
        }

        public static void GoToMainSellerForm(Form currentForm, MySqlConnection conn, string username, string userRole)
        {
            currentForm.Close();
            MainMenuSeller mainMenuSeller = new MainMenuSeller(conn, username, userRole);
            mainMenuSeller.Show();
        }

        public static void GoToMainManagerForm(Form currentForm, MySqlConnection conn, string username, string userRole)
        {
            currentForm.Close();
            MainMenuManager mainMenuManager = new MainMenuManager(conn, username, userRole);
            mainMenuManager.Show();
        }

        public static void GoToMainWarehouseForm(Form currentForm, MySqlConnection conn, string username, string userRole)
        {
            currentForm.Close();
            MainMenuWarehouse mainMenuWarehouse = new MainMenuWarehouse(conn, username, userRole);
            mainMenuWarehouse.Show();
        }
    }
}
