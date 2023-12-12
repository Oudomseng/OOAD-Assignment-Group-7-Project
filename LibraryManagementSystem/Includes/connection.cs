using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    static class connection
    {
        public static MySqlConnection mysqldb()
        {
            // Return New MySqlConnection("server=127.0.0.1;user id=root;Password=;=dblibrary")
            return new MySqlConnection("server=localhost;user id=root;Password=hy6Per@lex;database=dblibrary;sslMode=none");
        }
        public static MySqlConnection con = mysqldb();
    }
}