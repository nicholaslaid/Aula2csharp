using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula2
{
    internal class databaseacess
    {
        private static String dbHost = ConfigurationManager.AppSettings["dbHost"];
        private static String dbPort = ConfigurationManager.AppSettings["dbPort"];
        private static String dbName = ConfigurationManager.AppSettings["dbName"];
        private static String dbUser = ConfigurationManager.AppSettings["dbUser"];
        private static String dbPass = ConfigurationManager.AppSettings["dbPass"];
        
        public NpgsqlConnection OpenConnection()
        {
            String connectionString = String.Format(
                "Server = {0}; User id = {1}; DataBase ={2}; Port = {3}; Password = {4}", dbHost, dbUser, dbName, dbPort, dbPass);

            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            connection.Open();
            return connection;
        }
    }
}
