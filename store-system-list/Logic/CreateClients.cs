using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;
using store_system_list.DAO;

namespace store_system_list.Logic
{
    public class CreateClients
    {
        public List<Dto_Client> CreateClient()
        {
            List<int> Code = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            List<string> Name = new List<string>()
            {
                "Cristian Andres", "Juan Solarte", "Camila Martinez", "Angela Cardona", "Dylan Arias"
            };

            List<int> Document = new List<int>()
            {
                1234, 2345, 3456, 4567, 5678
            };

            List<string> Gender = new List<string>()
            {
                "M", "M", "F", "F", "M"
            };

            List<int> Age = new List<int>()
            {
                21, 23, 25, 24, 20
            };

            List<string> Phone = new List<string>()
            {
                "3104980526", "3204506559", "3104989853", "3226779634", "3143506559"
            };

            List<int> Stratum = new List<int>()
            {
                1, 2, 4, 2, 6,
            };

            Dao_Client Obj_Dao_Client = new Dao_Client();
            List<Dto_Client> List_Clients = Obj_Dao_Client.CreateClient(Code, Name, Document, Gender, Age, Phone, Stratum);

            return List_Clients;
         }
    }
}
