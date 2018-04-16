using Microsoft.AspNetCore.Mvc;
using PieShopWebsite.Models;
using PieShopWebsite.ViewModels;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PieShopWebsite.Controllers
{
	public class HomeController : Controller
	{
		private readonly IPieRepository _pieRepository;

		public HomeController(IPieRepository pieRepository) // ctor dependency injection
		{
			_pieRepository = pieRepository;
		}

		// GET: /<controller>/
		public IActionResult Index()
		{


			var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

			var homeViewModel = new HomeViewModel()
			{
				Title = "Welcome to PJ Pie Shop",
				Pies = pies.ToList()
			};

			return View(homeViewModel); // strongly typed view
		}
	}
}
