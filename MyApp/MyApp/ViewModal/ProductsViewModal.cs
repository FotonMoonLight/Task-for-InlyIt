using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyApp.ViewModal
{
    class ProductsViewModal : DependencyObject
    {


        public string Filter
        {
            get { return (string)GetValue(FilterProperty); }
            set { SetValue(FilterProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Filter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterProperty =
            DependencyProperty.Register("Filter", typeof(string), typeof(ProductsViewModal), new PropertyMetadata(""));



        public List<Products> Items
        {
            get { return (List<Products>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(List<Products>), typeof(ProductsViewModal), new PropertyMetadata(null));


        public ProductsViewModal() 
        { 
            Items = Products.GetProducts();//Присваиваем в конструкторе данные из бд
        }

    }
}
