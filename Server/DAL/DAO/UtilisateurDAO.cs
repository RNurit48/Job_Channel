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

        

    }
}
