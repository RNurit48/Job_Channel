using BO;
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

            DataSet dataset = connexion.ExcecuteQuery("SELECT * FROM OFFRE", new List<SqlParameter>());

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                retour.Add(new Offre(row));
            }
            return retour;
        

        }
        /// <summary>
        /// Récupère les offres selon un ou plusieurs filtres
        /// </summary>
        /// <param name="ID_REGION"> l'identifiant de la région, ex: 1 pour Occitanie ...</param>
        /// <param name="ID_CONTRAT">l'identifiant du contrat. CDI 1, CDD 2, Stage 3 ...</param>
        /// <param name="TITRE">Titre de l'offre, pour rechercher par nom et éviter une liste déroulante avec plusieurs noms qui mènent au même résultat</param>
        /// <returns>Retourne une liste d'offre</returns>
        public List<Offre> GetOffreByFilter(int ID_REGION, int ID_CONTRAT, string TITRE)
        {
            List<Offre> retour = new List<Offre>();
            

            DataSet dataset = connexion.ExecuteProcStocke("GetOffreByFilter", new List<SqlParameter>()
            {
                new SqlParameter("@ID_REGION",ID_REGION),
                new SqlParameter("@ID_CONTRAT",ID_CONTRAT),
                new SqlParameter("@POSTE_NAME",TITRE)
            });
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                retour.Add(new Offre(row));
            }
            return retour;

        }
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
    }
}
