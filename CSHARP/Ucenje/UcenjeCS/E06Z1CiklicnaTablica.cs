using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06Z1CiklicnaTablica
    {
        internal static void Izvedi()
        {

            while (true)
            {
                Console.WriteLine("Unesi broj redaka: ");
                int brojRedaka = int.Parse(Console.ReadLine());

                Console.WriteLine("Unesi broj stupaca: ");
                int brojStupaca = int.Parse(Console.ReadLine());

                Console.WriteLine($"Broj redaka {brojRedaka} i broj {brojStupaca}");

                int Raspon = brojRedaka * brojStupaca;
                if (Raspon >= 2 && Raspon <= 50)
                {
                    Console.WriteLine("Raspon je ok");



                    int[,] matrix = new int[brojRedaka, brojStupaca];

                    int currentNumber = 1;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = currentNumber++;
                        }
                    }

                    // Step 3: Print the matrix
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i, j] + "\t");
                        }
                        Console.WriteLine();

                    }


                    break;

                }
                else
                {
                    Console.WriteLine("Raspon brojeva mora biti unutar 2 i 50");
                }
            }
        }
    }
}
