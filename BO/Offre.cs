using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public  class Offre
    {
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DatePublication { get; set; }

        public Offre()
        {
        }
    }
}
