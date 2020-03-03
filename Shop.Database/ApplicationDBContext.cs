using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Shop.Database
{
    class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContedtOptions<ApplicationDBContext> options)
            : base(options) { }
        public Dbset<Product> Myproperty {get; set;}
    }
}
