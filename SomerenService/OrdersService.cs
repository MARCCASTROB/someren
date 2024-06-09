using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class OrdersService
    {
        public OrderDao OrderDao;

        public OrdersService()
        {
            OrderDao = new OrderDao();
        }

        public void CreateOrder(Orders newOrder)
        {
            OrderDao.CreateNewOrder(newOrder);
        }

        public void UpdateStockInventory(int drinkID, int AmountConsumed) 
        {
            OrderDao.UpdateStockInventory(drinkID, AmountConsumed);
        }

        // revenue 
        public List<Orders> GetOrders()
        {
            return OrderDao.GetAll();
        }

        public int CountAmountOfClients(DateTime startDate, DateTime endDate)
        {
            return OrderDao.CountAmountOfClients(startDate, endDate);
        }

        public bool RightDates(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                return false;
            }

            return true;
        }

        public void DisplayNumberOfCustomers(DateTime startDate, DateTime endDate, out string numberOfCustomers)
        {
            int studentCount = CountAmountOfClients(startDate, endDate);

            numberOfCustomers = $"{studentCount} Customers";
        }

        public void DisplayTurnover(List<Orders> orders, DateTime startDate, DateTime endDate, out string turnover)
        {
            decimal totalRevenue = 0m;

            foreach (var order in orders)
            {
                if (order.OrderDateTime >= startDate && order.OrderDateTime <= endDate)
                    totalRevenue += order.DrinkID.Price * order.Quantity;
            }

            turnover = $"€{totalRevenue} Earned";
        }

        public void DisplayTotalSales(List<Orders> orders, DateTime startDate, DateTime endDate, out string totalSales)
        {
            int totalSoldDrinks = 0;

            foreach (var order in orders)
            {
                if (order.OrderDateTime >= startDate && order.OrderDateTime <= endDate)
                    totalSoldDrinks += order.Quantity;
            }

            totalSales = $"{totalSoldDrinks} Drinks sold";
        }
    }
}
