using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Seller
    {
        //Atributos
        public int id { get; set; }
        public string name { get; set; }
        public string cnpj { get; set; }
        public string email { get; set; }
        public string phone { get; set; }


        //Métodos
        public List<Seller> GetALL()
        {

            List<Seller> result = new List<Seller>();
            databaseacess dba = new databaseacess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * FROM sellers ORDER BY name;";

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Seller seller = new Seller();

                            seller.id = Convert.ToInt32(reader["id"]);
                            seller.name = reader["name"].ToString();
                            seller.cnpj = reader["cnpj"].ToString();
                            seller.email = reader["email"].ToString();
                            seller.phone = reader["phone"].ToString();


                            result.Add(seller);

                        }
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
