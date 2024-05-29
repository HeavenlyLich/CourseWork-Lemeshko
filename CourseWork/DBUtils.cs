using MySql.Data.MySqlClient;


namespace CourseWork
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "coursework";
            string username = "Heavenly";
            string password = "PasswordBd";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}

