using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;

namespace store_system_list.DAO
{
    public class Dao_SellerNode
    {
        public Dto_SellerNode sellersNode;
        public Dto_SellerNode Head;

        public Dto_SellerNode CreateSellersNodes(List<Dto_Seller> Seller)
        {
            for (int i = 0; i < Seller.Count; i++)
            {
                sellersNode = AddSeller(Seller[i]);
            }

            return sellersNode;
        }

        public Dto_SellerNode AddSeller(Dto_Seller seller)
        {
            Dto_SellerNode sellerNode = new Dto_SellerNode();
            sellerNode.Seller = seller;

            if (Head == null)
            {
                Head = sellerNode;
            }
            else
            {
                Dto_SellerNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = sellerNode;
            }

            return Head;
        }
    }
}
