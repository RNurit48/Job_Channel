﻿using BO;
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

        [OperationContract]
        [WebGet(UriTemplate = "utilisateurs", ResponseFormat = WebMessageFormat.Json)]
        List<Utilisateur> GetUtilisateurs();

        [OperationContract]
        [WebGet(UriTemplate = "preferences", ResponseFormat = WebMessageFormat.Json)]
        List<Preference> GetPreferences();

        [OperationContract]
        [WebGet(UriTemplate = "offres", ResponseFormat = WebMessageFormat.Json)]
        List<Offre> GetOffres();

        [OperationContract]
        [WebInvoke(UriTemplate = "offres", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        int InsertOffre(Offre offre);
    }
    
}
