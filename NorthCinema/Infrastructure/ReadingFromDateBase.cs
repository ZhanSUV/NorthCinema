using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NorthCinema.Infrastructure
{
    class ReadingFromDateBase
    {
        public readonly List<Domain.Users.AdminUser> adminList = new List<Domain.Users.AdminUser>();
        public readonly List<Domain.Users.CashierUser> cashierList = new List<Domain.Users.CashierUser>();
        public readonly List<Domain.Users.VisitorUser> visitorList = new List<Domain.Users.VisitorUser>();
        private string pathOfDataBase = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Жанат\Documents\visual studio 2015\Projects\University SUPER GUI\University SUPER GUI\Users.mdf; Integrated Security = True";
        public void ReadFromDateBase()
        {
            SqlConnection connectToDateBase = new SqlConnection(pathOfDataBase);
            using (connectToDateBase)
            {
                SqlCommand command = new SqlCommand(
                "SELECT id_User, First_Name, Second_Name, Last_Name, Status, Login, Password FROM [Users_info];",
                connectToDateBase);
                connectToDateBase.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(4) == "Admin")
                        {
                           
                        }
                        if (reader.GetString(4) == "Teacher")
                        {
                            
                        }
                        if (reader.GetString(4) == "Student")
                        {
                           
                        }
                    }
                }
                reader.Close();
            }
        }

    }
}
