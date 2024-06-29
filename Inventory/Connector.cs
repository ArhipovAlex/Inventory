using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel;

namespace Inventory
{
    class Connector
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        public DataTable DataTable { get; set; }
        public Connector()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

        }
        public DataTable LoadColumnFromTable(string columns,string tables,string condition=null)
        {
            connection.Open();
            string query = $@"SELECT {columns} FROM {tables}";
            if(condition != null)
            {
                query += $" WHERE {condition}";
            }
            SqlCommand command = new SqlCommand(query,connection);
            reader = command.ExecuteReader();
            DataTable = new DataTable();
            for (int i=0; i<reader.FieldCount;i++) DataTable.Columns.Add(reader.GetName(i));
            while (reader.Read())
            {
                DataRow row= DataTable.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                DataTable.Rows.Add(row);
            }
            connection.Close();
            return DataTable;
        }
        public void InsertDataToBase(string table, string columns, string values)
        {
            string command = $@"INSERT INTO {table}({columns}) VALUES {values}";
            connection.Open();
            SqlCommand cmd = new SqlCommand(command, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public int GetIDbyValue(string table, string columns,string value)
        {
            string command =$@"SELECT {columns.Split()[0]} FROM {table} WHERE '{columns.Split()[1]}'='{value}'";
            connection.Open();
            SqlCommand cmd=new SqlCommand(command, connection);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return id;
        }
    }
}
