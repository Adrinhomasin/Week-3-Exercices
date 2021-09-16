using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN koodi
            //programm võrdelb sisestatud Pin koodi arvuga 1234
            //kui sisestatud PIN kood on 1234
            //programm kuvab konsoolis "tere tulemast!"
            //kui sisestatud PIN on vale, programm kuvab konsoolis
            //"vale PIN. proovi uuesti

            Console.WriteLine("sisestage PIN kood");

            int number = Convert.ToInt32(Console.ReadLine());
            /*if (number == 1234)
            {
                Console.WriteLine("tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti");
            }*/

            if(number != 1234)
            {
                Console.WriteLine("vale Pin proovi uuesti");

            }
            else
            {
                Console.WriteLine("Tere tulemast");
            }
            

        }
    }
}
