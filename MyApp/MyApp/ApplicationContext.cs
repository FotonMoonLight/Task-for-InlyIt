using Microsoft.EntityFrameworkCore;
using MyApp.Data;
using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Products> products { get; set; } = null!;
        public DbSet<BucketsProd> buckets { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();//Гарантируем что база создана
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=anydb.db"); 
            /* Для хранения товаров и цен лучше использовать сервер или API с базой данных например PostgreSql, так можно будет
             * обновлять цены и подборки товаров, так же через стороннее API можно будет вынести логику работы с базой, что поможет 
             * защитить данные при декомпиляции кода, а подключение к API можно защитить через обработку JWT токенов или иными средствами, плюсом будет возможность 
             * написать раззные клиенты для удобного взаимодействия с приложением, из браузера, нативно или с мобильных устройств.
             * Но в рамках примера подойдет и встраиваемая база.
             */
        }
    }
}
