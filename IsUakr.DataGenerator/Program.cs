using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace IsUakr.DataGenerator
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            for(var i = 0; i < 24; i++)
            {
                var result = Get(5000).ToList();
                Console.WriteLine(result.Count);
            }
            

            CreateHostBuilder(args).Build().Run();
        }

        private static IEnumerable<HttpResponseMessage> Get(int taskCount)
        {
            var tasks = new Task<HttpResponseMessage>[taskCount];
            var http = new HttpClient();
            
            for (var i = 0; i < taskCount; i++)
            {
                tasks[i] = http.GetAsync("https://isuakr.herokuapp.com/api/houses/1");
            }

            Task.WaitAll(tasks);

            return tasks.Select(x => x.Result);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>().UseKestrel((context, options) =>
                    {
                        var port = Environment.GetEnvironmentVariable("PORT");
                        if (!string.IsNullOrEmpty(port))
                        {
                            options.ListenAnyIP(int.Parse(port));
                        }
                    });
                });
    }
}