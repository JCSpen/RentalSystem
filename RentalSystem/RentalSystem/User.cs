using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class User
    {
    public string Username;
    public string Password;
    public string FirstName;
    public string LastName;
    public string InsuranceProvider;
    public bool NewUser;
    public int ID;
    public Vehicle UserVehicle = new Vehicle();

    public void SetVehicleData(string[] Info)
    {
        UserVehicle.ID = int.Parse(Info[0]);
        UserVehicle.Make = Info[1];
        UserVehicle.Model = Info[2];
        UserVehicle.Registration = Info[3];
        UserVehicle.Mileage = int.Parse(Info[4]);
        UserVehicle.CurrentlyRented = true;
        UserVehicle.RenteeName = Username;
        UserVehicle.Price = int.Parse(Info[6]);
    }
    }

