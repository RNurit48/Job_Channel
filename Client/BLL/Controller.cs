using BO;
using BO.DTO;
using Newtonsoft.Json;
using NuGet.Common;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL
{
    public class Controller
    {
        RestClient RestClient = new RestClient("http://localhost:58884/Annonce.svc");

        private string ParseJson(object obj)
        {
            var settings = new JsonSerializerSettings()
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            return JsonConvert.SerializeObject(obj, settings);
        }

        public List<Contrat> GetAllContrats()
        {
           
            RestRequest requete = new RestRequest("contrats", Method.GET);
          IRestResponse<List<Contrat>>retour = RestClient.Execute<List<Contrat>>(requete);

            
            if (retour.StatusCode == HttpStatusCode.OK)
            {
                return retour.Data;
            }
            return new List<Contrat>();
        }
        public  List<Region> GetAllRegions()
        {
            List<Region> r = null;
            //instanciation d'un RestRequest avec la route et la méthode GET appelé
            RestRequest requete = new RestRequest("regions", Method.GET);
            //envoi de la requete avec attente de la reponse et désérialisation de la reponse en liste de région
           IRestResponse<List<Region>> retour = RestClient.Execute<List<Region>>(requete);
            //si retour status code ==200
            
            if (retour.StatusCode == HttpStatusCode.OK)
            {
                //retour des data
                return retour.Data;
            }
            //si pas de status ok alors renvoi d'une liste vide
            return new List<BO.Region>();
        }

        public List<Poste> GetAllPostes()
        {

            //instanciation d'un RestRequest avec la route et la méthode GET appelé
            RestRequest requete = new RestRequest("postes", Method.GET);
            //envoi de la requete avec attente de la reponse et désérialisation de la reponse en liste de région
           IRestResponse<List<Poste>> retour = RestClient.Execute<List<Poste>>(requete);
            //si retour status code ==200
           
            if (retour.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //retour des data
                return retour.Data;
            }
            //si pas de status ok alors renvoi d'une liste vide
            return new List<Poste>();
        }
        public async Task <List<Utilisateur>> GetUtilisateurs()
        {

            //instanciation d'un RestRequest avec la route et la méthode GET appelé
            RestRequest requete = new RestRequest("utilisateurs", Method.GET);
            requete.RequestFormat = DataFormat.Json;
            //envoi de la requete avec attente de la reponse et désérialisation de la reponse en liste de région
           Task <IRestResponse<List<Utilisateur>>> retour = RestClient.ExecuteAsync<List<Utilisateur>>(requete);
            //si retour status code ==200
            await retour;
            if (retour.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //retour des data
                return retour.Result.Data;
            }
            //si pas de status ok alors renvoi d'une liste vide
            return new List<Utilisateur>();
        }

        public  async Task <List<Preference>> GetPreference()
        {

            //instanciation d'un RestRequest avec la route et la méthode GET appelé
            RestRequest requete = new RestRequest("preferences", Method.GET);
            requete.RequestFormat = DataFormat.Json;
            //envoi de la requete avec attente de la reponse et désérialisation de la reponse en liste de région
          Task  <IRestResponse<List<Preference>>> retour = RestClient.ExecuteAsync<List<Preference>>(requete);
            //si retour status code ==200
            await retour;
            if (retour.Result.StatusCode == HttpStatusCode.OK)
            {
                //retour des data
                return retour.Result.Data;
            }
            //si pas de status ok alors renvoi d'une liste vide
            return new List<Preference>();
        }
        public int PostOffre(Offre offre)
        {
            int resultat = 0;
            //instanciation d'un RestRequest avec la route et la méthode  appelé
            RestRequest requete = new RestRequest("offres", Method.POST);
            requete.AddJsonBody(ParseJson(offre));
            //envoi de la requête avec attente de la réponse et dé-sérialisation de la réponse 
          IRestResponse<int> retour = RestClient.Execute<int>(requete);
            //si retour statut code ==200
           
            if (retour.StatusCode == HttpStatusCode.OK)
            {
                resultat = retour.Data;
                //retour des data
                return resultat;
            }
            resultat = -1;
            //si pas de statut ok alors renvoi -1
            return resultat;



        }

        public List<Offre> GetAllOffres()
        {

            //instanciation d'un RestRequest avec la route et la méthode GET appelé
            RestRequest requete = new RestRequest("offres", Method.GET);
            //envoi de la requete avec attente de la reponse et désérialisation de la reponse en liste de région
            IRestResponse<List<Offre>> retour = RestClient.Execute<List<Offre>>(requete);
            //si retour status code ==200
            if (retour.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //retour des data
                return retour.Data;
            }
            //si pas de status ok alors renvoi d'une liste vide
            return new List<Offre>();
        }

        public List<Offre> GetLastOffres()
        {

            //instanciation d'un RestRequest avec la route et la méthode GET appelé
            RestRequest requete = new RestRequest("lastoffres", Method.GET);
            //envoi de la requete avec attente de la reponse et désérialisation de la reponse en liste de région
            IRestResponse<List<Offre>> retour = RestClient.Execute<List<Offre>>(requete);
            //si retour status code ==200
            if (retour.StatusCode == HttpStatusCode.OK)
            {
                //retour des data
                return retour.Data;
            }
            //si pas de status ok alors renvoi d'une liste vide
            return new List<Offre>();
        }

        public int UpdateOffre(Offre offre)
        {
            int resultat = 0;
            //instanciation d'un RestRequest avec la route et la méthode  appelé
            RestRequest requete = new RestRequest("offres", Method.PUT);
            requete.AddJsonBody(ParseJson(offre));
            //envoi de la requête avec attente de la réponse et dé-sérialisation de la réponse 
            IRestResponse<int> retour = RestClient.Execute<int>(requete);
            //si retour statut code ==200
            if (retour.StatusCode == System.Net.HttpStatusCode.OK)
            {
                resultat = retour.Data;
                //retour des data
                return resultat;
            }
            resultat = -1;
            //si pas de statut ok alors renvoi -1
            return resultat;



        }

        public int DeleteOffre(Offre offre)
        {
            int resultat = 0;
            //instanciation d'un RestRequest avec la route et la méthode  appelé
            RestRequest requete = new RestRequest("offres", Method.DELETE);
            requete.AddJsonBody(ParseJson(offre));
            //envoi de la requête avec attente de la réponse et dé-sérialisation de la réponse 
            IRestResponse<int> retour = RestClient.Execute<int>(requete);
            //si retour statut code ==200
            if (retour.StatusCode == System.Net.HttpStatusCode.OK)
            {
                resultat = retour.Data;
                //retour des data
                return resultat;
            }
            resultat = -1;
            //si pas de statut ok alors renvoi -1
            return resultat;



        }

        public  List<Offre> GetOffresFiltrers(Filtre filtre)
        {

            List<Offre> listOffre = null;
            RestRequest request = new RestRequest("offresFiltrer", Method.POST);
            request.AddJsonBody(ParseJson(filtre));

            IRestResponse<List<Offre>> retour = RestClient.Execute<List<Offre>>(request);
           

            if (retour.StatusCode == HttpStatusCode.OK)
            {
                listOffre = retour.Data;
            }
            return listOffre;
        }

    }
}
