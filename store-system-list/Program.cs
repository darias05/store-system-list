using System;
using System.Collections.Generic;
using store_system_list.DTO;
using store_system_list.DAO;
using store_system_list.Logic;

namespace store_system_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación de Lista de clients
            CreateClients createClients = new CreateClients();
            List<Dto_Client> clients = createClients.CreateClient();

            //Creación de lista de sellers
            CreateSellers createSellers = new CreateSellers();
            List<Dto_Seller> sellers = createSellers.CreateSeller();

            //Creación de Lista de products
            CreateProducts createProducts = new CreateProducts();
            List<Dto_Product> products = createProducts.CreateProduct();

            //Creación de Lista de sales
            CreateSales createSales = new CreateSales();
            List<Dto_Sale> sales = createSales.CreateSale(clients, sellers, products);

            //Creación de Nodos de clients
            Dao_ClientNode dao_ClientNode = new Dao_ClientNode();
            Dto_ClientNode clientsNode = dao_ClientNode.CreateClientsNodes(clients);

            //Creación de Nodos de sellers
            Dao_SellerNode dao_SellerNode = new Dao_SellerNode();
            Dto_SellerNode sellersNode = dao_SellerNode.CreateSellersNodes(sellers);

            //Creación de Nodos de products
            Dao_ProductNode dao_ProductNode = new Dao_ProductNode();
            Dto_ProductNode productsNode = dao_ProductNode.CreateProductsNodes(products);

            //Creación de Nodos de sales
            Dao_SaleNode dao_SaleNode = new Dao_SaleNode();
            Dto_SaleNode salesNode = dao_SaleNode.CreateSalesNodes(sales);

            LogicStoreSystem logicStoreSystem = new LogicStoreSystem();

            //Console.WriteLine("---- Punto 1: Importe total de ventas ----");
            //logicStoreSystem.TotalAmountSales(salesNode);

            //Console.WriteLine("\n---- Punto 2: Nombre del cliente que ha realizado la compra más importante ----");
            //logicStoreSystem.SaleMoreImportant(salesNode);

            //Console.WriteLine("\n---- Punto 3: Producto que está obteniendo más ventas ----");
            //logicStoreSystem.BestSellingProduct(salesNode);

            //Console.WriteLine("\n---- Punto 4: Promedio de ventas ----");
            //logicStoreSystem.SalesAverage(salesNode);

            //Console.WriteLine("\n---- Punto 5: Stock de productos: Informar existencias de cada producto ----");
            //logicStoreSystem.StockProducts(salesNode);

            //Console.WriteLine("\n---- Punto 6: Insertar y eliminar clientes ----");
            //logicStoreSystem.PrintClients(clientsNode);
            //clientsNode = logicStoreSystem.UpdateClients(clientsNode);
            //clientsNode = logicStoreSystem.returnPoint6(clientsNode);

            //Console.WriteLine("\n---- Punto 7: Insertar y eliminar productos ----");
            //logicStoreSystem.PrintProducts(productsNode);
            //productsNode = logicStoreSystem.UpdateProducts(productsNode);
            //productsNode = logicStoreSystem.returnPoint7(productsNode);

            //Console.WriteLine("\n---- Punto 8: Insertar y eliminar vendedores ----");
            //logicStoreSystem.PrintSellers(sellersNode);
            //sellersNode = logicStoreSystem.UpdateSellers(sellersNode);
            //sellersNode = logicStoreSystem.returnPoint8(sellersNode);

            Console.WriteLine("\n---- Punto 9: Crear nuevas ventas (se debe tener en cuenta la cantidad de productos) ----");
            Console.WriteLine("");
            logicStoreSystem.PrintSales(salesNode);
            salesNode = logicStoreSystem.UpdateSales(salesNode, clientsNode, sellersNode, productsNode);
            salesNode = logicStoreSystem.returnPoint9(salesNode, clientsNode, sellersNode, productsNode);
        }
    }
}
