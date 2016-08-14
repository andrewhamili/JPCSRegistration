Imports MySql.Data.MySqlClient

Module GlobalVariableModule
    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=" & My.Settings.server & ";username=" & My.Settings.username & ";password=" & My.Settings.password & ";database=jpcsreg;Character Set=utf8"
    Public comm As MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As New MySqlDataAdapter

    Public eventname As String
    Public eventdate As String
    Public eventtime As String
    Public eventlocation As String
    Public eventtable As String
End Module
