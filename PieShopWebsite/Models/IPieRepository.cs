using System.Collections.Generic;

namespace PieShopWebsite.Models
{
	public interface IPieRepository
	{
		IEnumerable<Pie> GetAllPies();
		Pie GetPieById(int pieId);
	}
}
