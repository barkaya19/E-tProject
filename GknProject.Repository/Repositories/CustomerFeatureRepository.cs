using GknProject.Core.Models;
using GknProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GknProject.Repository.Repositories
{
    public class CustomerFeatureRepository : GenericRepository<TblMusteriOzellik>, ICustomerFeatureRepository
    {
        public CustomerFeatureRepository(GknKargoErpContext context) : base(context)
        {
        }
    }
}
