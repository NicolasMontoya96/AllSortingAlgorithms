using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Etapa4_NicolasMontoya
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int[] numbers = new int[10];

            while (!exit)
            {
                DisplayMenu();
                string choice = GetUserChoice();

                switch (choice)
                {
                    case "1":
                        UserInput getNumbersBubble = new UserInput();
                        getNumbersBubble.GetNumbers(numbers);
                        BubbleSort bubbleSorter = new BubbleSort();
                        bubbleSorter.Sort(numbers);
                        break;
                    case "2":
                        UserInput getNumbersShell = new UserInput();
                        getNumbersShell.GetNumbers(numbers);
                        ShellSort shellSorter = new ShellSort();
                        shellSorter.Sort(numbers);
                        break;
                    case "3":
                        UserInput getNumbersSelection = new UserInput();
                        getNumbersSelection.GetNumbers(numbers);
                        SelectionSort selectionSorter = new SelectionSort();
                        selectionSorter.Sort(numbers);
                        break;
                    case "4":
                        UserInput getNumbersInsertion = new UserInput();
                        getNumbersInsertion.GetNumbers(numbers);
                        InsertionSort insertionSorter = new InsertionSort();
                        insertionSorter.Sort(numbers);
                        break;
                    case "5":
                        UserInput getNumbersAll = new UserInput();
                        getNumbersAll.GetNumbers(numbers);
                        ApplyAllSortingAlgorithms(numbers);
                        break;
                    case "6":
                        Console.WriteLine("Exiting program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        // Método para mostrar un menú al usuario.

        static void DisplayMenu()
        {
            Console.WriteLine();

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Shell Sort");
            Console.WriteLine("3. Selection Sort");
            Console.WriteLine("4. Insertion Sort");
            Console.WriteLine("5. Apply All Sorting Algorithms");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
        }

        // Método para obtener la elección del usuario.

        static string GetUserChoice()
        {
            return Console.ReadLine();
        }



        static void ApplyAllSortingAlgorithms(int[] numbers)
        {
            // Crea una instancia de Output
            Output output = new Output();

            Console.WriteLine("Applying all sorting algorithms...");
            Console.WriteLine();

            // Copia del arreglo original para cada algoritmo
            int[] tempArray = new int[numbers.Length];

            Console.WriteLine("\nBubble Sort: \n");
            Array.Copy(numbers, tempArray, numbers.Length); // Copia el arreglo original
            BubbleSort bubbleSorter = new BubbleSort();
            bubbleSorter.Sort(tempArray);
            output.PrintArray(tempArray);

            Console.WriteLine("\nShell Sort: \n");
            Array.Copy(numbers, tempArray, numbers.Length); // Copia el arreglo original
            ShellSort shellSorter = new ShellSort();
            shellSorter.Sort(tempArray);
            output.PrintArray(tempArray);

            Console.WriteLine("\nSelection Sort: \n");
            Array.Copy(numbers, tempArray, numbers.Length); // Copia el arreglo original
            SelectionSort selectionSorter = new SelectionSort();
            selectionSorter.Sort(tempArray);
            output.PrintArray(tempArray);

            Console.WriteLine("\nInserction Sort: \n");
            Array.Copy(numbers, tempArray, numbers.Length); // Copia el arreglo original
            InsertionSort insertionSorter = new InsertionSort();
            insertionSorter.Sort(tempArray);
            output.PrintArray(tempArray);


        }
  

    }

}


