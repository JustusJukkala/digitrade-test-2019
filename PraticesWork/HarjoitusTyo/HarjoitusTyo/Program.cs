using System;
using System.IO;

namespace HarjoitusTyo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string input = string.Empty;//tämä pitää määrittää tyhjäksi, että inputit toimii switch casessa

            char userChoice;//Tämä kutsuu käyttöliittymää

            do
            {
                Console.Clear();//tyhjentä konsolin
                userChoice = UserInterface();
                switch (userChoice)
                {
                    case '1':
                        try
                        {
                            Console.Write("Syötä viitenumero, jonka haluat tarkistaa:");
                            input = InputValue(input, 4, 20);
                            if (CheckReferenceNumberValidity(input) == true && IsNumber(input) == true
                                && ValidLenght(input, 4, 20) == true && FirstNumberNotZero(input) == true)
                            {
                                Console.WriteLine($"Syöttämäsi luku {AddSpaces(input)} on oikea viitenumero.");
                            }
                            else
                            {
                                Console.WriteLine("Syöttämäsi viitenumeroa ei ole oikea");
                            }
                            Console.WriteLine("Paina mitä vain näppäintä ohjelman suorituksen jatkamiseksi");
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine($"Väärä syöte, paina mitä vain näppäintä jatkaakseksi");
                            Console.ReadLine();
                        }
                        break;
                    case '2':
                        ReferenceNumberCreator();
                        Console.WriteLine("Paina mitä vain näppäintä jatkaakseksi.");
                        Console.ReadKey();
                        break;
                    case '3':
                        try
                        {
                            Console.Write("Kuinka monta viitenumeroa haluat luoda?: ");
                            int count = int.Parse(Console.ReadLine());
                            Console.WriteLine("Mikä on viitenumeron alkuosa? (3-19 numeroa): ");
                            string baseNumber = Console.ReadLine();
                            if (IsNumber(baseNumber) == true && ValidLenght(baseNumber, 3, 19) == true && FirstNumberNotZero(baseNumber) == true )
                            {
                                CreateMultipleReferenceNumbers(baseNumber, count);
                            }
                            else
                            {
                                Console.WriteLine("Jokin meni pieleen. Tarkista viitenumeron alkuosa ja kokeile uudestaan.");
                            }
                            Console.WriteLine("Paina mitä vain näppäintä jatkaaksesi.");
                            Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine($"Virheellinen syöte. Paina mitä vain näppäintä jatkaaksesi");
                            Console.ReadKey();
                        }
                        break;
                    case '4':
                        try
                        {
                            Console.WriteLine("Tekstitiedostossa olevat viitenumerot.");
                            ReadFile(@"../../../Referencenumber.txt");
                            Console.WriteLine("Paina mitä vain näppäintä jatkaaksesi");
                            Console.ReadLine();
                        }
                        catch
                        {

                        }
                        break;
                    case 'X':
                        break;

                    default:
                        Console.WriteLine("Tarkista syöttämäsi tiedot");
                        Console.ReadLine();
                        break;
                }
            } while (userChoice != 'X');

        }//Pääohjelma loppuu tähän

        static char UserInterface()
        {
            Console.WriteLine("Ohjelma tarkistaa viitenumeron todellisuuden ja luo yhden tai useamman viite numeron");
            Console.WriteLine("Käyttöliittymä");
            Console.WriteLine("[1] Tarkista viitenumeron oikeillisuus");
            Console.WriteLine("[2] Luo uusi viitenumero");
            Console.WriteLine("[3] Luo useampi viitenumero");
            Console.WriteLine("[4] Näytä luodut viitenumerot");
            Console.WriteLine("[X] Lopeta ohjelman suoritus");
            Console.Write("Mitä haluat tehdä: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }//Käyttöliittymä päättyy

        static bool CheckReferenceNumberValidity(string inputValue)//Tarkistaa viitenumeron ja antaa tarkistus numeron
        {
            int summary = 0;
            char lastNumber;
            int numberLength = 0;
            numberLength = inputValue.Length;
            lastNumber = inputValue[numberLength - 1];
            inputValue = inputValue.Remove(numberLength - 1, 1);


            int n = 3;
            for (int i = inputValue.Length - 1; i >= 0; i--)
            {

                if (n == 3)
                {
                    summary = summary + int.Parse(inputValue[i].ToString()) * 7;

                    n--;
                }
                else if (n == 2)
                {
                    summary = summary + int.Parse(inputValue[i].ToString()) * 3;

                    n--;
                }
                else if (n == 1)
                {
                    summary = summary + int.Parse(inputValue[i].ToString()) * 1;

                    n = 3;
                }
            }

            int numberValidator = summary + int.Parse(lastNumber.ToString());

            if (numberValidator % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }//Numeron tarkistus päättyy

        static string InputValue(string InputValue, int minValue, int maxValue)//Määrittää syötteen
        {
            Console.WriteLine($"Viitenumerossa voi vain olla numeroita ja numeroita väliltä {minValue} - {maxValue}.");
            Console.Write("Syötä numero: ");
            string input = Console.ReadLine();
            //Nämä neljä korvaavat välit, pisteet, pilkut ja viivat syötteestä, eli voi antaa viitenumeron
            //kortissa olevassa muodossa ja tämä muuttaa sen pelkiksi numeroiksi.
            input = input.Replace(" ", "");
            input = input.Replace(".", "");
            input = input.Replace(",", "");
            input = input.Replace("-", "");
            return input;
        }//Numeron syöttäminen päättyy

        static bool ValidLenght(string input, int minValue, int maxValue)
        {
            if (input.Length < minValue || input.Length > maxValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//Oikean pituuden tarkistus loppuu

        static string ReverseString(string inputValue)
        {
            char[] yare = inputValue.ToCharArray();
            Array.Reverse(yare);
            return new string(yare);

        }//stringin kääntäminen päättyy

        static string AddSpaces(string inputValue)//Lisää välejä 5 merkin välein
        {
            String input = ReverseString(inputValue);

            for (int i = 5; i < input.Length; i += 5)
            {
                input = input.Insert(i, " ");
                i++;
            }

            return ReverseString(input);

        }//Välien lisääminen päättyy

        static bool FirstNumberNotZero(string inputValue)//Tarkistaa onko ensimmäinen numero nolla vai ei
        {
            if (inputValue[0].ToString() != "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Ensimmäisen numeron tarkistus päättyy

        static bool IsNumber(string inputValue)
        {
            int n = 0;
            for (int i = 0; i < inputValue.Length; i++)
            {
                bool tryParse = int.TryParse(inputValue[i].ToString(), out _);
                if (tryParse == false)
                {
                    n++;
                }
            }
            if (n == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Numeroiden tarkistus päättyy

        static void ReferenceNumberCreator()
        {
            Console.WriteLine("Syötä viitenumeron alkuosa.");
            Console.WriteLine("Alkuosa koostu 3 - 19 numerosta");
            string input = Console.ReadLine();

            int i = 0;
            if (CheckReferenceNumberValidity(input) == true && IsNumber(input) == true 
                && ValidLenght(input, 3, 19) == true && FirstNumberNotZero(input) == true)
            {
                Console.WriteLine($"Syötetty viitenumero {AddSpaces(input)} on jo oikea viitenumero.");
            }
            else if (CheckReferenceNumberValidity(input) == false)
            {
                while (CheckReferenceNumberValidity(input) == false)
                {
                    if (CheckReferenceNumberValidity(input + i) == false)
                    {
                        i++;
                    }
                    else
                    {
                        input += i;
                        Console.WriteLine($"Uusi viitenumero on: {AddSpaces(input)}");
                        WriteToFile(@"../../../Referencenumber.txt", AddSpaces(input));
                    }
                }
            }

        }//Viitenumeron luonti päättyy

        static void CreateMultipleReferenceNumbers(string baseNumberValue, int countValue)
        {
            int i = 0;
            string path = @"../../../Referencenumber.txt";
            string baseNumber = baseNumberValue;
            for (int j = 0; j < countValue; j++)
            {
                if (CheckReferenceNumberValidity(baseNumber + i) == true)
                {
                    Console.WriteLine($"{AddSpaces(baseNumber + i)} on uusi viitenumero.");
                    WriteToFile(path, AddSpaces(baseNumber + 1));
                    i++;
                }
                else
                {
                    i++;
                    j--;
                }
                
            }
        }//Useamman viitenumeron luonti päättyy

        static void WriteToFile(string path, string inputValue)
        {
            using StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(inputValue);
        }//Tiedostoon kirjoittaminen päättyy

        static void ReadFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

    }
}
