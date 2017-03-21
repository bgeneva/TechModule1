using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LINQuistics
{
    class Program
    {
        static void Main()
        {

            // !!!! Garmi pri vavegdane na cifra
            var input = Console.ReadLine();
            Dictionary<string, HashSet<string>> collectionOfMethods = new Dictionary<string, HashSet<string>>();

            while (input.ToLower() != "exit")
            {
                var inputParams = input.Split(new char[] { ' ', '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputParams.Length == 1)
                {
                    int result;
                    if (int.TryParse(input, out result))
                    {
                        /*If you are given a digit ONLY, you must take the collection, with the most methods, 
                         * and print the first N methods, with the LOWEST length (N being the digit given from the input). 
                         * If there are less than N methods you must print all of them, in the same order.
                        * */
                        if (collectionOfMethods.Any())
                        {
                            var collectionWithMaxMethods = collectionOfMethods
                            .Values
                            .OrderByDescending(method => method.Count())
                            .First()
                            .OrderBy(x => x.Length)
                            .ToList();

                            bool allElements = collectionWithMaxMethods.Count() < result ? true : false;
                            var elementsForPrint = 0;

                            if (allElements)
                            {
                                elementsForPrint = collectionWithMaxMethods.Count();
                            }
                            else
                            {
                                elementsForPrint = result;
                            }
                            for (int i = 0; i < elementsForPrint; i++)
                            {
                                Console.WriteLine("* {0}", collectionWithMaxMethods.ElementAt(i));
                            }

                        }
                        

                    }
                    else
                    {
                        /*
                       * If you are given a collection name ONLY, you must print the methods that have been executed on the collection, 
                       * in descending order by their length. If 2 methods have the same length, order them in descending order, 
                       * by the count of unique symbols they have in their names. 
                       * The methods must be printed – each on a new line, with an asterisk (“*”) and a space (“ “) prefix.
                          If the collection name does NOT exist, you should IGNORE that line of input
                       * */

                        if (collectionOfMethods.ContainsKey(input))
                        {
                            collectionOfMethods[input]
                            .OrderByDescending(method => method.Length)
                            .ThenByDescending(method => method.Distinct().Count())
                            .ToList()
                            .ForEach(method => Console.WriteLine("* {0}", method));
                        }
                    }
                }
                else
                {
                    string collectionName = inputParams[0];

                    if (!collectionOfMethods.ContainsKey(collectionName))
                    {
                        collectionOfMethods[collectionName] = new HashSet<string>();
                    }
                    for (int i = 1; i < inputParams.Count(); i++)
                    {
                        string methodName = inputParams[i];
                        collectionOfMethods[collectionName].Add(methodName);
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            string[] printSelection = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string nameOfMethod = printSelection[0];

            collectionOfMethods = collectionOfMethods
                   .Where(collection => collection.Value.Contains(nameOfMethod))
                   .OrderByDescending(collection => collection.Value.Count())
                   .ThenByDescending(collection => collection.Value.Min(method => method.Length))
                   .ToDictionary(collection => collection.Key, collection => collection.Value);

            if (printSelection[1] == "all")
            {

                foreach (var collection in collectionOfMethods)
                {
                    Console.WriteLine(collection.Key);
                    var orderedMethods = collection.Value.OrderByDescending(method => method.Length);
                    foreach (var method in orderedMethods)
                    {
                        Console.WriteLine("* {0}", method);
                    }
                }

            }
            else
            {
                collectionOfMethods
                .ToList()
                .ForEach(coll => Console.WriteLine("{0}", coll.Key));

            }
        }
    }
}
