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
        /// Chaîne de connexion à la BDD
        /// </summary>
        protected String ConnectionString = "User id=user18;password=711user18;server=176.31.248.137;Trusted_Connection=no;database=user18";
        /// <summary>
        /// Constructeur par défaut privé
        /// </summary>
        private SQLManager()
        {
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
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(requete, sqlConnection))
                {
                    DataSet objDataSet = new DataSet();
                    try
                    {
                        sqlConnection.Open();
                        foreach (SqlParameter param in parameters)
                            sqlCommand.Parameters.Add(param);
                        
                        SqlDataAdapter objDataAdapter = new SqlDataAdapter(sqlCommand);
                        objDataAdapter.Fill(objDataSet);
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (InvalidOperationException e)
                    {

                        Console.Error.WriteLine(e.Message);
                    }

                    return objDataSet;
                }
            }
        }

        /// <summary>
        /// Permet exécuter une procédure stockée en BDD
        /// </summary>
        /// <param name="nomProc"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataSet ExecuteProcStocke(string nomProc, List<SqlParameter> parameters)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(nomProc, sqlConnection))
                {
                    DataSet objDataSet = new DataSet();
                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        foreach (SqlParameter param in parameters)
                            sqlCommand.Parameters.Add(param);

                        //Exécute 
                        SqlDataAdapter objDataAdapter = new SqlDataAdapter(sqlCommand);
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


        /// <summary>
        /// Permet d’exécuter une requête ne renvoyant rien
        /// </summary>
        /// <param name="requete"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// 

        public int ExecuteNonQuery(string requete, List<SqlParameter> parameters = null)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(requete, sqlConnection))
                {
                    try
                    {
                        //méthode qui ouvre la connexion à la BDD
                        sqlConnection.Open();
                        if (parameters != null)
                        {
                            foreach (SqlParameter param in parameters)
                                sqlCommand.Parameters.Add(param);
                        }
                        //sortie du résultat de la requête
                        return sqlCommand.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        throw new DAOException("Problème de connexion");
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
                    // Si erreur
                    return -1;
                }
            }
        }
        /// <summary>
        /// Permet d’exécuter une procédure ne renvoyant rien
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// 
        public int ExecuteNonProcStocke(string procedureName, List<SqlParameter> parameters = null)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(procedureName, sqlConnection))
                {
                    try
                    {
                        //méthode qui ouvre la connexion à la BDD
                        sqlConnection.Open();
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            foreach (SqlParameter param in parameters)
                                sqlCommand.Parameters.Add(param);
                        }
                        return sqlCommand.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        throw new DAOException("Problème de connexion");
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
                    return -1;
                }
            }
        }
    }
}
