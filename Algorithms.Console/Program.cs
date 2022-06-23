using Algorithms.ConsoleApp.MenuItems;
using Algorithms.ConsoleApp.Services;
using Algorithms.Core.Encryption.EncryptionAlgorithmBuilder;
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
                            Console.WriteLine("1.Atbash");
                            Console.WriteLine("2.Xor");

                            Console.Write("Select algorithm encrypt: ");
                            var selectedEncryptAlgorithm = Convert.ToInt32(Console.ReadLine().Trim());
                            Algorithmer algorithmer = new Algorithmer();
                            Console.Write("Input text message: ");
                            var message = Console.ReadLine();
                            string encrypt = string.Empty;
                            string decrypt = string.Empty;

                            switch (selectedEncryptAlgorithm)
                            {
                                case 1:
                                    {
                                        EncriptionAlgorithmBuilder builder = new AtbashEncriptionAlgorithmBuilder();
                                        encrypt = algorithmer.Encrypt(builder, message).Encrypt();
                                        decrypt = algorithmer.Encrypt(builder, encrypt).Decrypt();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Input text password: ");
                                        var password = Console.ReadLine();
                                        EncriptionAlgorithmBuilder builder= new XorEncriptionAlgorithmBuilder();
                                        var Xor = algorithmer.Encrypt(builder , message );
                                        Xor.SetPassword(password);
                                         encrypt = Xor.Encrypt();
                                        Xor = algorithmer.Encrypt(builder, encrypt);
                                        Xor.SetPassword(password);
                                        decrypt = Xor.Decrypt();              
                                        break;
                                    }


                                default:
                                    {
                                        throw new Exception();
                                    }
                            }

                            Console.WriteLine("Your's message: {0}", message);
                            Console.WriteLine("Encrypt message: {0}", encrypt);
                            Console.WriteLine("Decrypt message: {0}", decrypt);

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
