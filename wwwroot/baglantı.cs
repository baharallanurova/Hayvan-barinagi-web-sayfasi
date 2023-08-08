using System;
using System.Data.SqlClient;
using System.Net;
using System.Collections.Specialized;

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
                            
                            Console.WriteLine($"isim: bahar soyisim: allanurova  kullanıcı-adı: baharallanurova kullanıcı-şifre: 123456 pet-bilgileri: adı:minik , yaşı:3");
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
                 using (var wb = new WebClient())
           { 

            Console.WriteLine($"text");
          
      }
          }
        

        
        static SqlConnection GetSqlConnection()
        {
            string connectionString = @"Data Source = LAPTOP-0BGBS8KT\SQLEXPRESS02 ; Initial Catalog=barınak ; Integrated Security=SSPI;";             
                return new SqlConnection(connectionString);               
        }
    }
}

