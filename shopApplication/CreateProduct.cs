using System;
using System.Collections.Generic;
using System.Text;
using shop.Domain;
using Shob.Db;


namespace shop.Application
{
  public  class CreateProduct
    { 
         private ApplicationDbContext _context;
        public CreateProduct(AplicationDbContext context)
        {
            _context = context;
        }
        public void Do(int Id, string Name, string Description)
        {
            _context.Products.Add(new Product {
                Id = id,
                Name = Name,
                Description = Description
            });

        }
    }
}
