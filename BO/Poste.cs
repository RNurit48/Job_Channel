using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente les différents type de poste. Développeur, Analyste, Chef de Projet ...
    /// </summary>
    [DataContract]
    public class Poste
    {
        [DataMember]
        public int Id_Poste { get; set; }
        [DataMember]
        public string Type { get; set; }

        public Poste()
        {
        }

        public Poste(DataRow row)
        {
            this.Id_Poste = (int)row["ID_POSTE"];
            this.Type = ((string)row["TYPE_POSTE"]).Trim();
        }

        public override string ToString()
        {
            return Type;
        }
    }
}
