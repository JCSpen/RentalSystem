using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


public class DataController
    {
    static string DataSource = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + Application.StartupPath + @"\MightyMotorsDB.accdb";
    public OleDbConnection Connection = new OleDbConnection(DataSource);
   
    public void CreateUser(string Username,string Password, string FirstName, string LastName, string Insurance, int ID)
    {
        OleDbCommand Command = new OleDbCommand(DataSource);
        Connection.Open();
        Command.CommandText = "INSERT INTO Users([ID],Username,[Password],FirstName,LastName,InsuranceProvider) VALUES(" + ID + ",'" + Username + "','" + Password + "','" + FirstName + "','" + LastName + "','" + Insurance + "');";
        Command.Connection = Connection;
        Command.ExecuteNonQuery();
        Connection.Close();
    }

    public int FindUserID(string Username, string Password)
    {
        OleDbCommand Command = new OleDbCommand(DataSource);
        Connection.Open();
        Command.CommandText = "SELECT ID FROM Users WHERE(Username = '"+ Username + "' AND [Password] = '"+Password + "');";
        Command.Connection = Connection;
        Command.CommandType = System.Data.CommandType.Text;
        int result = (int)Command.ExecuteScalar();
        Connection.Close();
        return result;
    }
}

