using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Liste les préférence d'un utilisateur en fonction de critères préalablement choisis 
    /// </summary>
   public class Preference
    {
        private DataRow row;

        public int Id_Preference { get; private set; }

        public Preference()
        {
        }

        public Preference(DataRow row)
        {
            this.row = row;
        }
    }
}
