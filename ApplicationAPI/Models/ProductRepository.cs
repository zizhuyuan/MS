using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApplicationAPI.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> p = new List<Product>();
        private string _conStr = System.Configuration.ConfigurationManager.ConnectionStrings["SqlConn"].ToString();
        public ProductRepository()
        {

        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new NotImplementedException();
            }
            using (SqlConnection conn = new SqlConnection(this._conStr))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into product values(@name,@introduce)";
                    cmd.Parameters.Add(new SqlParameter("@name", item.Name));
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return p;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}