using Microsoft.EntityFrameworkCore;
using Project.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    class BucketViewModel
    {
        ApplicationContext db = new ApplicationContext();
        public ObservableCollection<Product> bucets { get; set; }
        public BucketViewModel()
        {
            db.Database.EnsureCreated();
            db.products.Load();
            bucets = db.products.Local.ToObservableCollection();
        }
    }
}
