using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente les différents type de poste. Développeur, Analyste, Chef de Projet ...
    /// </summary>
    public class Poste
    {
        public int Id_Poste { get; private set; }
        public string Type { get; set; }

        public Poste()
        {
        }

        public Poste(DataRow row)
        {
        }
    }
}
