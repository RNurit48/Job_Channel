using DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configuration
{/// <summary>
/// Regroupe les connections aux différents DAO du projet
/// </summary>
   public static class ConfigDAO
    {
        private static SQLManager sqlManager = SQLManager.GetInstance();
        /// <summary>
        /// regroupe les connexions aux différents DAO du projet
        /// </summary>
        #region
        public static UtilisateurDAO utilisateurDAO = new UtilisateurDAO(sqlManager);
        public static PosteDAO posteDAO = new PosteDAO(sqlManager);
        public static RegionDAO regionDAO = new RegionDAO(sqlManager);
        public static OffreDAO offreDAO = new OffreDAO(sqlManager);
        public static PreferenceDAO preferenceDAO = new PreferenceDAO(sqlManager);
        public static ContratDAO contratDAO = new ContratDAO(sqlManager);
        #endregion
    }
}
