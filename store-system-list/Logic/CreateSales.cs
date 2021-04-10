using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DAO;
using store_system_list.DTO;

namespace store_system_list.Logic
{
    public class CreateSales
    {
        public List<Dto_Sale> CreateSale(List<Dto_Client> Clients, List<Dto_Seller> Sellers, List<Dto_Product> Products)
        {
            List<int> Code = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
                13, 14, 15, 16, 17, 18, 19, 20, 21, 22,
                23
            };

            List<int> Quantity = new List<int>()
            {
                5, 7, 8, 13, 5, 18, 21, 2,
                7, 3, 6, 13, 5, 8, 7, 1,
                2, 4, 5, 12, 14, 1, 1
            };

            Dao_Sale dao_Sales = new Dao_Sale();
            List<Dto_Sale> List_Sales = dao_Sales.CreateSale(Code, Products, Clients, 
                               Sellers, Quantity);

            return List_Sales;
        }
    }
}
