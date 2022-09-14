using AutoMapper;
using GknProject.Core.Models;
using GknProject.Core.Repositories;
using GknProject.Core.Service;
using GknProject.Core.UnitOfWorks;

namespace GknProject.Service.Services
{
    public class AgencyService : Service<TblAcentum>, IAgencyService
    {
        private readonly IAgencyRepository _agencyRepository;
        private readonly IMapper _mapper;
        public AgencyService(IGenericRepository<TblAcentum> repository,  IUnitOfWork unitOfWork, IMapper mapper, IAgencyRepository agencyRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _agencyRepository = agencyRepository;
        }

        public List<TblAcentum> GetAllAcentas()
        {
            return _agencyRepository.GetAll().ToList();

        }
    }
}
