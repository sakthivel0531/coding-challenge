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
    public class LoanDetailsRepository : ILoanDetailsRepository
    {
        private readonly IConfiguration _config;

        public LoanDetailsRepository(IConfiguration config)
        {
            this._config = config;
        }

        public async Task<List<LoanDetailsViewModel>> SelectAll()
        {
            using (IDbConnection connection = Connection)
            {
                StringBuilder query = new StringBuilder();
                query.Append("Select Loan.LoanId, Number as LoanNumber, Name as LoanName,");
                query.Append("Balance, BalanceWithInterest, RepaymentFee");
                query.Append("From Loan");
                query.Append("inner join LoanDetail");
                query.Append("on Loan.LoanId = LoanDetail.LoanId");
                connection.Open();
                var result = await connection.QueryAsync<LoanDetailsViewModel>(query.ToString());
                return result.ToList();
            }
        }

        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("LoanDBConnectionString"));
            }
        }

    }
}
