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
    public class SettingsService : Service<TblAyarlar>, ISettingsService
    {
        public SettingsService(IGenericRepository<TblAyarlar> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
