using System;
namespace Uppgift_3._2
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Har du gått ut gymnasiet? Svara J för ja och N för nej");
            string gymnasie = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            string siffra = Console.ReadLine();
            int ålder = int.Parse(siffra);

            if (ålder < 22 && gymnasie == "j" )
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvär efter andra");
            }
        

         
            Console.ReadKey();

            
        }
    }
}
