using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsitab kasutajal sisestada täht
            //programm kontrollib, kas sisestatud täht on
            //täishäälik või kaashäälik
            //kui sisestatud täht on täishäälik programm kuvab
            //"täishäälik"
            //kui on kaashäälik siis "kaashäälik"

            Console.WriteLine("Palun sisestage täht");
            char userCharacter = Convert.ToChar(Console.ReadLine().ToLower());

            switch (userCharacter)
            {
                case 'a':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("Täishäälik");
                    break;               
                default:
                    Console.WriteLine("Kaashäälik");
                    break;
                    
            }

        }
    }
}
