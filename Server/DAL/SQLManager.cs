using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Connexion à la BDD du projet
    /// </summary>
    public class SQLManager
    {
        /// <summary>
        /// Instance unique
        /// </summary>
        private static SQLManager _instance;

        /// <summary>
        /// Attributs de la connexion
        /// </summary>
        protected SqlConnection connexion;

        /// <summary>
        /// Constructeur par défaut privé
        /// </summary>
        private SQLManager()
        {
            try
            {
                connexion = new SqlConnection();
                connexion.ConnectionString = "User id=user18;password=711user18;server=176.31.248.137;Trusted_Connection=no;database=user18";
                connexion.Open();
            }
            catch (SqlException e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Méthode pour récupérer l'instance unique
        /// </summary>
        /// <returns></returns>
        public static SQLManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SQLManager();
            }
            return _instance;
        }

        /// <summary>
        /// Permet exécuter une requête en BDD
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataSet ExcecuteQuery(string requete, List<SqlParameter> parameters)
        {
            DataSet objDataSet = new DataSet();
            try
            {
                SqlCommand objSelectCommand = new SqlCommand(requete);
                foreach (SqlParameter param in parameters)
                    objSelectCommand.Parameters.Add(param);

                objSelectCommand.Connection = this.connexion;
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
                objDataAdapter.Fill(objDataSet);
            }
            catch (InvalidOperationException e)
            {

                Console.Error.WriteLine(e.Message);
            }

            return objDataSet;
        }

        /// <summary>
        /// Permet exécuter une procédure stockée en BDD
        /// </summary>
        /// <param name="nomProc"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataSet ExecuteProcStocke(string nomProc, List<SqlParameter> parameters)
        {
            DataSet objDataSet = new DataSet();
            try
            {
                SqlCommand objSelectCommand = new SqlCommand();
                objSelectCommand.CommandText = nomProc;
                objSelectCommand.CommandType = CommandType.StoredProcedure;
                objSelectCommand.Connection = this.connexion;
                foreach (SqlParameter param in parameters)
                    objSelectCommand.Parameters.Add(param);

                //Exécute 
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
                objDataAdapter.Fill(objDataSet);
            }
            catch (InvalidOperationException e)
            {

                Console.Error.WriteLine(e.Message);
            }

            return objDataSet;
        }

    }
}
