﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SportsStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseDefaultServiceProvider(opt => opt.ValidateScopes = false)
                .UseStartup<Startup>();
    }
}