using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Tennisklubben.Models;

namespace Tennisklubben.DataConnection
{
    public class DbConnection
    {
        Player player = new Player();
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zbcmatbj\OneDrive - EFIF\H2\Tennisklubben Ryvang\Tennisklubben\App_Data\TennisClubDatabase.mdf;Integrated Security=True";
        public void SaveToDatabase(string name, string adress, string phone, string email, int age, DateTime regDate, string creditCard, string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_insert_user", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@adress", adress);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@reg_date", regDate.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@credit_card", creditCard);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        conn.Open();
                        Debug.WriteLine(player.Password);
                        
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message.ToString());
            }
        }
    }
}