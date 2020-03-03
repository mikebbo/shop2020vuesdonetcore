using System;
using System.Collections.Generic;
using System.Text;

namespace shop.Application.Product
{
   public class CreateProduct
    {
        private ApplicationDbContext _context;
        public CreateProduct(AplicationDbContext context)
        {
            _context = context;
        }
        public void Do(int Id, string Name, string Description)
        {
            _context.Products.Add(new Product
            {
                Id = id,
                Name = Name,
                Description = Description
            });

        }
    }
}
