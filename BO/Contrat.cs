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
            this.Type = (string)row["CONTRAT"];
        }

    }
}
