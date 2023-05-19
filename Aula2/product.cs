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
                    cmd.CommandText = @"INSERT INTO products " +
                        @"(name, model, quantity, value) " +
                        @"VALUES " +
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
            catch (Exception ex) { 

            }
            return result;
        }

        public product Get(int id)
        {
            product result = new product();
            databaseacess dba = new databaseacess();

            try
            {
                using(NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * FROM products " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using(cmd.Connection = dba.OpenConnection())
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result.id = Convert.ToInt32(reader["id"]);
                            result.name = reader["name"].ToString();
                            result.model = reader["model"].ToString();
                            result.quantity = Convert.ToInt32(reader["quantity"]);
                            result.value = float.Parse(reader["value"].ToString()); 

                        }
                    }
                }
            }
            catch ( Exception ex)
            {

                
            }
            return result;
        }

        public List<product> GetALL() {

            List<product> result = new List<product>();
            databaseacess dba = new databaseacess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * FROM products;";

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product product = new product();

                            product.id = Convert.ToInt32(reader["id"]);
                            product.name = reader["name"].ToString();
                            product.model = reader["model"].ToString();
                            product.quantity = Convert.ToInt32(reader["quantity"]);
                            product.value = float.Parse(reader["value"].ToString());

                            result.Add(product);

                        }
                    }
                }
            }
            catch (Exception ex)
            {


            }
            

            return result;

        }

        public bool Delete(int id)
        {
            bool result = false;
            databaseacess dba = new databaseacess();

            try
            {
                using(NpgsqlCommand cmd = new NpgsqlCommand()) 
                {
                    cmd.CommandText = @"DELETE FROM products " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using(cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;
                    }

                }
            }
            catch (Exception ex)
            {  

            }

            return result;
        }

        public bool Update(product product)
        {

            bool result = false;
            databaseacess dba = new databaseacess();

            try
            {
                using(NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"UPDATE products " +
                                      @"SET name = @name, model = @model, quantity = @quantity, value = @value " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", product.id);
                    cmd.Parameters.AddWithValue("@name", product.name);
                    cmd.Parameters.AddWithValue("@model", product.model);
                    cmd.Parameters.AddWithValue("@quantity", product.quantity);
                    cmd.Parameters.AddWithValue("@value", product.value);

                    using(cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery() ;
                        result = true;
                    }
                }
            }
            catch (Exception)
            { }
            return result;
        }

    }
}
