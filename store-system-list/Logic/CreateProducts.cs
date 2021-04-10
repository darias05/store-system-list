using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;
using store_system_list.DAO;

namespace store_system_list.Logic
{
    public class CreateProducts
    {
        public List<Dto_Product> CreateProduct()
        {
            List<int> Code = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
                13, 14, 15, 16, 17, 18, 19, 20, 21, 22,
                23
            };

            List<string> Name = new List<string>()
            {
                "500g pack of chicken breast", "pack of salmon", "pack of salmon",
                "1 liters of semi-skimmed milk", "500g pack of chicken breast", "kg of Greek yogurt", "500g block of cheese",
                "large bag of apples", "bunches of bananas", "bag of mandarins", "cucumber", "onions",
                "frozen vegetable", "pizzas", "frozen fruit", "pack of toilet paper",
                "pack of kitchen roll", "tube of toothpaste", "can of deodorant", "bottle of laundry detergent",
                "bottle of fabric softener", "bottle of washing up liquid", "pack of salmon"
            };

            List<double> Price = new List<double>()
            {
                100, 80, 80, 130, 100, 280, 110, 200,
                100, 55, 60, 150, 78, 150, 230, 300,
                200, 65, 40, 30, 68, 85, 80
            };

            List<string> Category = new List<string>()
            {
                "Meat & fish", "Meat & fish", "Meat & fish",
                "Dairy", "Meat & fish", "Dairy", "Dairy",
                "Vegetables and fruit", "Vegetables and fruit", "Vegetables and fruit", "Vegetables and fruit",
                "Vegetables and fruit", "Freezer", "Freezer", "Freezer",
                "Grooming products", "Grooming products", "Grooming products", "Grooming products",
                "Grooming products", "Grooming products", "Grooming products", "Meat & fish"
            };

            List<int> Stock = new List<int>()
            {
                100, 100, 100, 100, 100, 100, 100, 100,
                100, 100, 100, 100, 100, 100, 100, 100,
                100, 100, 100, 100, 100, 100, 100
            };

            Dao_Product dao_Product = new Dao_Product();
            List<Dto_Product> List_products = dao_Product.CreateProduct(Code, Name, Price, Category, Stock);

            return List_products;
        }
    }
}
