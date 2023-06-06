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
    public int idSeller { get; set; }
    public string name { get; set; }
    public string model { get; set; }

    public float value { get; set; }
    public int quantity { get; set; }
    
    public bool national { get; set; }
    public String status { get; set; }
    public String sellerName { get; set; }

       
        public bool Add(product product)
        { 
            bool result = false;
            databaseacess dba = new databaseacess();

            try
            {
                using(NpgsqlCommand cmd= new NpgsqlCommand())
                {
                    cmd.CommandText = @"INSERT INTO products " +
                        @"(id_seller, name, model, quantity, value, national, status) " +
                        @"VALUES " +
                        @"(@idSeller, @name, @model, @quantity, @value, @national, @status);";

                    cmd.Parameters.AddWithValue("@idSeller", product.idSeller);
                    cmd.Parameters.AddWithValue("@name", product.name);
                    cmd.Parameters.AddWithValue("@model", product.model);
                    cmd.Parameters.AddWithValue("@quantity", product.quantity);
                    cmd.Parameters.AddWithValue("@value", product.value);
                    cmd.Parameters.AddWithValue("@national", product.national);
                    cmd.Parameters.AddWithValue("@status", product.status);

                    using (cmd.Connection = dba.OpenConnection())
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
                            result.idSeller = Convert.ToInt32(reader["idSeller"]);
                            result.name = reader["name"].ToString();
                            result.model = reader["model"].ToString();
                            result.quantity = Convert.ToInt32(reader["quantity"]);
                            result.value = float.Parse(reader["value"].ToString());
                            result.national = Convert.ToBoolean(reader["national"]);
                            result.status = reader["status"].ToString();

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
                    cmd.CommandText = @"select p.id, p.id_seller, p.name, p.model, p.quantity, p.value, p.national, p.status, s.name as seller_name " +
                    @"from products p, sellers s " +
                    @"where p.id_seller = s.id " +
                    @"Order by p.id;";


                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product product = new product();

                            product.id = Convert.ToInt32(reader["id"]);
                            product.idSeller = Convert.ToInt32(reader["id_seller"]);
                            product.name = reader["name"].ToString();
                            product.model = reader["model"].ToString();
                            product.quantity = Convert.ToInt32(reader["quantity"]);
                            product.value = float.Parse(reader["value"].ToString());
                            product.national = Convert.ToBoolean(reader["national"]);
                            product.status = reader["status"].ToString();
                            product.sellerName = reader["seller_name"].ToString();


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
                                      @"SET name = @name, model = @model, quantity = @quantity, value = @value, national = @national, status = @status " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", product.id);
                    cmd.Parameters.AddWithValue("@idSeller", product.idSeller);
                    cmd.Parameters.AddWithValue("@name", product.name);
                    cmd.Parameters.AddWithValue("@model", product.model);
                    cmd.Parameters.AddWithValue("@quantity", product.quantity);
                    cmd.Parameters.AddWithValue("@value", product.value);
                    cmd.Parameters.AddWithValue("@national", product.national);
                    cmd.Parameters.AddWithValue("@status", product.status);

                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery() ;
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            { }
            return result;
        }

        public int Count()
        {
            int result = 0;
            databaseacess dba = new databaseacess();

            try
            {
                using(NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT COUNT(id) FROM products;";

                    using(cmd.Connection = dba.OpenConnection())
                    {
                        result = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {

                
            }

            return result;
        }

    }
}
