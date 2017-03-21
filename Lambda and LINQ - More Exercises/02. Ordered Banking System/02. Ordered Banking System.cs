using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ordered_Banking_System
{
    class Program
    {
        static void Main()
        {
            var inputLine = Console.ReadLine();
            Dictionary<string, Dictionary<string, decimal>> bankAccounts = new Dictionary<string, Dictionary<string, decimal>>();

            while (inputLine != "end")
            {
                var accounts = inputLine.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string nameBank = accounts[0];
                string nameAccount = accounts[1];
                decimal balanceAccount = decimal.Parse(accounts[2]);

                if (!bankAccounts.ContainsKey(nameBank))
                {
                    bankAccounts[nameBank] = new Dictionary<string, decimal>();
                }
                if (!bankAccounts[nameBank].ContainsKey(nameAccount))
                {
                        bankAccounts[nameBank][nameAccount] = 0;
                }
               bankAccounts[nameBank][nameAccount] += balanceAccount;

               inputLine = Console.ReadLine();
            }

            bankAccounts
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value
                   .OrderByDescending(account => account.Value)
                   .ToList()
                   .ForEach(account => Console.WriteLine("{0} -> {1} ({2})",
                      account.Key,
                      account.Value,
                      bank.Key)
                      ));

        }
     }

 }


