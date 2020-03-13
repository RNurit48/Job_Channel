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
    /// Liste les différentes régions
    /// </summary>
    [DataContract]
    public class Region
    {
      
        [DataMember]
        public int Id_Region { get;set; }
        [DataMember]
        public string Nom { get; set; }

        public Region()
        {
        }

        public Region(DataRow row)
        {
            this.Id_Region = (int)row["ID_REGION"];
            this.Nom = ((string)row["NOM_REGION"]).Trim();
        }

        public Region(int id_Region, string nom)
        {
            Id_Region = id_Region;
            Nom = nom;
        }

        public override string ToString()
        {
            return Nom ;
        }
    }
}
