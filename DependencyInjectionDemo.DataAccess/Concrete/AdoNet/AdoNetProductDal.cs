using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionDemo.DataAccess.Abstract;
using DependencyInjectionDemo.Entities.Concrete;

namespace DependencyInjectionDemo.DataAccess.Concrete.AdoNet
{
	public class AdoNetProductDal:IProductDal
	{
		SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ExampleDB;integrated security=true");
		public List<Product> Products()
		{
			if (_connection.State == System.Data.ConnectionState.Closed)
			{
				_connection.Open();
			}
			SqlCommand command = new SqlCommand("Select * from Products", _connection);
			SqlDataReader reader = command.ExecuteReader();
			List<Product> products = new List<Product>();
			while (reader.Read())
			{
				Product product = new Product
				{
					ProductId = Convert.ToInt32(reader["ProductId"]),
					ProductName = reader["ProductName"].ToString(),
					UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
					UnitsInStock = Convert.ToInt32(reader["UnitsInStock"])
				};
				products.Add(product);
			}

			reader.Close();
			_connection.Close();
			return products;
		}
	}
}
