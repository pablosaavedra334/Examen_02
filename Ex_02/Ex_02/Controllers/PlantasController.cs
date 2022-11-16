using Ex_02.Data.Entity;
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

        public IActionResult Index () 
        {

            return View(this.repository.GetProducts());


        }
        public IActionResult Details(int? Id) //Index/agregar vista/vista razor / (index/Details/Product..p2../)
        {

            if (Id == null)
            {
                return NotFound();

            }

            var product = this.repository.GetProduct(Id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);



        }

        [HttpGet]   
        public IActionResult Create()  
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Plantas product) 
        {
            if (ModelState.IsValid)
            {
                this.repository.AddProduct(product);
                await this.repository.SaveAllAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(product);

        }


    }
}
