using System;
using System.Collections.Generic;
using System.Text;

namespace store_system_list.DTO
{
    public class Dto_Sale
    {
        public int Code;
        public Dto_Product Product;
        public Dto_Client Client;
        public Dto_Seller Seller;
        public int Quantity;
        public double Total_Price;
    }
}
