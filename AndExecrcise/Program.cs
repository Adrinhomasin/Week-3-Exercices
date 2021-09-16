using System;

namespace AndExecrcise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks
            //mata eksam vähmalt 85
            //keemia vahemalt 90
            //bios miinimum 95
            //programm küsib kasutajal siestada tema
            //eksami punktid ja otsustab, kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("sisesta oma matemaatika punktid");
            int Maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisestage oma keemia punktid");
            int Science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisestage oma bioloogia punktid");
            int Biology = Convert.ToInt32(Console.ReadLine());
            

            if (Maths >= 85 && Science >= 90 && Biology >= 95)
            {
                Console.WriteLine("Saate arstiks õppida");
            }
            else
            {
                Console.WriteLine("ei saa arstiks õppida");
            }
        }
    }
}
