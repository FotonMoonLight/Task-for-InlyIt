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
        RelayCommand? addCommand;
        RelayCommand? deleateCommand;

        public ObservableCollection<Product> products { get; set; }
        public ProductViewModel()
        {
            db.Database.EnsureCreated();
            db.products.Load();
            products = db.products.Local.ToObservableCollection();
        }

        public RelayCommand AddCommand
        {
            get 
            {
                return addCommand ??
                      (addCommand = new RelayCommand((selectedItem) =>
                      {
                          
                          Product product = selectedItem as Product;
                         Bucket bucket = db.buckets.FirstOrDefault(x => x.Name == product.Name);
                         if (bucket != null)
                         {
                              bucket.Count += 1;
                              db.buckets.Update(bucket);
                              db.SaveChanges();
                         }
                         else
                         {
                             Bucket bucket1 = new Bucket()
                             {
                                 Name = product.Name,
                                 Count = 1
                             };
                             db.buckets.Add(bucket1);
                             db.SaveChanges();
                         }
                         db.buckets.Add(bucket);
                          db.SaveChanges();
                      }));
            }
        }
    }
}
