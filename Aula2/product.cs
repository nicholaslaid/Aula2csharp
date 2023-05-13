using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class product
    {
    public int id { get; set; }
    public string name { get; set; }
    public string model { get; set; }

    public float value { get; set; }
    public int quantity { get; set; }
    
        public bool Add(product product)
        { 
            bool result = false;
            databaseacess dba = new databaseacess();

            try
            {
                using(NpgsqlCommand cmd= new NpgsqlCommand())
                {
                    cmd.CommandText = @"INSERT INTO products" +
                        @"(name, model, quantity, value)" +
                        @"VALUES" +
                        @"(@name, @model, @quantity, @value);";

                    cmd.Parameters.AddWithValue("@name", product.name);
                    cmd.Parameters.AddWithValue("@model", product.model);
                    cmd.Parameters.AddWithValue("@quantity", product.quantity);
                    cmd.Parameters.AddWithValue("@value", product.value);
                    
                    using(cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }
            }
            catch { 

            }
            return result;
        }





    }
}
