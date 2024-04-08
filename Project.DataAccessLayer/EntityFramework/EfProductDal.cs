using Microsoft.EntityFrameworkCore;
using Project.DataAccessLayer.Abstracts;
using Project.DataAccessLayer.Concretes;
using Project.DataAccessLayer.Repositories;
using Project.EntityLayer.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new SignalRContext();
            var values= context.Products.Include(x=>x.Category).ToList();
            return values;
        }
    }
}
