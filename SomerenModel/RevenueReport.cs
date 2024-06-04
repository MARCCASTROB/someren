using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel  
{
    public class RevenueReport 
    {
        public int totalConsumedDrink;
        public decimal totalTurnover;
        public int totalCustomers;

        public RevenueReport(int totalCustomers, int totalConsumedDrink, decimal totalTurnover ) 
        {
            this.totalCustomers = totalCustomers;
            this.totalConsumedDrink = totalConsumedDrink;
            this.totalTurnover = totalTurnover; 
        }
    }
}
