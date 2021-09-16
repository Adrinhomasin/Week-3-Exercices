using System;

namespace WeatherReportSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitu kraadi õues on?");
            int Temp = Convert.ToInt32(Console.ReadLine());

            switch (Temp)
            {
                case var _ when < 0:
                    Console.WriteLine("freezing cold");
                    break;
                case var _ when Temp <= 0 && Temp < 10:
                    Console.WriteLine("cold");
                    break;
                case var _ when Temp <= 10 && Temp < 20:
                    Console.WriteLine("chilly");
                        break;
                case var _ when Temp <= 20 && Temp < 30:
                    Console.WriteLine("nice");
                    break;
                case var _ when Temp <= 30 && Temp < 35:
                    Console.WriteLine("boiling hot");
                    break;
                       
            }
        }
    }
}
