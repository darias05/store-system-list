using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;
using store_system_list.DAO;

namespace store_system_list.Logic
{
    public class CreateSellers
    {
        public List<Dto_Seller> CreateSeller()
        {
            List<int> Code = new List<int>()
            {
                1, 2, 3
            };

            List<string> Name = new List<string>()
            {
                "Andres Felipe", "Camilo Suarez", "Mariana Arias"
            };

            List<int> Document = new List<int>()
            {
                6789, 7891, 8910
            };

            List<string> Gender = new List<string>()
            {
                "M", "M", "F"
            };

            List<int> Age = new List<int>()
            {
                21, 27, 30
            };

            List<string> Phone = new List<string>()
            {
                "3204980526", "3154506559", "3114989853"
            };

            List<int> Stratum = new List<int>()
            {
                3, 2, 2
            };

            Dao_Seller Obj_Dao_Seller = new Dao_Seller();
            List<Dto_Seller> List_Sellers = Obj_Dao_Seller.CreateSeller(Code, Name, Document, Gender, Age, Phone, Stratum);

            return List_Sellers;
        }
    }
}
