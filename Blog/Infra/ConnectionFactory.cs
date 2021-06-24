using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Infra
{
    public class ConnectionFactory
    {
		public static SqlConnection CreateConnectionOpen()
		{	
			// Acess AppSettings.json
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.AddEnvironmentVariables();
			
			// Recovery connection string
			IConfiguration configuration = builder.Build();			
			string stringConnection = configuration.GetConnectionString("Blog");
			
			// Create obj
			SqlConnection connection = new SqlConnection(stringConnection);
			
			// Open connection
			connection.Open();
			
			return connection;
		}
	}
}
