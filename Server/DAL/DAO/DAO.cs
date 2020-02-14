using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    /// <summary>
    /// Classe abstraite d'un data access object
    /// </summary>
    public abstract class DAO
    {
        /// <summary>
        /// Manager de la base donnée SQL
        /// </summary>
        protected SQLManager SQLManager;

        protected DAO(SQLManager sQLManager)
        {
            SQLManager = sQLManager;
        }

    }
}
