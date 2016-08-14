Imports MySql.Data.MySqlClient

Module GlobalVariableModule
    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=" & My.Settings.server & ";username=root;password=microcircle;database=jpcsreg;Character Set=utf8"
    Public comm As MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As New MySqlDataAdapter
End Module
