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
    /// Représente le DAO qui gère la table contrat de la  BDD
    /// </summary>
    public class ContratDAO : DAO
    {
        /// <summary>
        /// Effectue la connexion avec la BDD 
        /// </summary>
        /// <param name="sQLManager"></param>
        public ContratDAO(SQLManager sQLManager) : base(sQLManager)
        {
        }

        private SQLManager connexion = SQLManager.GetInstance();
        /// <summary>
        /// Récupère la liste des contrats
        /// </summary>
        /// <returns></returns>
        public List<Contrat> GetAllContrats()
        {
            List<Contrat> retour = new List<Contrat>();

            DataSet dataset = connexion.ExcecuteQuery("SELECT * FROM CONTRAT", new List<SqlParameter>());

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                retour.Add(new Contrat(row));
            }
            return retour;

        }
    }
}
