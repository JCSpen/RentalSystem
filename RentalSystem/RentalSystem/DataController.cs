using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


public class DataController
    {
    static string DataSource = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + Application.StartupPath + @"\MightyMotorsDB.accdb";
    public OleDbConnection Connection = new OleDbConnection(DataSource);
    Visionairy Scout = new Visionairy();

    public bool SearchByValue(string Value,string Table, string Column)
    {
        string Query = "SELECT " + Column + " FROM " + Table + " WHERE(" + Column + " = '" + Value + "');";
        return Scout.ValueExists(Query);
    }
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
        if (Scout.ValueExists("SELECT Username FROM Users WHERE(Username = '" + Username + "' AND[Password] = '" + Password + "');"))
        {
            OleDbCommand Command = new OleDbCommand(DataSource);
            Connection.Open();
            Command.CommandText = "SELECT ID FROM Users WHERE(Username = '" + Username + "' AND [Password] = '" + Password + "');";
            Command.Connection = Connection;
            Command.CommandType = System.Data.CommandType.Text;
            int getresult = (int)Command.ExecuteScalar();
            int result = getresult;
            Connection.Close();
            return result;
        }
        return 0;
    }

    public string FindFirstname(int ID)
    {
        OleDbCommand Command = new OleDbCommand(DataSource);
        Connection.Open();
        Command.CommandText = "SELECT Firstname FROM Users WHERE(ID = " + ID + ");";
        Command.Connection = Connection;
        Command.CommandType = System.Data.CommandType.Text;
        string result = (string)Command.ExecuteScalar();
        Connection.Close();
        return result;
    }

    public string FindLastname(int ID)
    {
        OleDbCommand Command = new OleDbCommand(DataSource);
        Connection.Open();
        Command.CommandText = "SELECT Lastname FROM Users WHERE(ID = " + ID + ");";
        Command.Connection = Connection;
        Command.CommandType = System.Data.CommandType.Text;
        string result = (string)Command.ExecuteScalar();
        Connection.Close();
        return result;
    }
    public string FindInsuraceInfo(int ID)
    {
        OleDbCommand Command = new OleDbCommand(DataSource);
        Connection.Open();
        Command.CommandText = "SELECT InsuranceProvider FROM Users WHERE(ID = " + ID + ");";
        Command.Connection = Connection;
        Command.CommandType = System.Data.CommandType.Text;
        string result = (string)Command.ExecuteScalar();
        Connection.Close();
        return result;
    }
    private class Visionairy
    {
        string DataSource = DataController.DataSource;
            public bool ValueExists(string Query)
            {
                OleDbCommand Command = new OleDbCommand();
                OleDbConnection Connection = new OleDbConnection(DataSource);
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = Query;
                string? QueryResult = (string?)Command.ExecuteScalar();
                if(QueryResult != null)
            {
                Connection.Close();
                return true;
            }
                Connection.Close();
                return false;
            }
        }
    }



