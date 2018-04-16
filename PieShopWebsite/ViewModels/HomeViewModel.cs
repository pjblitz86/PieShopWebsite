using PieShopWebsite.Models;
using System.Collections.Generic;

namespace PieShopWebsite.ViewModels
{
	public class HomeViewModel
	{
		public string Title { get; set; }
		public List<Pie> Pies { get; set; }
	}
}
