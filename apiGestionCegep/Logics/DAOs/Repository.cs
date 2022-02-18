using System.Data.SqlClient;

/// <summary>
/// Namespace pour les classe de type DAO.
/// </summary>
namespace APIGestionCegep.Logics.DAOs
{
    /// <summary>
    /// Classe représentant un repository.
    /// </summary>
    public class Repository
    {
        #region AttributsPropriete

        /// <summary>
        /// La connexion.
        /// </summary>
        protected SqlConnection connexion;

        #endregion AttributsPropriete

        #region Constructeurs
        /// <summary>
        /// Constructeur de la classe.
        /// </summary>
        protected Repository()
        {
            connexion = new SqlConnection("Server = 10.172.80.43; Database = Cegep2; User Id=Alex;Password=microsoftAlex;");
            //connexion = new SqlConnection("Server = 172.16.208.22; Database = Cegep2; User Id=Alex;Password=microsoftAlex;");
        }

        #endregion Constructeurs

        #region MethodesService

        /// <summary>
        /// Méthode permettant d'ouvrir la connexion.
        /// </summary>
        protected void OuvrirConnexion()
        {
            connexion.Open();
        }

        /// <summary>
        /// Méthode permettant de fermer la connexion.
        /// </summary>
        protected void FermerConnexion()
        {
            connexion.Close();
        }

        #endregion MethodesService
    }
}
