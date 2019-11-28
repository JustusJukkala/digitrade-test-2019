using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa tuotteiden nimet ja yhteishinnat");
            // Esitellään ja alustetaan taulukko muuttujat
            decimal[] productPrice = new decimal[] { 7.96M, 72.0M, 99.90M };
            int[] productAmount = new int[] { 1, 3, 2 };
            decimal[] productTotalPrice = new decimal[3]; // Tässä asetetaan taulukon luvut

            productTotalPrice = PriceCalculator(productPrice, productAmount);
            PrintTotalPrice(productTotalPrice);
            //productTotalPrice[0] = productPrice[0] * productAmount[0]; huono ratkaisu
            //productTotalPrice[1] = productPrice[1] * productAmount[1];
            //productTotalPrice[2] = productPrice[2] * productAmount[2];
        }

        /// <summary>
        /// The function calculate the process of the products using the given arrays.
        /// </summary>
        /// <param name="productPrice"></param>
        /// <param name="productAmount"></param>
        /// <returns></returns>
        static decimal[] PriceCalculator(decimal[] productPrice, int[] productAmount)
        {
            // Määritetään taulukko productTotalPrice. Taulukon koko määräytyy tuotteiden määrän mukaan
            decimal[] productTotalPrice = new decimal[productAmount.Length];
            for (int i = 0; i < productAmount.Length; i++)
            {
                productTotalPrice[i] = productPrice[i] * productAmount[i];
            }
            return productTotalPrice;
        }

        /// <summary>
        /// The function print all data from array
        /// </summary>
        static void PrintTotalPrice(decimal[] productTotalPrice)
        {
            for (int i = 0; i < productTotalPrice.Length; i++)
            {
                Console.WriteLine($"Tuote {i+1}: {productTotalPrice[i]:C}");
            }
        }
    }
}