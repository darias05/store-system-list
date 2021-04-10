using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;

namespace store_system_list.DAO
{
    public class Dao_Client
    {
        public List<Dto_Client> CreateClient(List<int> Code, List<string> Name, List<int> Document, List<string> Gender, 
                                         List<int> Age, List<string> Phone, List<int> Stratum)
        {
            List<Dto_Client> clients = new List<Dto_Client>();

            for (int i = 0; i < Name.Count; i++)
            {
                clients.Add(new Dto_Client()
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

            return clients;
        }
    }
}
