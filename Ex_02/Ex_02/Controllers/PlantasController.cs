using Ex_02.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Ex_02.Controllers
{
    public class PlantasController : Controller
    {
        private readonly IRepository repository;

        public PlantasController(IRepository repository)
        {

            this.repository = repository;


        }

        public IActionResult Index() //Index/agregar vista/vista razor / (index/list/Product..p2../)
        {

            return View(this.repository.GetProducts());
        }


    }
}
