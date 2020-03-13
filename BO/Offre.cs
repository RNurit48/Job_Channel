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
    /// Représente une offre avec les différentes informations
    /// </summary>
    [DataContract]
    public  class Offre
    {
        private int v;

        [DataMember]
        public string Titre { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public DateTime DatePublication { get; set; }
        [DataMember]
        public Region  Region { get; set; }
        [DataMember]
        public Contrat Contrat { get; set; }
        [DataMember]
        public Poste Poste { get; set; }
        [DataMember]
        public string Lien { get; set; }
        [DataMember]
        public int NumOffre { get; private set; }
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
            this.DatePublication = (!columns.Contains("DATEPUBLICATION")) || row["DATEPUBLICATION"] == DBNull.Value ? new DateTime() : Convert.ToDateTime(row["DATEPUBLICATION"]);
            this.Lien = (!columns.Contains("LIEN")) || row["LIEN"] == DBNull.Value ? null : (string)row["LIEN"]; ;
            this.NumOffre = (!columns.Contains("NUMOFFRE")) || row["NUMOFFRE"] == DBNull.Value ? -1 : (int)row["NUMOFFRE"];
        }

        public Offre(string titre, string description, DateTime datePublication, Region region, Contrat contrat, Poste poste, string lien)
        {
            Titre = titre;
            Description = description;
            DatePublication = datePublication;
            Region = region;
            Contrat = contrat;
            Poste = poste;
            Lien = lien;
        }

        public Offre(string titre, string description, DateTime datePublication, Region region, Contrat contrat, Poste poste, string lien, int numOffre) 
        {
            Titre = titre;
            Description = description;
            DatePublication = datePublication;
            Region = region;
            Contrat = contrat;
            Poste = poste;
            Lien = lien;
            NumOffre = numOffre;
        }

        public Offre(int numOffre) { NumOffre = numOffre; }

    }
}
