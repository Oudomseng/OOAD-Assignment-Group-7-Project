Imports MySql.Data.MySqlClient
Module connection
    Public Function mysqldb() As MySqlConnection
        'Return New MySqlConnection("server=127.0.0.1;user id=root;Password=;=dblibrary")
        Return New MySqlConnection("server=localhost;user id=root;Password=hy6Per@lex;database=dblibrary;sslMode=none")
    End Function
    Public con As MySqlConnection = mysqldb()
End Module
