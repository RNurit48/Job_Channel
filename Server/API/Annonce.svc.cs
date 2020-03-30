using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BO;
using BO.DTO;
using DAL;
using DAL.DAO;

namespace API
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IAnnonce
    {
        private OffreDAO objoffre;
        Controller Controller = new Controller();
        public List<Contrat> GetContrats()
        {
           return Controller.GetContrats();
        }

        public List<Region> GetRegion()
        {
            return Controller.GetRegions();
        }

        public List<Poste> GetPostes()
        {
            return Controller.GetPostes();
        }

        public Task <List<Utilisateur>> GetUtilisateurs()
        {
            return Task.FromResult(Controller.GetUsers());
        }

        public  Task <List<Preference>> GetPreferences()
        {
            return  Task.FromResult(Controller.GetPreferences()); 
        }
        public List<Offre> GetOffres()
        {
            return Controller.GetOffres();
        }

        public Task <int> InsertOffre(Offre offre)
        {
            return Task.FromResult((offre != null ? Controller.InsertOffre(offre) : 0));
        }

        public int UpdateOffre(Offre offre)
        {
            return (offre != null ? Controller.UpdateOffre(offre) : 0);
        }

        public int DeleteOffre(Offre offre)
        {
            return (offre != null ? Controller.DeleteOffre(offre) : 0);
        }

       
        public List<Offre> GetOffresFilter(Filtre filtre)
        {
             return Controller.GetOffresFilter(filtre);
        }
    }
}
