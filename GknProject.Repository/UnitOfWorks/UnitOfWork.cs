using GknProject.Core.Models;
using GknProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GknProject.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GknKargoErpContext _context;

        public UnitOfWork(GknKargoErpContext context)
        {
            _context = context;
        }
        public void Commit()
        {
           _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
