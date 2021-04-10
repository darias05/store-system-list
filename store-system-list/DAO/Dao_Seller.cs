using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;

namespace store_system_list.DAO
{
    public class Dao_Seller
    {
        public List<Dto_Seller> CreateSeller(List<int> Code, List<string> Name, List<int> Document, List<string> Gender,
                                         List<int> Age, List<string> Phone, List<int> Stratum)
        {
            List<Dto_Seller> sellers = new List<Dto_Seller>();

            for (int i = 0; i < Name.Count; i++)
            {
                sellers.Add(new Dto_Seller()
                {
                    Code = Code[i],
                    Name = Name[i],
                    Document = Document[i],
                    Gender = Gender[i],
                    Age = Age[i],
                    Phone = Phone[i],
                    Stratum = Stratum[i]
                });
            }

            return sellers;
        }
    }
}
