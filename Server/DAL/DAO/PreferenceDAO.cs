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
    /// Représente le DAO qui gère la table préférence de la  BDD
    /// </summary>
    public class PreferenceDAO : DAO
    {
        /// <summary>
        /// Effectue la connexion avec la BDD 
        /// </summary>
        /// <param name="sQLManager"></param>
        public PreferenceDAO(SQLManager sQLManager) : base(sQLManager)
        {
        }
        private SQLManager connexion = SQLManager.GetInstance();
        /// <summary>
        /// Récupère la liste des préférences
        /// </summary>
        /// <returns></returns>
        public List<Preference> GetAllPreference()
        {
            List<Preference> retour = new List<Preference>();

            DataSet dataset = connexion.ExcecuteQuery("SELECT * FROM PREFERENCE", new List<SqlParameter>());

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                retour.Add(new Preference(row));
            }
            return retour;

        }
    }
}
