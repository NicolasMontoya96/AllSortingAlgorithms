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
            bool printToFile = false;

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
                        // Crea una lista temporal para el resultado ordenado
                        List<int> sortedNumbersBubble = new List<int>(numbers);
                        
                        List<List<int>> sortedNumbersListBubble = new List<List<int>>();
                        sortedNumbersListBubble.Add(sortedNumbersBubble);

                        AskAndPrintToFile(sortedNumbersListBubble); // Pass the list of lists
                        break;

                    case "2":

                        UserInput getNumbersShell = new UserInput();
                        getNumbersShell.GetNumbers(numbers);
                        ShellSort shellSorter = new ShellSort();
                        shellSorter.Sort(numbers);

                        List<int> sortedNumbersShell = new List<int>(numbers);
                        List<List<int>> sortedNumbersListShell = new List<List<int>>();
                        sortedNumbersListShell.Add(sortedNumbersShell);
                        AskAndPrintToFile(sortedNumbersListShell); 
                        break;

                    case "3":
                        UserInput getNumbersSelection = new UserInput();
                        getNumbersSelection.GetNumbers(numbers);
                        SelectionSort selectionSorter = new SelectionSort();
                        selectionSorter.Sort(numbers);

                        List<int> sortedNumbersSelection = new List<int>(numbers);
                        List<List<int>> sortedNumbersListSelection = new List<List<int>>();
                        sortedNumbersListSelection.Add(sortedNumbersSelection);
                        AskAndPrintToFile(sortedNumbersListSelection);
                        break;

                    case "4":
                        UserInput getNumbersInsertion = new UserInput();
                        getNumbersInsertion.GetNumbers(numbers);
                        InsertionSort insertionSorter = new InsertionSort();
                        insertionSorter.Sort(numbers);

                        List<int> sortedNumbersInsertion = new List<int>(numbers);
                        List<List<int>> sortedNumbersListInsertion = new List<List<int>>();
                        sortedNumbersListInsertion.Add(sortedNumbersInsertion);
                        AskAndPrintToFile(sortedNumbersListInsertion);
                        break;

                    case "5":
                        UserInput getNumbersAll = new UserInput();
                        getNumbersAll.GetNumbers(numbers);

                        List<List<int>> allSortedNumbers = ApplyAllSortingAlgorithms(numbers, printToFile);

                        // Llama al nuevo método para preguntar e imprimir al archivo
                        PrintAllSortingResultsToFile(allSortedNumbers);  // Ajusta el nombre del archivo si lo deseas

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
            Console.WriteLine("6. Exit \n");
            Console.Write("Enter your choice: ");
        }

        // Método para obtener la elección del usuario.

        static string GetUserChoice()
        {
            return Console.ReadLine();
        }

        // Esta nueva función se encargará de formatear los números de la manera deseada antes de imprimirlos.
        static string FormatNumbersForPrinting(int[] numbers)
        {
            // Implementa la lógica de formato aquí
            // Ejemplo:
            string formattedNumbers = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                formattedNumbers += $"{numbers[i]:,0} "; // Agrega separadores de miles y un espacio
            }
            return formattedNumbers.Trim(); // Elimina espacios en blanco al final
        }

        static bool AskAndPrintToFile(List<List<int>> sortedNumbersList)
        {
            Console.WriteLine();
            Console.WriteLine(" ¿Would you like to print the output to a text file? (y/n)");
            string printChoice = Console.ReadLine().ToLower();

            if (printChoice == "y")
            {
                string fileName = GetUniqueFileName("temp.txt"); // Change base name if desired
                string formattedNumbers = FormatNumbersForPrinting(sortedNumbersList);
                PrintToFile(fileName, formattedNumbers);
                return true;
            }
            else
            {
                return false;
            }
        }


        static void PrintAllSortingResultsToFile(List<List<int>> sortedNumbersList)
        {
            Console.WriteLine();
            Console.WriteLine(" ¿Do you want to print the output to a text file? (y/n)");
            string printChoice = Console.ReadLine().ToLower();

            if (printChoice == "y" || printChoice == "si")
            {
                string fileName = GetUniqueFileName("temp.txt"); // Change base name if desired
                string formattedNumbers = FormatNumbersForPrinting(sortedNumbersList);
                PrintToFile(fileName, formattedNumbers);
            }
        }

        static List<List<int>> ApplyAllSortingAlgorithms(int[] numbers, bool printToFile)
        {
            List<List<int>> sortedNumbersList = new List<List<int>>();

            // Crea una instancia de Output 
            Output output = new Output();

            // Bubble Sort
            BubbleSort bubbleSorter = new BubbleSort();
            int[] bubbleSortNumbers = (int[])numbers.Clone();
            Console.WriteLine();
            sortedNumbersList.Add(bubbleSorter.Sort(bubbleSortNumbers).ToList());

            // Shell Sort
            ShellSort shellSorter = new ShellSort();
            int[] shellSortNumbers = (int[])numbers.Clone();
            Console.WriteLine();
            sortedNumbersList.Add(shellSorter.Sort(shellSortNumbers).ToList());

            // Selection Sort
            SelectionSort selectionSorter = new SelectionSort();
            int[] selectionSortNumbers = (int[])numbers.Clone();
            Console.WriteLine();
            sortedNumbersList.Add(selectionSorter.Sort(selectionSortNumbers).ToList());

            // Insertion Sort
            InsertionSort insertionSorter = new InsertionSort();
            int[] insertionSortNumbers = (int[])numbers.Clone();
            Console.WriteLine();
            sortedNumbersList.Add(insertionSorter.Sort(insertionSortNumbers).ToList());

            return sortedNumbersList;
        }



        static string FormatNumbersForPrinting(List<List<int>> sortedNumbersList)
        {
            string formattedNumbers = "";

            // Ejemplo de formato:
            for (int i = 0; i < sortedNumbersList.Count; i++)
            {
                
                formattedNumbers += $"Algoritmo: {GetAlgorithmName (i + 1)}\n"; // Nombre del algoritmo
                Console.WriteLine();
                formattedNumbers += string.Join(", ", sortedNumbersList[i] ) + "\n\n"; // Números ordenados
            }

            return formattedNumbers.Trim(); // Elimina espacios en blanco al final
        }

        // Función auxiliar para obtener el nombre del algoritmo (opcional)
        static string GetAlgorithmName(int algorithmIndex)
        {
            switch (algorithmIndex)
            {
                case 1: return "Bubble Sort";
                case 2: return "Shell Sort";
                case 3: return "Selection Sort";
                case 4: return "Insertion Sort";
                case 5: return "All Sorting Algorithms";
                default: return "Unknown";
            }
        }




        static void PrintToFile(string fileName, string text)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(text);
            }
        }



        static string GetUniqueFileName(string baseFileName)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(baseFileName);
            string extension = Path.GetExtension(baseFileName);

            int fileCount = 1;

            for (; File.Exists(fileNameWithoutExtension + extension); fileCount++)
            {
                string formattedCount = fileCount.ToString("D3"); // Format with leading zeros
                fileNameWithoutExtension = $"{fileNameWithoutExtension}{formattedCount}";
            }

            return fileNameWithoutExtension + extension;
        }










    }
}



