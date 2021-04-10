using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;

namespace store_system_list.DAO
{
    public class Dao_SaleNode
    {
        public Dto_SaleNode salesNode;
        public Dto_SaleNode Head;

        public Dto_SaleNode CreateSalesNodes(List<Dto_Sale> Sale)
        {
            for (int i = 0; i < Sale.Count; i++)
            {
                salesNode = AddSale(Sale[i]);
            }

            return salesNode;
        }

        public Dto_SaleNode AddSale(Dto_Sale sale)
        {
            Dto_SaleNode saleNode = new Dto_SaleNode();
            saleNode.Sale = sale;

            if (Head == null)
            {
                Head = saleNode;
            }
            else
            {
                Dto_SaleNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = saleNode;
            }

            return Head;
        }
    }
}
