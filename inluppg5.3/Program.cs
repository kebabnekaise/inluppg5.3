using System;
using System.Net.Mime;

namespace inluppg5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            int[] age = new int[5];

            Console.WriteLine("Skriv fem namn");
            for (int i = 0; i < namn.Length; i++)
            {
                namn[i] = Console.ReadLine();
            }

            for (int j = 0; j < age.Length; j++)
            {
                Console.WriteLine("Hur gammal är " + namn[j] + "?");
                age[j] = int.Parse(Console.ReadLine());
            }

            float promedio = (float)(age[0] + age[1] + age[2] + age[3] + age[4]) / 5;

            Console.WriteLine("Medelvärdet av åldrarna är " + promedio);
            int indexHighest = 0;
            for (int k = 0; k < age.Length; k++)
            {
                if (age[k] > age[indexHighest])
                {
                    indexHighest = k;
                }
            }
            Console.WriteLine("Den äldsta personen är " + namn[indexHighest] + " som är " + age[indexHighest] + " år gammal");

        }
    }
}