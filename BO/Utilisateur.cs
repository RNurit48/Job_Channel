using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente un utilisateur avec toute les informations le concernant
    /// </summary>
    public class Utilisateur
    {
        private DataRow row;

        public int Id_Utilisateur { get; private set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }

        public Utilisateur()
        {
        }

        public Utilisateur(DataRow row)
        {
            this.row = row;
        }
    }
}
