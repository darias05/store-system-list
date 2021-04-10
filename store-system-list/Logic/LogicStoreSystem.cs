using System;
using System.Collections.Generic;
using System.Text;
using store_system_list.DTO;

namespace store_system_list.Logic
{
    public class LogicStoreSystem
    {
        public void TotalAmountSales(Dto_SaleNode saleNode)
        {
            int countSales = 1;
            double totalAmount = 0;

            Dto_SaleNode last = saleNode;
            while (last.Next != null)
            {
                countSales++;
                last = last.Next;
            }

            for (int i = 0; i < countSales; i++)
            {
                totalAmount = saleNode.Sale.Total_Price + totalAmount;
                
                if (saleNode.Next != null)
                {
                    saleNode = saleNode.Next;
                }
            }

            Console.WriteLine("\nSe realizaron un total de " + countSales + " ventas, por un valor de $" + totalAmount + " Dolares");
        }

        public void SaleMoreImportant(Dto_SaleNode saleNode)
        {
            string clientName = "";
            string productName = "";
            double totalPrice = 0;
            double valuesell = 0;
            int countSales = 1;

            Dto_SaleNode last = saleNode;
            while (last.Next != null)
            {
                countSales++;
                last = last.Next;
            }

            for (int i = 0; i < countSales; i++)
            {
                double price = saleNode.Sale.Total_Price;

                if (valuesell == 0)
                {
                    clientName = saleNode.Sale.Client.Name;
                    productName = saleNode.Sale.Product.Name;
                    totalPrice = saleNode.Sale.Total_Price;
                    valuesell = totalPrice;
                }
                else if (price > valuesell)
                {
                    clientName = saleNode.Sale.Client.Name;
                    productName = saleNode.Sale.Product.Name;
                    totalPrice = saleNode.Sale.Total_Price;
                    valuesell = totalPrice;
                }

                if (saleNode.Next != null)
                {
                    saleNode = saleNode.Next;
                }
            }

            Console.WriteLine("\nNombre del cliente: " + clientName);
            Console.WriteLine("Nombre del producto: " + productName);
            Console.WriteLine("Valor total de la venta: " + totalPrice);
        }

        public void BestSellingProduct(Dto_SaleNode saleNode)
        {
            string productName = "";
            int sales = 0;
            int countSales = 1;
            int countSalesProduct = 0;

            Dto_SaleNode last = saleNode;
            while (last.Next != null)
            {
                countSales++;
                last = last.Next;
            }

            while (saleNode.Next != null)
            {
                string iteratorProductName = saleNode.Sale.Product.Name;
                Dto_SaleNode iteratorNode = saleNode;
                countSalesProduct = 0;

                if (productName != iteratorProductName)
                {

                    for (int i = 1; i < countSales; i++)
                    {
                        if (iteratorNode.Sale.Product.Name == iteratorProductName)
                        {
                            countSalesProduct++;
                        }

                        if (iteratorNode.Next != null)
                        {
                            iteratorNode = iteratorNode.Next;
                        }
                    }
                }

                if (countSalesProduct > sales)
                {
                    productName = iteratorProductName;
                    sales = countSalesProduct;
                }

                saleNode = saleNode.Next;
            }
            Console.WriteLine("\nEl producto mas vendido es el " + productName + " con un total de " + sales + " ventas.");
        }

        public void SalesAverage(Dto_SaleNode saleNode)
        {
            double productsPriceAverage;
            double totalAmount = 0;
            int countSales = 1;

            Dto_SaleNode last = saleNode;
            while (last.Next != null)
            {
                countSales++;
                last = last.Next;
            }            

            for (int i = 0; i < countSales; i++)
            {
                totalAmount = saleNode.Sale.Total_Price + totalAmount;

                if (saleNode.Next != null)
                {
                    saleNode = saleNode.Next;
                }
            }

            productsPriceAverage = totalAmount / countSales;
            Console.WriteLine("\nEl precio promedio de venta de los " + countSales + " productos es de = " + productsPriceAverage);
        }

        public void StockProducts(Dto_SaleNode saleNode)
        {
            int countSales = 1;
            string productName;
            int stockProdut;
            int results = 0;

            Dto_SaleNode last = saleNode;
            while (last.Next != null)
            {
                countSales++;
                last = last.Next;
            }

            last = saleNode;
            Console.WriteLine("");

            for (int i = 0; i < countSales; i++)
            {
                Dto_SaleNode iteratorNode = last;
                Dto_SaleNode iteratorNodeConsole = last;
                productName = saleNode.Sale.Product.Name;
                stockProdut = saleNode.Sale.Product.Stock;
                int repeatedProductInConsole = 0;

                for (int j = 0; j < countSales; j++)
                {
                    if (iteratorNode.Sale.Product.Name == productName)
                    {
                        stockProdut = stockProdut - iteratorNode.Sale.Quantity;
                    }

                    if (iteratorNode.Next != null)
                    {
                        iteratorNode = iteratorNode.Next;
                    }
                }

                if (saleNode.Next != null)
                {
                    saleNode = saleNode.Next;
                }

                for (int k = 0; k < results; k++)
                {
                    
                    if (iteratorNodeConsole.Sale.Product.Name == productName)
                    {
                        repeatedProductInConsole++;
                    }

                    if (iteratorNodeConsole.Next != null)
                    {
                        iteratorNodeConsole = iteratorNodeConsole.Next;
                    }
                }

                if (repeatedProductInConsole == 0)
                {
                    Console.WriteLine("El producto " + productName + " tiene una cantidad de " + stockProdut + " stocks disponibles");
                }
                
                results++;
            }
        }

        public void PrintClients(Dto_ClientNode clientsNode)
        {
            int countClients = 1;
            int Code;
            string Name;
            int Document;

            if (clientsNode != null)
            {
                Dto_ClientNode last = clientsNode;
                while (last.Next != null)
                {
                    countClients++;
                    last = last.Next;
                }

                for (int i = 0; i < countClients; i++)
                {
                    Code = clientsNode.Client.Code;
                    Name = clientsNode.Client.Name;
                    Document = clientsNode.Client.Document;
                    Console.WriteLine("Code: " + Code + " Name: " + Name + " Document: " + Document);
                    clientsNode = clientsNode.Next;
                }
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("No cuentas con ningun Vendedor");
            }
        }

        public void PrintProducts(Dto_ProductNode productNode)
        {
            int countProducts = 1;
            int Code;
            string Name;
            double Price;

            if (productNode != null)
            {
                Dto_ProductNode last = productNode;
                while (last.Next != null)
                {
                    countProducts++;
                    last = last.Next;
                }

                Console.WriteLine(" ");

                for (int i = 0; i < countProducts; i++)
                {
                    Code = productNode.Product.Code;
                    Name = productNode.Product.Name;
                    Price = productNode.Product.Price;
                    Console.WriteLine("Code: " + Code + " Name: " + Name + " Precio: " + Price);
                    productNode = productNode.Next;
                }
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("No cuentas con ningun Vendedor");
            }
        }

        public void PrintSellers(Dto_SellerNode sellerNode)
        {
            int countProducts = 1;
            int Code;
            string Name;
            int Document;

            if (sellerNode != null)
            {
                Dto_SellerNode last = sellerNode;
                while (last.Next != null)
                {
                    countProducts++;
                    last = last.Next;
                }

                Console.WriteLine(" ");

                for (int i = 0; i < countProducts; i++)
                {
                    Code = sellerNode.Seller.Code;
                    Name = sellerNode.Seller.Name;
                    Document = sellerNode.Seller.Document;
                    Console.WriteLine("Code: " + Code + " Name: " + Name + " Documento: " + Document);
                    sellerNode = sellerNode.Next;
                }
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("No cuentas con ningun Vendedor");
            }
        }

        public void PrintSales(Dto_SaleNode saleNode)
        {
            int countProducts = 1;

            Dto_SaleNode last = saleNode;
            while (last.Next != null)
            {
                countProducts++;
                last = last.Next;
            }

            Dto_SaleNode node = saleNode;
            for (int i = 0; i < countProducts; i++)
            {
                int code = saleNode.Sale.Code;
                string nameClient = saleNode.Sale.Client.Name;
                string nameProduct = saleNode.Sale.Product.Name;
                int quantity = saleNode.Sale.Quantity;
                double totalPrice = saleNode.Sale.Total_Price;
                int availableStock = ReviewStockProducts(saleNode.Sale, node);
                Console.WriteLine("Code Sale: " + code + " Client Name: " + nameClient + " Product Name: " + nameProduct + " Quantity: " + quantity + " Total price: " + totalPrice + " Available Stock: " + availableStock);
                saleNode = saleNode.Next;
            }
        }

        public int ReviewStockProducts(Dto_Sale sale, Dto_SaleNode saleNode)
        {
            int countSales = 1;
            string productName;
            int productCode;
            int stockProdut;
            int stock = 0;

            Dto_SaleNode last = saleNode;
            while (last.Next != null)
            {
                countSales++;
                last = last.Next;
            }

            last = saleNode;

            for (int i = 0; i < countSales; i++)
            {
                Dto_SaleNode iteratorNode = last;
                productName = saleNode.Sale.Product.Name;
                productCode = saleNode.Sale.Product.Code;
                stockProdut = saleNode.Sale.Product.Stock;

                for (int j = 0; j < countSales; j++)
                {
                    if (iteratorNode.Sale.Product.Name == productName)
                    {
                        stockProdut = stockProdut - iteratorNode.Sale.Quantity;
                    }

                    if (iteratorNode.Next != null)
                    {
                        iteratorNode = iteratorNode.Next;
                    }
                }

                if (saleNode.Next != null)
                {
                    saleNode = saleNode.Next;
                }

                if (productCode == sale.Product.Code)
                {
                    stock =  stockProdut;
                }
            }
            return stock;
        }

        public int selectedMode(string typeNode)
        {
            string type = "false";
            int selectedMode = 0;

            while (type == "false")
            {
                Console.WriteLine("\nEscribe 1 para adiccionar un " + typeNode + " o Escribe 2 para eliminar un " + typeNode);
                selectedMode = int.Parse(Console.ReadLine());                

                if (selectedMode == 1 || selectedMode == 2)
                {
                    type = "true";
                }
            }

            return selectedMode;
        }

        public int selectedModeSale(string typeNode)
        {
            string type = "false";
            int selectedMode = 0;

            while (type == "false")
            {
                Console.WriteLine("\nEscribe 1 para adiccionar una " + typeNode);
                selectedMode = int.Parse(Console.ReadLine());

                if (selectedMode == 1 || selectedMode == 2)
                {
                    type = "true";
                }
            }

            return selectedMode;
        }

        public Dto_ClientNode UpdateClients(Dto_ClientNode clientsNode)
        {
            Dto_ClientNode Head = clientsNode;
            LogicStoreSystem logicStoreSystem = new LogicStoreSystem();
            int selectedMode = logicStoreSystem.selectedMode("cliente");

            if (selectedMode == 1)
            {
                Dto_Client client = new Dto_Client();
                Console.WriteLine("\nNombre: ");
                client.Name = Console.ReadLine();
                Console.WriteLine("Documento: ");
                client.Document = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Genero: ");
                client.Gender = Console.ReadLine();
                Console.WriteLine("Edad: ");
                client.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Telefono: ");
                client.Phone = Console.ReadLine();
                Console.WriteLine("Estrato: ");
                client.Stratum = int.Parse(Console.ReadLine());

                Dto_ClientNode newClientNode = new Dto_ClientNode();
                newClientNode.Client = client;

                Dto_ClientNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                client.Code = last.Client.Code + 1;
                last.Next = newClientNode;
            }
            else if (selectedMode == 2)
            {
                Dto_ClientNode clients;
                Dto_ClientNode baseClientNode = clientsNode;
                Dto_ClientNode iterator = clientsNode;
                Dto_ClientNode last = clientsNode;
                string type = "false";

                Console.WriteLine("\n¿Que codigo deseas eliminar?: ");
                int deleteCode = int.Parse(Console.ReadLine());

                int countClients = 1;

                if (last != null)
                {
                    while (last.Next != null)
                    {
                        countClients++;
                        last = last.Next;
                    }

                    while (type == "false")
                    {
                        for (int i = 0; i < countClients; i++)
                        {
                            if (iterator.Client.Code == deleteCode)
                            {
                                clients = iterator.Next;
                                if (deleteCode == baseClientNode.Client.Code)
                                {
                                    clientsNode = baseClientNode.Next;
                                    type = "true";
                                    break;
                                }
                                else
                                {
                                    while (baseClientNode.Client.Code != deleteCode)
                                    {
                                        if (baseClientNode.Next != null & baseClientNode.Next.Client.Code != deleteCode)
                                        {
                                            baseClientNode = baseClientNode.Next;
                                            type = "true";
                                        }
                                        else
                                        {
                                            type = "true";
                                            break;
                                        }
                                    }
                                    baseClientNode.Next = clients;
                                }
                            }
                            iterator = iterator.Next;
                        }

                        if (type == "false")
                        {
                            Console.WriteLine("\nEl codigo que deseas eliminar no existe, por favor elige otro");
                            deleteCode = int.Parse(Console.ReadLine());
                            iterator = clientsNode;
                            Console.WriteLine(" ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nNo cuentas con ningun Cliente, por favor selecciona la opcion de agregar o continua");
                }
            }

            return clientsNode;
        }

        public Dto_ProductNode UpdateProducts(Dto_ProductNode productsNode)
        {
            Dto_ProductNode Head = productsNode;
            LogicStoreSystem logicStoreSystem = new LogicStoreSystem();
            int selectedMode = logicStoreSystem.selectedMode("producto");

            if (selectedMode == 1)
            {
                Dto_Product product = new Dto_Product();
                Console.WriteLine("\nNombre: ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Precio: ");
                product.Price = Double.Parse(Console.ReadLine());
                Console.WriteLine("Categoria: ");
                product.Category = Console.ReadLine();
                Console.WriteLine("Stock: ");
                product.Stock = int.Parse(Console.ReadLine());

                Dto_ProductNode newProductNode = new Dto_ProductNode();
                newProductNode.Product = product;

                Dto_ProductNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                product.Code = last.Product.Code + 1;
                last.Next = newProductNode;
            }
            else if (selectedMode == 2)
            {
                Dto_ProductNode products;
                Dto_ProductNode baseProductNode = productsNode;
                Dto_ProductNode iterator = productsNode;
                Dto_ProductNode last = productsNode;
                string type = "false";

                Console.WriteLine("\n¿Que codigo deseas eliminar?: ");
                int deleteCode = int.Parse(Console.ReadLine());

                int countProducts = 1;

                if (last != null)
                {
                    while (last.Next != null)
                    {
                        countProducts++;
                        last = last.Next;
                    }

                    while (type == "false")
                    {
                        for (int i = 0; i < countProducts; i++)
                        {
                            if (iterator.Product.Code == deleteCode)
                            {
                                products = iterator.Next;
                                if (deleteCode == baseProductNode.Product.Code)
                                {
                                    productsNode = baseProductNode.Next;
                                    type = "true";
                                    break;
                                }
                                else
                                {
                                    while (baseProductNode.Product.Code != deleteCode)
                                    {
                                        if (baseProductNode.Next != null & baseProductNode.Next.Product.Code != deleteCode)
                                        {
                                            baseProductNode = baseProductNode.Next;
                                            type = "true";
                                        }
                                        else
                                        {
                                            type = "true";
                                            break;
                                        }
                                    }
                                    baseProductNode.Next = products;
                                }
                            }
                            iterator = iterator.Next;
                        }

                        if (type == "false")
                        {
                            Console.WriteLine("\nEl codigo que deseas eliminar no existe, por favor elige otro");
                            deleteCode = int.Parse(Console.ReadLine());
                            iterator = productsNode;
                            Console.WriteLine(" ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nNo cuentas con ningun Producto, por favor selecciona la opcion de agregar o continua");
                }
            }
            return productsNode;
        }

        public Dto_SellerNode UpdateSellers(Dto_SellerNode sellersNode)
        {
            Dto_SellerNode Head = sellersNode;
            LogicStoreSystem logicStoreSystem = new LogicStoreSystem();
            int selectedMode = logicStoreSystem.selectedMode("vendedor");

            if (selectedMode == 1)
            {
                Dto_Seller seller = new Dto_Seller();
                Console.WriteLine("\nNombre: ");
                seller.Name = Console.ReadLine();
                Console.WriteLine("Documento: ");
                seller.Document = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Genero: ");
                seller.Gender = Console.ReadLine();
                Console.WriteLine("Edad: ");
                seller.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Telefono: ");
                seller.Phone = Console.ReadLine();
                Console.WriteLine("Estrato: ");
                seller.Stratum = int.Parse(Console.ReadLine());

                Dto_SellerNode newSellerNode = new Dto_SellerNode();
                newSellerNode.Seller = seller;

                Dto_SellerNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                seller.Code = last.Seller.Code + 1;
                last.Next = newSellerNode;
            }
            else if (selectedMode == 2)
            {
                Dto_SellerNode sellers;
                Dto_SellerNode baseSellerNode = sellersNode;
                Dto_SellerNode iterator = sellersNode;
                Dto_SellerNode last = sellersNode;
                string type = "false";

                Console.WriteLine("\n¿Que codigo deseas eliminar?: ");
                int deleteCode = int.Parse(Console.ReadLine());

                int countSellers = 1;

                if (last != null)
                {
                    while (last.Next != null)
                    {
                        countSellers++;
                        last = last.Next;
                    }

                    while (type == "false")
                    {
                        for (int i = 0; i < countSellers; i++)
                        {
                            if (iterator.Seller.Code == deleteCode)
                            {
                                sellers = iterator.Next;
                                if (deleteCode == baseSellerNode.Seller.Code)
                                {
                                    sellersNode = baseSellerNode.Next;
                                    type = "true";
                                    break;
                                }
                                else
                                {
                                    while (baseSellerNode.Seller.Code != deleteCode)
                                    {
                                        if (baseSellerNode.Next != null & baseSellerNode.Next.Seller.Code != deleteCode)
                                        {
                                            baseSellerNode = baseSellerNode.Next;
                                            type = "true";
                                        }
                                        else
                                        {
                                            type = "true";
                                            break;
                                        }
                                    }
                                    baseSellerNode.Next = sellers;
                                }
                            }
                            iterator = iterator.Next;
                        }

                        if (type == "false")
                        {
                            Console.WriteLine("\nEl codigo que deseas eliminar no existe, por favor elige otro");
                            deleteCode = int.Parse(Console.ReadLine());
                            iterator = sellersNode;
                            Console.WriteLine(" ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nNo cuentas con ningun Vendedor, por favor selecciona la opcion de agregar o continua");
                }
            }
            return sellersNode;
        }

        public Tuple<Dto_Client, Dto_Seller, Dto_Product> selectItemsForSale(string typeNode, Dto_ClientNode clientsNode, Dto_SellerNode sellersNode, Dto_ProductNode productsNode)
        {
            string type = "false";
            int countProducts = 1;
            int countClients = 1;
            int countSellers = 1;
            Dto_Client client = null;
            Dto_Seller seller = null;
            Dto_Product product = null;
            Dto_ProductNode lastProductsCount = productsNode;
            Dto_ClientNode lastClientsCount = clientsNode;
            Dto_SellerNode lastSellersCount = sellersNode;

            while (lastProductsCount.Next != null)
            {
                countProducts++;
                lastProductsCount = lastProductsCount.Next;
            }

            while (lastClientsCount.Next != null)
            {
                countClients++;
                lastClientsCount = lastClientsCount.Next;
            }

            while (lastSellersCount.Next != null)
            {
                countSellers++;
                lastSellersCount = lastSellersCount.Next;
            }

            Console.WriteLine("\nEscribe el codigo del " + typeNode + " que desea adicionar");
            int Code = int.Parse(Console.ReadLine());

            while (type == "false")
            {
                if (typeNode == "producto")
                {
                    Dto_ProductNode lastProduct = productsNode;

                    for (int i = 0; i < countProducts; i++)
                    {
                        if (lastProduct.Product.Code == Code)
                        {
                            product = lastProduct.Product;
                            type = "true";
                        }
                        lastProduct = lastProduct.Next;
                    }
                }
                else if (typeNode == "cliente")
                {
                    Dto_ClientNode lastClient = clientsNode;

                    for (int i = 0; i < countClients; i++)
                    {
                        if (lastClient.Client.Code == Code)
                        {
                            client = lastClient.Client;
                            type = "true";
                        }
                        lastClient = lastClient.Next;
                    }
                }
                else
                {
                    Dto_SellerNode lastSeller = sellersNode;

                    for (int i = 0; i < countSellers; i++)
                    {
                        if (lastSeller.Seller.Code == Code)
                        {
                            seller = lastSeller.Seller;
                            type = "true";
                        }
                        lastSeller = lastSeller.Next;
                    }
                }

                if (type == "false")
                {
                    Console.WriteLine("\nEscribe otro codigo de " + typeNode + " ya que el codigo " + Code + " no se encuentra disponible");
                    Code = int.Parse(Console.ReadLine());
                }
            }
            return Tuple.Create(client, seller, product);
        }

        public Dto_SaleNode UpdateSales(Dto_SaleNode salesNode, Dto_ClientNode clientsNode, Dto_SellerNode sellersNode, Dto_ProductNode productsNode)
        {
            Dto_SaleNode Head = salesNode;
            LogicStoreSystem logicStoreSystem = new LogicStoreSystem();
            int selectedModeSale = logicStoreSystem.selectedModeSale("venta");
            int quantity;
            int availableStock;

            if (selectedModeSale == 1)
            {
                string type = "false";
                Dto_Sale sale = new Dto_Sale();
                sale.Product = logicStoreSystem.selectItemsForSale("producto", clientsNode, sellersNode, productsNode).Item3;
                sale.Client = logicStoreSystem.selectItemsForSale("cliente", clientsNode, sellersNode, productsNode).Item1;
                sale.Seller = logicStoreSystem.selectItemsForSale("vendedor", clientsNode, sellersNode, productsNode).Item2;
                Console.WriteLine("\nCantidad: ");
                quantity = int.Parse(Console.ReadLine());

                while (type == "false")
                {
                    availableStock = ReviewStockProducts(sale, salesNode);

                    if (quantity <= availableStock)
                    {
                        sale.Quantity = quantity;
                        type = "true";
                    }
                    else if (availableStock == 0)
                    {
                        Console.WriteLine("\nPor favor selecciona otro producto, ya que cuenta con " + availableStock + " unidades disponibles");
                        sale.Product = logicStoreSystem.selectItemsForSale("producto", clientsNode, sellersNode, productsNode).Item3;
                        Console.WriteLine("\nCantidad: ");
                        quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("\nPor favor selecciona otra cantidad, el producto solo cuenta con " + availableStock + " unidades disponibles");
                        quantity = int.Parse(Console.ReadLine());
                    }
                }

                Dto_SaleNode newSaleNode = new Dto_SaleNode();
                newSaleNode.Sale = sale;

                Dto_SaleNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                sale.Code = last.Sale.Code + 1;
                sale.Total_Price = sale.Quantity * sale.Product.Price;
                last.Next = newSaleNode;
            }

            return salesNode;
        }

        public Dto_ClientNode returnPoint6(Dto_ClientNode clientsNode)
        {
            string type = "false";
            LogicStoreSystem logicStoreSystem = new LogicStoreSystem();
            logicStoreSystem.PrintClients(clientsNode);

            while (type == "false")
            {
                Console.WriteLine("\nEscribe 1 para volver a elegir una opcion u otro numero para continuar ");
                int selectedMode = int.Parse(Console.ReadLine());

                if (selectedMode == 1)
                {
                    clientsNode = logicStoreSystem.UpdateClients(clientsNode);
                    logicStoreSystem.PrintClients(clientsNode);
                }
                else
                {
                    type = "true";
                }
            }
            return clientsNode;
        }

        public Dto_ProductNode returnPoint7(Dto_ProductNode productsNode)
        {
            string type = "false";
            LogicStoreSystem logicStoreSystem = new LogicStoreSystem();
            logicStoreSystem.PrintProducts(productsNode);

            while (type == "false")
            {
                Console.WriteLine("\nEscribe 1 para volver a elegir una opcion u otro numero para continuar ");
                int selectedMode = int.Parse(Console.ReadLine());

                if (selectedMode == 1)
                {
                    productsNode = logicStoreSystem.UpdateProducts(productsNode);
                    logicStoreSystem.PrintProducts(productsNode);
                }
                else
                {
                    type = "true";
                }
            }
            return productsNode;
        }

        public Dto_SellerNode returnPoint8(Dto_SellerNode sellersNode)
        {
            string type = "false";
            LogicStoreSystem logicStoreSystem = new LogicStoreSystem();
            logicStoreSystem.PrintSellers(sellersNode);

            while (type == "false")
            {
                Console.WriteLine("\nEscribe 1 para volver a elegir una opcion u otro numero para continuar ");
                int selectedMode = int.Parse(Console.ReadLine());

                if (selectedMode == 1)
                {
                    sellersNode = logicStoreSystem.UpdateSellers(sellersNode);
                    logicStoreSystem.PrintSellers(sellersNode);
                }
                else
                {
                    type = "true";
                }
            }
            return sellersNode;
        }

        public Dto_SaleNode returnPoint9(Dto_SaleNode salesNode, Dto_ClientNode clientsNode, Dto_SellerNode sellersNode, Dto_ProductNode productsNode)
        {
            string type = "false";
            LogicStoreSystem logicStoreSystem = new LogicStoreSystem();
            logicStoreSystem.PrintSales(salesNode);

            while (type == "false")
            {
                Console.WriteLine("\nEscribe 1 para volver a elegir una opcion u otro numero para finalizar ");
                int selectedMode = int.Parse(Console.ReadLine());

                if (selectedMode == 1)
                {
                    salesNode = logicStoreSystem.UpdateSales(salesNode, clientsNode, sellersNode, productsNode);
                    logicStoreSystem.PrintSales(salesNode);
                }
                else
                {
                    type = "true";
                }
            }
            return salesNode;
        }
    }
}
