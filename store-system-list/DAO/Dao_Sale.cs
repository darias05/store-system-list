using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;

namespace store_system_list.DAO
{
    public class Dao_Sale
    {
        public List<Dto_Sale> CreateSale(List<int> Code, List<Dto_Product> Product, List<Dto_Client> Client, 
                                List<Dto_Seller> Seller, List<int> Quantity)
        {
            List<Dto_Sale> sales = new List<Dto_Sale>();
            int countSeller = 0;
            int countClient = 0;

            for (int i = 0; i < Product.Count; i++)
            {
                if (countSeller < Seller.Count & countClient < Client.Count)
                {
                    sales.Add(new Dto_Sale()
                    {
                        Code = Code[i],
                        Product = Product[i],
                        Client = Client[countClient],
                        Seller = Seller[countSeller],
                        Quantity = Quantity[i],
                        Total_Price = Quantity[i] * Product[i].Price                 
                    });
                    countSeller++;
                    countClient++;
                }
                else
                {
                    if (countSeller == Seller.Count & countClient == Client.Count)
                    {
                        countSeller = 0;
                        countClient = 0;
                        sales.Add(new Dto_Sale()
                        {
                            Code = Code[i],
                            Product = Product[i],
                            Client = Client[countClient],
                            Seller = Seller[countSeller],
                            Quantity = Quantity[i],
                            Total_Price = Quantity[i] * Product[i].Price
                        });
                        countSeller++;
                        countClient++;
                    }
                    else if (countSeller == Seller.Count)
                    {
                        countSeller = 0;
                        sales.Add(new Dto_Sale()
                        {
                            Code = Code[i],
                            Product = Product[i],
                            Client = Client[countClient],
                            Seller = Seller[countSeller],
                            Quantity = Quantity[i],
                            Total_Price = Quantity[i] * Product[i].Price
                        });
                        countSeller++;
                        countClient++;
                    } 
                    else if (countClient == Client.Count)
                    {
                        countClient = 0;
                        sales.Add(new Dto_Sale()
                        {
                            Code = Code[i],
                            Product = Product[i],
                            Client = Client[countClient],
                            Seller = Seller[countSeller],
                            Quantity = Quantity[i],
                            Total_Price = Quantity[i] * Product[i].Price
                        });
                        countSeller++;
                        countClient++;
                    }
                }
            }
            return sales;
        }
    }
}