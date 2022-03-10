using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

                int n = 20;
                int[] noten = new int[n];
            int summe = 0;
            for (int index = 0; index < n; index++)
            {
                Console.WriteLine("Geben sie die {0} noten ein",index+1);

                noten[index] = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("--------------------------------------");

                summe = summe+noten[index];

                        
            }

            Console.WriteLine( summe / n);
            Console.ReadLine();






        }

            


        }
    }







