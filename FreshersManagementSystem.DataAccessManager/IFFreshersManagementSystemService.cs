using FreshersManagementSystem.Model;
using System.Data;

namespace FreshersManagementSystem.DataAccessManager
{
    /// <summary>
    /// its implements an application to manage an data between view and data access model
    /// </summary>
    public interface IFFreshersManagementSystemService
    {
        /// <summary>
        /// Its get and add insert the freshers details
        /// </summary>
        /// <param name="fresher">the fresher which want to be insert</param>
        /// <returns> the id of an fresher</returns>
        int InsertFresher(Fresher fresher);

        /// <summary>
        /// Its get and update fresher details
        /// </summary>
        /// <param name="fresher">the fresher which want to be update</param>
        /// <returns></returns>
        int UpdateFresher(Fresher fresher);

        /// <summary>
        /// Its gets fresher id and delete the currosponding fresher
        /// </summary>
        /// <param name="fresherId">The id for which fresher want to be delete</param>
        /// <returns></returns>
        string DeleteFresher(int fresherId);

        /// <summary>
        /// Gets all freshers details
        /// </summary>
        /// <returns name="frehsrs">The list of frehsers which want to be search</returns>
        DataTable FetchAllFreshers();

        /// <summary>
        /// Gets user name and search the frsher according to respective freshers name
        /// </summary>
        /// <param name="freshersName">The frehser name which want to be search</param>
        /// <returns name="frehsrs">The list of frehsers which want to be search</returns>
        DataTable SearchFresherByName(string freshersName);
    }
}
