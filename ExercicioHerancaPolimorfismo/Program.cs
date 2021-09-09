using System;
using System.Collections.Generic;
using ExercicioHerancaPolimorfismo.Entities;

namespace ExercicioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {


            // ***** Start ***** //


            //Variáveis temporárias//
            string nameProduct;
            double priceProduct;
            double customsFeeProduct;
            DateTime manufactureDate;
            //Variáveis temporárias//

            //Variáveis//
            int numberProducts;
            char typeProduct;
            //Variáveis//

            //Listas//
            List<Product> listProduct = new List<Product>();
            //Listas//

            //Entrada//
            Console.Write("Enter the number of products: ");
            numberProducts = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= numberProducts; i++)
            {

                Console.WriteLine($"*** Product #{i} data ***");
                Console.Write("Common, used or imported (c/u/i)?: ");
                typeProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                nameProduct = Console.ReadLine();
                Console.Write("Price: ");
                priceProduct = double.Parse(Console.ReadLine());

                if(typeProduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    manufactureDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine();

                    listProduct.Add (new UsedProduct(nameProduct, priceProduct, manufactureDate));
                }

                else if (typeProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    customsFeeProduct = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    listProduct.Add(new ImportedProduct(nameProduct, priceProduct, customsFeeProduct));
                }

                else
                {
                    listProduct.Add(new Product(nameProduct, priceProduct));
                    Console.WriteLine();
                }
                                
            }
            //Entrada//

            //Saída//
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product product in listProduct)
            {
                Console.WriteLine(product.PriceTag());
            }
            //Saída//
        }
    }
}
