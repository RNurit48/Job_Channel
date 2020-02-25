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
    /// Représente le DAO qui gère la table poste de la  BDD
    /// </summary>
    public class PosteDAO : DAO
    {
        /// <summary>
        /// Effectue la connexion avec la BDD 
        /// </summary>
        /// <param name="sQLManager"></param>
        public PosteDAO(SQLManager sQLManager) : base(sQLManager)
        {
        }
        private SQLManager connexion = SQLManager.GetInstance();
        /// <summary>
        /// Récupère la liste des postes
        /// </summary>
        /// <returns></returns>
        public List<Poste> GetAllPoste()
        {
            List<Poste> retour = new List<Poste>();

            DataSet dataset = connexion.ExcecuteQuery("SELECT * FROM POSTE", new List<SqlParameter>());

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                retour.Add(new Poste(row));
            }
            return retour;

        }
    }
}
