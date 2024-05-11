using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa4_NicolasMontoya
{
    public class UserInput
    {
        public void GetNumbers(int[] numbers)
        {
            Console.WriteLine("\n Enter 10 numbers: \n ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                string input = Console.ReadLine().Trim(); // Eliminar espacios en blanco al principio y al final

                if (string.IsNullOrEmpty(input) || !input.All(char.IsDigit))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Reintentar la entrada del número actual
                    continue;
                }

                try
                {
                    numbers[i] = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Reintentar la entrada del número actual
                }
            }
        }
    }
}
