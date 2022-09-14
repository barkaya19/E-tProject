using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GknProject.Core.Models
{
    public class GknKargoErpUserContext:IdentityDbContext
    {
        public GknKargoErpUserContext(DbContextOptions<GknKargoErpUserContext> options):base(options)
        {

        }
    }
}
