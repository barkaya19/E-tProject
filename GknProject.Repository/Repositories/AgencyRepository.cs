using GknProject.Core.Models;
using GknProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GknProject.Repository.Repositories
{
    public class AgencyRepository : GenericRepository<TblAcentum>, IAgencyRepository
    {
        public AgencyRepository(GknKargoErpContext context) : base(context)
        {
        }

        public List<TblAcentum> GetAllAcentas()
        {

            return _context.TblAcenta.ToList();
        }


    }
}
