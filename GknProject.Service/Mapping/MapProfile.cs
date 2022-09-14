using AutoMapper;
using GknProject.Core.DTOs;
using GknProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GknProject.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<TblAcentum,TblAcentumDto>().ReverseMap();
        }
    }
}
