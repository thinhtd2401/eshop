using Eshop.Application.Dapper.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eshop.Application.Dapper.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<RevenueReportViewModel>> GetReportAsync(string fromDate, string toDate);
    }
}