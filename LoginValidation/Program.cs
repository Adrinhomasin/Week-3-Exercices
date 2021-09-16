using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt kasutajatunnuse ja parooli
            //programm kontrollib sisestatud andmeid
            //kui sisestatud kasutaja tunnus on "admin ja parool on "admin1234"
            //siis programm kuvab "Tere tulemast"
            //Muul juhul kuvab "vale vastus proovi uuesti"
            

            Console.WriteLine("sisesta kasutajatunnus:");
            string userName = Console.ReadLine()
            Console.WriteLine("sisesta parool:");
            string password = Console.ReadLine();

            if (userName == "admin" || password == "admin1234")
            {
                Console.WriteLine("Tere Tulemast");
            }
            else
            {
                Console.WriteLine("vale vastus proovi uuesti");
            }


        }
    }
}
