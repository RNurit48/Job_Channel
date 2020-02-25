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
    /// Représente le DAO qui gère la table région de la  BDD
    /// </summary>
    public class RegionDAO : DAO
    {
        /// <summary>
        /// Effectue la connexion avec la BDD 
        /// </summary>
        /// <param name="sQLManager"></param>
        public RegionDAO(SQLManager sQLManager) : base(sQLManager)
        {
        }
        private SQLManager connexion = SQLManager.GetInstance();

        /// <summary>
        /// Récupère la liste des régions
        /// </summary>
        /// <returns></returns>
        public List<Region> GetAllRegion()
        {
            List<Region> retour = new List<Region>();

            DataSet dataset = connexion.ExcecuteQuery("SELECT * FROM REGION", new List<SqlParameter>());

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                retour.Add(new Region(row));
            }
            return retour;

        }
    }
}
