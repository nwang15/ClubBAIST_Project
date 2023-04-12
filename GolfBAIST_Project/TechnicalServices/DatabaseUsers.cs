using GolfBAIST_Project.Models.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.TechnicalServices
{
    public class DatabaseUsers 
    {
        public DatabaseUser GetDatabaseUser()
        {
            ConfigurationBuilder DatabaseUsersBuilder = new();
            DatabaseUsersBuilder.SetBasePath(Directory.GetCurrentDirectory());
            DatabaseUsersBuilder.AddJsonFile("appsettings.json");
            IConfiguration DatabaseUsersConfiguration = DatabaseUsersBuilder.Build();

            SqlConnection BAIS3230 = new();
            BAIS3230.ConnectionString = DatabaseUsersConfiguration.GetConnectionString("BAIS3230");
            BAIS3230.Open();

            SqlCommand AGetCommand = new()
            {
                Connection = BAIS3230,
                CommandType = CommandType.StoredProcedure,
                CommandText = "GetDatabaseUser"
            };

            SqlDataReader AGetCommandDataReader;
            AGetCommandDataReader = AGetCommand.ExecuteReader();

            DatabaseUser CurrentDatabaseUser = new();

            if (AGetCommandDataReader.HasRows)
            {
                AGetCommandDataReader.Read();

                CurrentDatabaseUser.CurrentUser = (string)AGetCommandDataReader["CurrentUser"];
                CurrentDatabaseUser.SystemUser = (string)AGetCommandDataReader["SystemUser"];
                CurrentDatabaseUser.SessionUser = (string)AGetCommandDataReader["SessionUser"];

            }

            AGetCommandDataReader.Close();
            BAIS3230.Close();

            return CurrentDatabaseUser;
        }
    }
}
