using GknProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GknProject.Core.Service
{
    public interface IAgencyService:IService<TblAcentum>
    {
        List<TblAcentum> GetAllAcentas();
    }
}
