using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BO.DTO
{
   
    [DataContract]
   public class Filtre
    {
        [DataMember]
        public Region region;
        [DataMember]
        public Contrat contrat;
        [DataMember]
        public Poste poste;
       
        public Filtre(Region region, Contrat contrat, Poste poste)
        {
            
            this.region = region;
            this.contrat = contrat;
            this.poste = poste;

        }

        public Filtre() { }
    }
}
