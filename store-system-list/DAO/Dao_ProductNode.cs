using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;

namespace store_system_list.DAO
{
    public class Dao_ProductNode
    {
        public Dto_ProductNode productsNode;
        public Dto_ProductNode Head;

        public Dto_ProductNode CreateProductsNodes(List<Dto_Product> Product)
        {
            for (int i = 0; i < Product.Count; i++)
            {
                productsNode = AddProduct(Product[i]);
            }

            return productsNode;
        }

        public Dto_ProductNode AddProduct(Dto_Product product)
        {
            Dto_ProductNode productNode = new Dto_ProductNode();
            productNode.Product = product;

            if (Head == null)
            {
                Head = productNode;
            }
            else
            {
                Dto_ProductNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = productNode;
            }

            return Head;
        }
    }
}
