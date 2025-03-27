using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class DBconnection
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;

        private SqlCommandBuilder commandBuilder;
        private string connectionString = @"Data Source=DESKTOP-KPFQESI\SQLEXPRESS;Initial Catalog=project;Integrated Security=True";

        public DBconnection()
        { 
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        
        }
        public static DBconnection getDBconnection()
        {
            return new DBconnection();
        }
        public int executeInsertUpdateQuery(string Query)
        {
            int count = 0;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.CommandText = Query;
            count = command.ExecuteNonQuery();
            connection.Close();
            return count;
        }
        public DataTable getDataTable(string selectCommand)
        {
            dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };
            dataAdapter.Fill(table);
            return table;
        }
    }
}
