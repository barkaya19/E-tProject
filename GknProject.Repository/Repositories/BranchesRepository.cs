using GknProject.Core.Models;
using GknProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GknProject.Repository.Repositories
{
    public class BranchesRepository : GenericRepository<TblSubeler>, IBranchesRepository
    {
        public BranchesRepository(GknKargoErpContext context) : base(context)
        {
        }
    }
}
