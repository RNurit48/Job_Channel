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
        [DataMember]
        public DateTime debut;
        [DataMember]
        public DateTime fin;

        /// <summary>
        /// Passe un objet filtre avec != parametres permettant de filtrer 
        /// </summary>
        /// <param name="region"></param>
        /// <param name="contrat"></param>
        /// <param name="poste"></param>
        /// <param name="debut"></param>
        /// <param name="fin"></param>
        public Filtre(Region region, Contrat contrat, Poste poste, DateTime debut, DateTime fin)
        {
            
            this.region = region;
            this.contrat = contrat;
            this.poste = poste;
            this.debut = debut;
            this.fin = fin;
        }

        public Filtre() { }

        
    }
}
