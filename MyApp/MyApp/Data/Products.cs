using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyApp.Model
{
    class Products
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Image Image { get; set; }

        public static List<Products> GetProducts()
        {
            ApplicationContext context = new ApplicationContext();
            return context.products.ToList();//Возвращаем список продуктов
        }
    }
}
