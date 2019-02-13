using Dapper;
using Loan.DTO.ViewModels;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan.DAL.Repositories
{
    /// <summary>
    /// Get loan and it's details.
    /// </summary>
    public class LoanDetailsRepository : ILoanDetailsRepository
    {
        private readonly IConfiguration _config;
        private readonly string _connectionString;

        public LoanDetailsRepository(IConfiguration config)
        {
            this._config = config;
        }

        public LoanDetailsRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        /// <summary>
        /// Select all loan and it's details.
        /// </summary>
        /// <returns></returns>
        public List<LoanDetailsViewModel> SelectAll()
        {
            using (IDbConnection connection = Connection)
            {
                StringBuilder query = new StringBuilder();
                query.Append("Select Loan.LoanId, Number as LoanNumber, Name as LoanName,");
                query.Append("Balance, BalanceWithInterest, RepaymentFee, (Balance + BalanceWithInterest + RepaymentFee) as PayoutCarryOverAmount ");
                query.Append("From Loan ");
                query.Append("inner join LoanDetail ");
                query.Append("on Loan.LoanId = LoanDetail.LoanId ");
                connection.Open();
                var result = connection.Query<LoanDetailsViewModel>(query.ToString());
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
                if (_config != null)
                {
                    return new SqlConnection(_config.GetConnectionString("LoanDBConnectionString"));
                }
                else
                {
                    return new SqlConnection(_connectionString);
                }

            }
        }

    }
}
