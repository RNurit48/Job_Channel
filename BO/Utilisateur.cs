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
    /// Représente un utilisateur avec toute les informations le concernant
    /// </summary>
    [DataContract]
    public class Utilisateur
    {
       
        [DataMember]
        public int Id_Utilisateur { get;  set; }
        [DataMember]
        public Preference Preference { get;  set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public string Prenom { get; set; }
        [DataMember]
        public string Login { get;  set; }
        
        public string Password { get;  set; }

        [DataMember]
        public string Role { get;  set; }

        public Utilisateur()
        {
        }
        
        public Utilisateur(DataRow row)
        {
            DataColumnCollection columns = row.Table.Columns;

            this.Id_Utilisateur = (int)row["ID_UTILISATEUR"];
            this.Nom = columns.Contains("NOM") ? (string)row["NOM"] : null;
            this.Prenom = columns.Contains("PRENOM") ? (string)row["PRENOM"] : null;
            this.Login = (string)row["LOGIN"];
            this.Password = (string)row["PASSWORD"];
            this.Role = (string)row["ROLE"];
            //this.Preference = ((!columns.Contains("ID_PREFERENCE")) || row["ID_PREFERENCE"] == DBNull.Value )?  null  : new Preference(row);
        }
    }
}
