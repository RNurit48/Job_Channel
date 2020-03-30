using BO;
using BO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IAnnonce
    {

        [OperationContract]
        [WebGet(UriTemplate = "contrats", ResponseFormat =WebMessageFormat.Json)]
        List<Contrat> GetContrats();

        [OperationContract]
        [WebGet(UriTemplate = "regions", ResponseFormat = WebMessageFormat.Json)]
        List<Region> GetRegion();

        [OperationContract]
        [WebGet(UriTemplate = "postes", ResponseFormat = WebMessageFormat.Json)]
        List<Poste> GetPostes();

        [OperationContract]
        [WebGet(UriTemplate = "utilisateurs", ResponseFormat = WebMessageFormat.Json)]
       Task <List<Utilisateur>> GetUtilisateurs();

        [OperationContract]
        [WebGet(UriTemplate = "preferences", ResponseFormat = WebMessageFormat.Json)]
       Task <List<Preference>> GetPreferences();

        [OperationContract]
        [WebGet(UriTemplate = "offres", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> GetOffres();

        [OperationContract]
        [WebInvoke(UriTemplate = "offresFiltrer", Method ="POST", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> GetOffresFilter(Filtre filtre);


        [OperationContract]
        [WebInvoke(UriTemplate = "offres", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
       Task <int> InsertOffre(Offre offre);

        [OperationContract]
        [WebInvoke(UriTemplate = "offres", Method = "PUT", ResponseFormat = WebMessageFormat.Json)]
        int UpdateOffre(Offre offre);

        [OperationContract]
        [WebInvoke(UriTemplate = "offres", Method = "DELETE", ResponseFormat = WebMessageFormat.Json)]
        int DeleteOffre(Offre offre);
    }
    
}
