using BO;
using BO.DTO;
using DAL.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    /// <summary>
    /// Représente le DAO qui gère la table offre de la  BDD
    /// </summary>
    public class OffreDAO : DAO
    {
        /// <summary>
        /// Effectue la connexion avec la BDD 
        /// </summary>
        /// <param name="sQLManager"></param>
        public OffreDAO(SQLManager sQLManager) : base(sQLManager)
        {
        }
        private SQLManager connexion = SQLManager.GetInstance();
        /// <summary>
        /// Récupère toute les offres
        /// </summary>
        /// <returns></returns>
        public List<Offre> GetAllOffre()
        {
            List<Offre> retour = new List<Offre>();

            DataSet dataset = connexion.ExcecuteQuery(@"
                SELECT * FROM OFFRE 
                INNER JOIN REGION ON OFFRE.ID_REGION = REGION.ID_REGION
                INNER JOIN CONTRAT ON OFFRE.ID_CONTRAT = CONTRAT.ID_CONTRAT
                INNER JOIN POSTE ON OFFRE.ID_POSTE = POSTE.ID_POSTE", new List<SqlParameter>());

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                retour.Add(new Offre(row));
            }
            return retour;
        

        }
        #region filtrage
        /// <summary>
        /// Récupère les offres selon un ou plusieurs filtres
        /// </summary>
        /// <returns>Retourne une liste d'offre</returns>
        public List<Offre> GetOffreByFilter (Filtre filtre)
        {
            List<Offre> retour = new List<Offre>();
            string query = @"SELECT * FROM OFFRE 
                INNER JOIN REGION ON OFFRE.ID_REGION = REGION.ID_REGION
                INNER JOIN CONTRAT ON OFFRE.ID_CONTRAT = CONTRAT.ID_CONTRAT
                INNER JOIN POSTE ON OFFRE.ID_POSTE = POSTE.ID_POSTE";
            var parameters = new List<SqlParameter>();

            query = AddFilterQuery(query, "OFFRE.ID_REGION", "@ID_REGION", "=", filtre.region?.Id_Region, parameters);
            query = AddFilterQuery(query, "OFFRE.ID_CONTRAT", "@ID_CONTRAT", "=", filtre.contrat?.Id_Contrat, parameters);
            query = AddFilterQuery(query, "OFFRE.ID_POSTE", "@ID_POSTE", "=", filtre.poste?.Id_Poste, parameters);
            DataSet dataSet = SQLManager.ExcecuteQuery(query, parameters);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                retour.Add(new Offre(row));
            }
            return retour;

        }
        private string AddFilterQuery<T>(string query, string member, string paramName, string opr, T value, List<SqlParameter> parameters)
        {
            if (value != null)
            {
                if (parameters.Count == 0)
                {
                    query += " WHERE ";
                }
                else
                {
                    query += " AND ";
                }
                query += $" {member} {opr} {paramName} ";
                parameters.Add(new SqlParameter(paramName, value));
            }
            return query;
        }
        #endregion filtrage

        /// <summary>
        /// Permet d'ajouter une offre
        /// </summary>
        /// <param name="offre"></param>
        /// <returns></returns>
        public int InsertOffre(Offre offre)
        {           
         int retour = connexion.ExecuteNonProcStocke("InsertOffre", new List<SqlParameter>()
         { 
            new SqlParameter("@region", offre.Region.Id_Region),
            new SqlParameter("@contrat", offre.Contrat.Id_Contrat),
            new SqlParameter("@poste", offre.Poste.Id_Poste),
            new SqlParameter("@titre", offre.Titre),
            new SqlParameter("@description", offre.Description),
            new SqlParameter("@date",offre.DatePublication),
            new SqlParameter("@lien",offre.Lien)
         });
           return retour;
        }
        /// <summary>
        /// Update d'une offre
        /// </summary>
        /// <param name="offre"></param>
        /// <returns></returns>
        public int UpdateOffre(Offre offre)
        {
            
            int retour = connexion.ExecuteNonProcStocke("UpdateOffre", new List<SqlParameter>()
         {
            new SqlParameter("@ID_REGION", offre.Region.Id_Region),
            new SqlParameter("@ID_CONTRAT", offre.Contrat.Id_Contrat),
            new SqlParameter("@ID_POSTE", offre.Poste.Id_Poste),
            new SqlParameter("@TITRE", offre.Titre),
            new SqlParameter("@DESCRIPTION", offre.Description),
            new SqlParameter("@DATEPUBLI",offre.DatePublication),
            new SqlParameter("@LIEN",offre.Lien),
            new SqlParameter("@NUMOFFRE", offre.NumOffre)
         });
            return retour;
        }

        public int DeleteOffre(Offre offre)
        {
            int retour = connexion.ExecuteNonProcStocke("DeleteOffre", new List<SqlParameter>()
         {
            new SqlParameter("@NUMOFFRE", offre.NumOffre)
         });
            return retour;
        }

       
    }
}
