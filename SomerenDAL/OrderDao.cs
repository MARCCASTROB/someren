using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {

        public void CreateNewOrder(Orders newOrder)
        {
            string query = @"
                            INSERT INTO ORDERS(DrinkID,StudentNumber,AmountConsumed, OrderDateTime)
                            VALUES (@DrinkID, @StudentNumber, @AmountInStock, @OrderDateTime);
            ";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@DrinkID", newOrder.DrinkID),
                new SqlParameter("@StudentNumber", newOrder.StudentID),
                new SqlParameter("@AmountInStock", newOrder.AmountConsumed),
                new SqlParameter("@OrderDateTime", newOrder.OrderDateTime)
            };
            OpenConnection();
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateStockInventory(int drinkID, int amountConsumed)
        {
            string query = @"
                        UPDATE DRINK
	                    SET AmountInStock -= @AmountConsumed
	                    WHERE DrinkID = @DrinkID
            ;";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@DrinkID", drinkID),
                new SqlParameter("@AmountConsumed", amountConsumed),
                
            };
            OpenConnection();
            ExecuteEditQuery(query, sqlParameters);
        }


        private List<Orders> ReadTablesDrinks(DataTable dataTable)
        {
            List<Orders> ordersList = new List<Orders>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Orders order = new Orders(
                 (int) dr["OrderID"],
                 (int)dr["DrinkID"],
                   (int)dr["StudentNumber"],
                   (int)dr["AmountConsumed"],
                   (DateTime)dr["OrderDateTime"]
               );
                ordersList.Add(order);
            }
            return ordersList;
        }
    }
}
