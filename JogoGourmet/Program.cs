using JogoGourmet.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using System;
using JogoGourmet.Data.Repository.Interface;
using JogoGourmet.Service.Interface;
using JogoGourmet.Service;
using JogoGourmet.Data.Repository;

namespace JogoGourmet
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ServiceProvider = new ServiceCollection()
            .AddDbContext<FoodsDbContext>(opt => opt.UseInMemoryDatabase("FoodsDb"))
            .AddScoped<IFoodService, FoodService>()
            .AddScoped<IFoodRepository, FoodRepository>()
            .BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new InitialForm());
        }
    }
}