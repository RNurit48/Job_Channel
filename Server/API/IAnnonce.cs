using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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
    }
    
}
