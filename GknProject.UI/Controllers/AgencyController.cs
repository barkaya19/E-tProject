using GknProject.Core.Models;
using GknProject.Core.Repositories;
using GknProject.Core.Service;
using Microsoft.AspNetCore.Mvc;

namespace GknProject.UI.Controllers
{
    public class AgencyController : Controller
    {
       
        private readonly IAgencyService _service;

        public AgencyController(IAgencyService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {

           return View(_service.GetAllAcentas());
        }
        
    }
}
