using System;
using System.Data.SqlClient;

namespace BARINAKAPP
{

    class baglantı
    {
        static void Main(string[] args)
        {
          GetAllProducts();
        }
           
             static void GetAllProducts()
          {
             using( SqlConnection connection = GetSqlConnection() )
                {
                    try
                    {
                        connection.Open();
                        string sql = "select * from Üyeler";
                        SqlCommand command = new SqlCommand(sql,connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while(reader.Read())
                        {
                            Console.WriteLine($"isim: {reader[1]} soyisim: {reader[2]} admin: {reader[3]} admin-şifresi: {reader[4]} kullanıcı-adı: {reader[5]} kullanıcı-şifre: {reader[6]} pet-bilgileri: {reader[7]}");
                        }
                        reader.Close();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }


          }
        
        
        static SqlConnection GetSqlConnection()
        {
            string connectionString = @"Data Source = LAPTOP-0BGBS8KT\SQLEXPRESS02 ; Initial Catalog=barınak ; Integrated Security=SSPI;";             
                return new SqlConnection(connectionString);               
        }
    }
}

