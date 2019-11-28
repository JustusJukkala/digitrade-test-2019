using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa tuotteiden nimet ja yhteishinnat");
            // Esitellään ja alustetaan taulukko muuttujat
            decimal[] productPrice = new decimal[] { 7.96M, 72.0M, 99.90M };
            int[] productAmount = new int[] { 1, 3, 2 };
            decimal[] productTotalPrice = new decimal[3]; // Tässä asetetaan taulukon luvut

            for (int i = 0; i < productAmount.Length; i++)
            {
                productTotalPrice[i] = productPrice[i] * productAmount[i];
            }

            //productTotalPrice[0] = productPrice[0] * productAmount[0]; huono ratkaisu
            //productTotalPrice[1] = productPrice[1] * productAmount[1];
            //productTotalPrice[2] = productPrice[2] * productAmount[2];
        }

        static 
    }
}