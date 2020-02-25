using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data;
using System.Data.SqlClient;

namespace DAL.DAO
{
    /// <summary>
    /// Représente le DAO qui gère la table utilisateur de la  BDD
    /// </summary>
    public class UtilisateurDAO : DAO
    {
        /// <summary>
        /// Effectue la connexion avec la BDD 
        /// </summary>
        /// <param name="sQLManager"></param>
        public UtilisateurDAO(SQLManager sQLManager) : base(sQLManager)
        {
        }
        private SQLManager connexion = SQLManager.GetInstance();

        /// <summary>
        /// Récupère la liste des utilisateurs
        /// </summary>
        /// <returns></returns>
        public List<Utilisateur> GetAllUser()
        {
            List<Utilisateur> retour = new List<Utilisateur>();

            DataSet dataset = connexion.ExcecuteQuery("SELECT * FROM UTILISATEUR", new List<SqlParameter>());

            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                retour.Add(new Utilisateur(row));
            }
            return retour;

        }


    }
}
