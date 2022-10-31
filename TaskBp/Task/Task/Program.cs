using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dəyər daxil edin");

            string Deyer = Console.ReadLine();
            int Mermi = 30;
            while (Deyer != "")
            {
                if (Deyer == "1")
                {
                    Console.WriteLine("Mermi atildi");
                    Mermi--;
                }
                if (Deyer == "2")
                {
                    for (int i = Mermi; i > 0; i--)
                    {
                        Console.WriteLine("Mermi atildi");
                    }

                    Mermi = 0;
                }

                Deyer = Console.ReadLine();
            }



            //gencler stringi inte cevirmek ucun
            //int A = int.Parse("1");


        }

    }
}
