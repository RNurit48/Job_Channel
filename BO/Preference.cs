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
    /// Liste les préférence d'un utilisateur en fonction de critères préalablement choisis 
    /// </summary>
    [DataContract]
    public class Preference
    {
        [DataMember]
        public int Id_Preference { get;  set; }

        [DataMember]
        public Poste Id_Poste { get; set; }
        [DataMember]
        public Contrat Id_Contrat { get;  set; }
        [DataMember]
        public Region Id_Region { get;  set; }

        public Preference()
        {
        }

        public Preference(DataRow row)
        {
            DataColumnCollection columns = row.Table.Columns;
            
            this.Id_Poste = columns.Contains("ID_POSTE") ? new Poste(row) : null;
            this.Id_Contrat = columns.Contains("ID_CONTRAT") ? new Contrat(row) : null;
            this.Id_Region = columns.Contains("ID_REGION") ? new Region(row) : null;
            this.Id_Preference = (int)row["ID_PREFERENCE"];
        }
    }
}
