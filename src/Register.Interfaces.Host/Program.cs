using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Register.Interfaces.Host
{
    using Microsoft.Extensions.Hosting;
    using Npgsql;

    public class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "";
            using (var conn = new NpgsqlConnection(connectionString))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
            }

            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
