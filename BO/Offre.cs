using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Représente une offre avec les différentes informations
    /// </summary>
   public  class Offre
    {
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DatePublication { get; set; }
        public Region Region { get; set; }
        public Contrat Contrat { get; set; }
        public Poste Poste { get; set; }
        public Offre()
        {
        }

        public Offre(DataRow row)
        {
            DataColumnCollection columns = row.Table.Columns;


            this.Region = columns.Contains("ID_REGION") ? new Region(row) : null;
            this.Contrat = columns.Contains("ID_CONTRAT") ? new Contrat(row) : null; 
            this.Poste = columns.Contains("ID_POSTE") ? new Poste(row) : null; 
            this.Titre = (!columns.Contains("TITRE")) || row["TITRE"] == DBNull.Value ? null : (string)row["TITRE"];
            this.Description = (!columns.Contains("DESCRIPTION")) || row["DESCRIPTION"] == DBNull.Value ? null : (string)row["DESCRIPTION"];
            this.DatePublication = (!columns.Contains("DATEPUBLICATION")) || row["DATEPUBLICATION"] == DBNull.Value ? new DateTime() : Convert.ToDateTime(row["COMM"]);
           

        }
    }
}
