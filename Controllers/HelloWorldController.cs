using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers {
    public class HelloWorldController : Controller {

        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index() {
            //DogViewModel doggo = new DogViewModel() { Name = "Siff", Age = 2 };
            //return View(doggo);

            return View(dogs);
        }
        public IActionResult Create() {
            var dogVm = new DogViewModel();

            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel) {


            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Hello() {
            return "Who's there?";
        }
    }
}
