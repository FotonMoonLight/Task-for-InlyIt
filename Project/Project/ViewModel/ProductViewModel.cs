using DMSkin.Core;
using Project.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
namespace Project.ViewModel
{
    class ProductViewModel 
    {
        ApplicationContext db = new ApplicationContext();

        public ObservableCollection<Product> products { get; set; }
        public ProductViewModel()
        {
            db.Database.EnsureCreated();
            db.products.Load();
            products = db.products.Local.ToObservableCollection();
        }
    }
}
