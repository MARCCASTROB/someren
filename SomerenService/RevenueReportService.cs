using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class RevenueReportService
    {
        RevenueReportDao revenueReportDao;

        public RevenueReportService() 
        {
            revenueReportDao = new RevenueReportDao();  
        }

        public List<RevenueReport> GenerateRevenueReport(DateTime startDate, DateTime endate)
        {
             return revenueReportDao.GetRevenueRecords( startDate,  endate);             
        }
    }
}
