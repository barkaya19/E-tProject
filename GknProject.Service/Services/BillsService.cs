using GknProject.Core.Models;
using GknProject.Core.Repositories;
using GknProject.Core.Service;
using GknProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GknProject.Service.Services
{
    public class BillsService : Service<TblFaturalar>, IBillsService
    {
        public BillsService(IGenericRepository<TblFaturalar> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
