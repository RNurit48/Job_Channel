using BO;
using BO.DTO;
using DAL.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{/// <summary>
/// regroupe les méthodes des classes
/// </summary>
    public class Controller : IController
    {
        public List<Contrat> GetContrats()
        {
            return ConfigDAO.contratDAO.GetAllContrats();

        }
        public List<Region> GetRegions()
        {
            return ConfigDAO.regionDAO.GetAllRegion();

        }

        public List<Poste> GetPostes()
        {
            return ConfigDAO.posteDAO.GetAllPoste();

        }

        public List<Utilisateur> GetUsers()
        {
            return ConfigDAO.utilisateurDAO.GetAllUser();

        }
        public List<Preference> GetPreferences()
        {
            return ConfigDAO.preferenceDAO.GetAllPreference();

        }
        public List<Offre> GetOffres()
        {
            return ConfigDAO.offreDAO.GetAllOffre();

        }

        public List<Offre> GetOffresFilter(Filtre filtre)
        {
            return ConfigDAO.offreDAO.GetOffreByFilter(filtre);

        }

        public int InsertOffre(Offre offre)
        {
            return ConfigDAO.offreDAO.InsertOffre(offre);
        }

        public int UpdateOffre(Offre offre)
        {
            return ConfigDAO.offreDAO.UpdateOffre(offre);
        }

        public int DeleteOffre(Offre offre)
        {
            return ConfigDAO.offreDAO.DeleteOffre(offre);
        }

        public List<Offre> GetLastOffres()
        {
            return ConfigDAO.offreDAO.GetLastOffre();
        }
    }
}
