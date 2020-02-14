using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Accessible par toute les couches
    /// </summary>
    public class Utilisateur
    {
        public int Id_Utilisateur { get; private set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }

        public Utilisateur()
        {
        }
    }
}
