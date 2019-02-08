using Dapper;
using Loan.DTO.ViewModels;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Linq;

namespace Loan.DAL.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly IConfiguration _config;

        public LoanRepository(IConfiguration config)
        {
            this._config = config;
        }

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

        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("LoanDBConnectionString"));
            }
        }
    }
}
