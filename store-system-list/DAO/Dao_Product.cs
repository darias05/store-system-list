using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;

namespace store_system_list.DAO
{
    public class Dao_Product
    {
        public List<Dto_Product> CreateProduct(List<int> Code, List<string> Name, List<double> Price, List<string> Category, List<int> Stock)
        {
            List<Dto_Product> Product = new List<Dto_Product>();

            for (int i = 0; i < Name.Count; i++)
            {
                Product.Add(new Dto_Product()
                {
                    Code = Code[i],
                    Name = Name[i],
                    Price = Price[i],
                    Category = Category[i],
                    Stock = Stock[i]
                });
            }

            return Product;
        }
    }
}
