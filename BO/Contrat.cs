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
    /// Représente un contrat avec ses différents paramètres
    /// </summary>
    [DataContract]
    public class Contrat
    {
        [DataMember]
        public int Id_Contrat { get;  set; }
        [DataMember]
        public string Type { get; set; }

        public Contrat()
        {
        }

        public Contrat(DataRow row)
        {
            this.Id_Contrat = (int)row["ID_CONTRAT"];
            this.Type = ((string)row["CONTRAT"]).Trim();
        }

        public override string ToString()
        {
            return Type;
        }

        public override bool Equals(object obj)
        {
            return obj is Contrat contrat &&
                   Type == contrat.Type;
        }

        public override int GetHashCode()
        {
            return 2049151605 + EqualityComparer<string>.Default.GetHashCode(Type);
        }
    }
}
