using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace TelSpr
{
    public class Department
    {
        public long Id;
        public string Name;

        public Department(long newId, string newName)
        {
            Id = newId;
            Name = newName;
        }

        public override string ToString()
        {
            return Name;
        }

    }

    class DBFunctions
    {
        private const string DBFileName = "phonedb.sqlite";

        private static string LoadConnString()
        {
            return "Database=telspr;Data Source=192.168.0.160" +
                    ";Port=3306;User Id=telspr_user;Password=Pr0gress;CharSet=utf8";
        }

        static DBFunctions()
        {            
        }

        static void CreateDataBase()
        {
            var con = OpenConnection();

            /*var command = con.CreateCommand();
            //Структура организации
            command.CommandText = "CREATE TABLE IF NOT EXISTS org_structure(id INTEGER PRIMARY KEY, parent_id INTEGER NOT NULL, name TEXT, boss_id INTEGER)";
            command.ExecuteNonQuery();

            //Персоналии
            command.CommandText = @"CREATE TABLE IF NOT EXISTS workers(id INTEGER PRIMARY KEY, 
            second_name TEXT NOT NULL,name TEXT NOT NULL,third_name TEXT,department INTEGER NOT NULL, position TEXT NOT NULL,
            phone_official TEXT, phone_cell_1 TEXT, phone_cell_2 TEXT,cabinet TEXT,photo BLOB,responsibility TEXT,comment TEXT,phone_dop TEXT,boss INTEGER,email_work TEXT, email_personal TEXT, birthday TEXT)";
            command.ExecuteNonQuery();*/

            con.Close();
        }
        
        public static MySqlConnection OpenConnection()
        {

            MySqlConnection connection = new MySqlConnection(LoadConnString());
            
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                int i = 1;
                return null;
            }
        }

        public static void CloseConnection(MySqlConnection con)
        {
            con.Close();
        }

        public static DataTable ReadFromDB(string query, Dictionary<string, object> parameters = null)
        {
            var connection = OpenConnection();

            var command = new MySqlCommand(query, connection);
            if (parameters != null)
            {
                foreach (var paramName in parameters.Keys)
                {
                    command.Parameters.AddWithValue(paramName, parameters[paramName]);
                }
            }

            var adapter = new MySqlDataAdapter(command);
            var table = new DataTable();

            adapter.Fill(table);

            CloseConnection(connection);

            return table;
        }

        public static object ReadScalarFromDB(string query, Dictionary<string, object> parameters = null)
        {
            var connection = OpenConnection();
            var command = new MySqlCommand(query, connection);
            if (parameters != null)
            {
                foreach (var paramName in parameters.Keys)
                {
                    command.Parameters.AddWithValue(paramName, parameters[paramName]);
                }
            }

            var value = command.ExecuteScalar();

            CloseConnection(connection);

            return value;
        }

        public static void ExecuteCommand(string commandText, Dictionary<string, object> parameters = null)
        {
            var connection = OpenConnection();
            var command = new MySqlCommand(commandText, connection);

            if (parameters != null)
            {
                foreach (var paramName in parameters.Keys)
                {
                    command.Parameters.AddWithValue(paramName, parameters[paramName]);
                }
            }

            command.ExecuteNonQuery();

            CloseConnection(connection);

        }

        public static byte[] ImageToByte(Image image, ImageFormat format)
        {
            using (var ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                var imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        //public Image Base64ToImage(string base64String)
        public static Image ByteToImage(byte[] imageBytes)
        {
            // Convert byte[] to Image
            var ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }

    }

}
