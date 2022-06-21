using Algorithms.ConsoleApp.MenuItems;
using Algorithms.ConsoleApp.Services;
using System;

namespace Algorithms.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < MainMenu.MenuItems.Value.Count; i++)
                {
                    Console.WriteLine(string.Concat(i, ".", MainMenu.MenuItems.Value[i].Name));
                }
                Console.Write("Select algorithm type 0-{0}: ", MainMenu.MenuItems.Value.Count - 1);
                var selectedAlgorithm = Convert.ToInt32(Console.ReadLine().Trim());

                switch (selectedAlgorithm)
                {
                    case 0:
                        {
                            for (int i = 0; i < SortingMenuItems.SortAlgorithms.Value.Count; i++)
                            {
                                Console.WriteLine(string.Concat(i, ".", SortingMenuItems.SortAlgorithms.Value[i].Name));
                            }

                            Console.Write("Select algorithm sort 0-{0}: ", SortingMenuItems.SortAlgorithms.Value.Count - 1);
                            var selectedSortAlgorithm = Convert.ToInt32(Console.ReadLine().Trim());
                            int[] array = InputService.InputGenerateIntArray();
                            var sort = SortingMenuItems.SortAlgorithms.Value[selectedSortAlgorithm];

                            Console.WriteLine("Generated array: ");
                            OutputService.OutputArrayLine(array);
                            array = sort.Sort(array);

                            Console.WriteLine("Sorting...");

                            Console.WriteLine("Sorted array: ");
                            OutputService.OutputArrayLine(array);
                            break;
                        }
                    case 1:
                        {
                            for (int i = 0; i < SearchMenuItems.SearchAlgorithms.Value.Count; i++)
                            {
                                Console.WriteLine(string.Concat(i, ".", SearchMenuItems.SearchAlgorithms.Value[i].Name));
                            }

                            Console.Write("Select algorithm search 0-{0}: ", SearchMenuItems.SearchAlgorithms.Value.Count - 1);
                            var selectedSearchAlgorithm = Convert.ToInt32(Console.ReadLine().Trim());
                            int[] array = InputService.InputGenerateIntArray();
                            var search = SearchMenuItems.SearchAlgorithms.Value[selectedSearchAlgorithm];

                            Console.WriteLine("Generated array: ");
                            OutputService.OutputArrayLine(array);

                            Console.WriteLine("Enter search value: ");
                            var searchValue = Convert.ToInt32(Console.ReadLine().Trim());

                            Console.WriteLine("Search...");

                            int searchIndexKey = search.Search(array, searchValue);

                            if (searchIndexKey != -1)
                            {
                                Console.WriteLine("Search value index: {0}", searchIndexKey);
                            }
                            else
                            {
                                Console.WriteLine("Array doesn't have any numbers with value {0}", searchValue);
                            }

                            break;
                        }
                    case 2:
                        {
                            for (int i = 0; i < EncriptionMenuItems.EncryptionAlgorithms.Value.Count; i++)
                            {
                                Console.WriteLine(string.Concat(i, ".", EncriptionMenuItems.EncryptionAlgorithms.Value[i].Name));
                            }
                            Console.Write("Select algorithm encrypt 0-{0}: ", EncriptionMenuItems.EncryptionAlgorithms.Value.Count - 1);
                            var selectedEncryptAlgorithm = Convert.ToInt32(Console.ReadLine().Trim());
                            var encrypt = EncriptionMenuItems.EncryptionAlgorithms.Value[selectedEncryptAlgorithm];

                            Console.Write("Input text message: ");
                            var message = Console.ReadLine();
                            var encryptedMessage = encrypt.Encrypt(message);
                            Console.WriteLine("Encrypted message: {0}", encryptedMessage);
                            var decryptedMessage = encrypt.Decrypt(encryptedMessage);
                            Console.WriteLine("Decrypted message: {0}", decryptedMessage);
                            break;
                        }
                    default:
                        throw new Exception();
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
