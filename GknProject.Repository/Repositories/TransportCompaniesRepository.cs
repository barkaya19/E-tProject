using GknProject.Core.Models;
using GknProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GknProject.Repository.Repositories
{
    public class TransportCompaniesRepository : GenericRepository<TblTasimaFirmalari>, ITransportCompaniesRepository
    {
        public TransportCompaniesRepository(GknKargoErpContext context) : base(context)
        {
        }
    }
}
