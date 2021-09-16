using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mitu kraadi on õues
            //kui õues on rohkem kui 35 kraadi siis kuvab "boiling hot
            //kui on 30-35 siis "hot"
            //kui 20-30 siis "nice"
            //kui 10-20 siis "chilly"
            //kui 0-10 siis "cold"

            Console.WriteLine("Mitu kraadi õues on?");
            int Temp = Convert.ToInt32(Console.ReadLine());

            if (Temp >= 35)
            {
                Console.WriteLine("Boiling hot");
            }
            else if (Temp >= 30 && Temp < 35)
            {
                Console.WriteLine("Hot");
            }
            else if (Temp >= 20 && Temp < 30)
            {
                Console.WriteLine("nice");
            }
            else if (Temp >= 10 && Temp < 20)
            {
                Console.WriteLine("chilly");
            }
            else if (Temp >= 0 && Temp < 10)
            {
                Console.WriteLine("cold");
            }
        }
    }
}
