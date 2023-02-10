using Microsoft.AspNetCore.Mvc;
using MvcCoreChollometro.Models;
using MvcCoreChollometro.Repositories;

namespace MvcCoreChollometro.Controllers
{
    public class ChollosController : Controller
    {
        public RepositoryChollos repo;
        public ChollosController(RepositoryChollos repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Chollos> chollos = this.repo.GetChollos();
            return View(chollos);
        }
    }
}
