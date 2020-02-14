using System;
using System.Collections.Generic;
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
    }
}
