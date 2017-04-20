// Task "Andrey And Billiard", for details check ../07. Programming-Fundamentals-Objects-and-Classes-Exercises.docx

namespace AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            Dictionary<string, decimal> goods = new Dictionary<string, decimal>();
            int goodsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < goodsCount; i++)
            {
                string[] priceInputs = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                goods[priceInputs[0]] = decimal.Parse(priceInputs[1]);
            }

            var customerList = new List<Customer>();

            while (true)
            {
                string primaryCustomersInput = Console.ReadLine();
                if (primaryCustomersInput == "end of clients")
                {
                    break;
                }

                string[] customersInput = primaryCustomersInput
                  .Split(new char[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (!goods.ContainsKey(customersInput[1]))
                {
                    continue;
                }

                bool customerExists = false;
                int customerNumber = 0;
                for (int i = 0; i < customerList.Count; i++)
                {
                    if (customersInput[0] == customerList[i].Name)
                    {
                        customerExists = true;
                        customerNumber = i;
                    }
                }

                if (!customerExists)
                {
                    customerList.Add(new Customer());
                    customerList.Last().Name = customersInput[0];
                    customerList.Last().Buys = new Dictionary<string, int>();
                    customerList.Last().Buys.Add(customersInput[1], int.Parse(customersInput[2]));
                }
                else
                {
                    if (customerList[customerNumber].Buys.ContainsKey(customersInput[1]))
                    {
                        customerList[customerNumber].Buys[customersInput[1]] += int.Parse(customersInput[2]);
                    }
                    else
                    {
                        customerList[customerNumber].Buys.Add(customersInput[1], int.Parse(customersInput[2]));
                    }
                }
            }

            decimal totalBill = 0;
            foreach (var client in customerList.OrderBy(x => x.Name))
            {
                decimal totalCustomerBill = 0;
                Console.WriteLine(client.Name);

                foreach (var purchases in client.Buys)
                {
                    totalCustomerBill += purchases.Value * goods[purchases.Key];
                    Console.WriteLine($"-- {purchases.Key} - {purchases.Value}");
                }

                totalBill += totalCustomerBill;
                Console.WriteLine($"Bill: {totalCustomerBill:f2}");
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
