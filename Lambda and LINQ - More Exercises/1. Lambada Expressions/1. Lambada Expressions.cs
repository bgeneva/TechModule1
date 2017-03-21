using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Lambada_Expressions
{
    class Program
    {
        static void Main()
        {
            var selectors = Console.ReadLine();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            while(selectors != "lambada")
            {
                if(selectors != "dance")
                {
                    var selector = selectors.Split((new char[] { ' ', '=', '>' }), StringSplitOptions.RemoveEmptyEntries);
                    var key = selector[0];
                    var value = selector[1];

                    dictionary[key] = value;
                }else
                {
                    for(int i = 0; i < dictionary.Count; i++ )
                    {
                        string dancingKey = dictionary.ElementAt(i).Key;
                        string dancingValue = dictionary.ElementAt(i).Value;
                        dictionary[dancingKey] = dictionary.ElementAt(i).Key + "." + dancingValue;
                    }
                }
                

                selectors = Console.ReadLine();
            }

            
            foreach (var selector in dictionary)
            {
                Console.WriteLine("{0} => {1}", selector.Key, selector.Value);
            }

            /*
            dictionary
                .ToList()
                .ForEach(selector => selector.Value
                .ToList()
                .ForEach(selectorObject => Console.WriteLine("{0} => {1}.{2}"),
                selector.Key,
                selectorObject)));
                */
        }
    }
}
  