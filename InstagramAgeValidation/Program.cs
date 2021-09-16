using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanuse
            //programm kontrollib, kas kasutaja on vanem kui 13 v 13 aastat vana
            //kui on 13 või vanem
            //saab kasutada instat
            //kui ei siis ei saa

            Console.WriteLine("Palun sisestage oma sünniaasta");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int age = 2021 - YearOfBirth;

            if (YearOfBirth <= 2008) 
            {
                Console.WriteLine("Võid kasutada instagrammi");
            }
            else
            {
                Console.WriteLine("Oled liiga noor");
            }
            

            
        }
    }
}
