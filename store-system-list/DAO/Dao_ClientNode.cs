using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;

namespace store_system_list.DAO
{
    public class Dao_ClientNode
    {
        public Dto_ClientNode clientsNode;
        public Dto_ClientNode Head;

        public Dto_ClientNode CreateClientsNodes(List<Dto_Client> Client)
        {
            for (int i = 0; i < Client.Count; i++)
            {
                clientsNode = AddClient(Client[i]);
            }

            return clientsNode;
        }

        public Dto_ClientNode AddClient(Dto_Client client)
        {
            Dto_ClientNode clientNode = new Dto_ClientNode();
            clientNode.Client = client; 

            if (Head == null)
            {
                Head = clientNode;
            }
            else
            {
                Dto_ClientNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = clientNode;
            }

            return Head;
        }
    }
}
