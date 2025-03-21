using CsharpEgitimKampi301.DataAccessLayer.Abstract;
using CsharpEgitimKampi301.DataAccessLayer.Context;
using CsharpEgitimKampi301.DataAccessLayer.Repositories;
using CsharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new KampContext();
            var values = context.Products
                .Select(x => new 
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    ProductStock = x.ProductStock,
                    ProductPrice = x.ProductPrice,
                    ProductDescription = x.ProductDescription,
                    CategoryName = x.Category.CategoryName,
                }).ToList();

            return values.Cast<object>().ToList();
        }
    }
}
