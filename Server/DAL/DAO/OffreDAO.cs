using System;
using System.Collections.Generic;
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
    }
}
