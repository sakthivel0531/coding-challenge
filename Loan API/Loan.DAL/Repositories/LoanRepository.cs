using Dapper;
using Loan.DTO.ViewModels;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Loan.DAL.Repositories
{
    /// <summary>
    /// Get loan details.
    /// </summary>
    public class LoanRepository : ILoanRepository
    {
        private readonly IConfiguration _config;

        public LoanRepository(IConfiguration config)
        {
            this._config = config;
        }

        /// <summary>
        /// Get all loan details.
        /// </summary>
        /// <returns></returns>
        public async Task<List<LoanViewModel>> SelectAll()
        {
            using (IDbConnection connection = Connection)
            {
                string query = "SELECT LoanId, Name as LoanName, Number as LoanNumber FROM Loan";
                connection.Open();
                var result = await connection.QueryAsync<LoanViewModel>(query);
                return result.ToList();
            }
        }

        /// <summary>
        /// Get connection.
        /// </summary>
        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("LoanDBConnectionString"));
            }
        }
    }
}
