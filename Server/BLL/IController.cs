using BO;
using BO.DTO;
using System.Collections.Generic;

namespace BLL
{
	public interface IController
	{
		int DeleteOffre(Offre offre);
		List<Contrat> GetContrats();
		List<Offre> GetOffres();
		List<Offre> GetOffresFilter(Filtre filtre);
		List<Poste> GetPostes();
		List<Preference> GetPreferences();
		List<Region> GetRegions();
		List<Utilisateur> GetUsers();
		int InsertOffre(Offre offre);
		int UpdateOffre(Offre offre);
	}
}