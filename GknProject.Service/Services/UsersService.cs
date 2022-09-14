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
    public class UsersService : Service<TblKullanicilar>, IUsersService
    {
        public UsersService(IGenericRepository<TblKullanicilar> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
