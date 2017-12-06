using System;
using System.Collections.Generic;
using System.Threading;

namespace ShopAsistant
{
    public class ShopAssistant
    {
        public class myitem
        {
            public float amount { get; set; }
            public string itemName { get; set; }
            public string description { get; set; }

            public bool Sell(float amount)
            {
                this.amount -= amount;
                return false;
            }

            public float maxAmoount { get; set; }
            public bool buy(float amount)
            {
                this.amount += amount;
                return true;
            }


        }

        public List<myitem> warehouse { get; set; } = new List<myitem>();

        public ShopAssistant()
        {
            // generate three items to the warehouse
            var item1 = new myitem
            {
                amount = 12,
                description = "item 1  description",
                itemName = "my fat item 1",
                maxAmoount = 15
            };
            warehouse.Add(item1);

            var item2 = new myitem
            {
                amount = 12,
                description = "item 2  description",
                itemName = "my fat item 2",
                maxAmoount = 15
            };
            var item3 = new myitem
            {
                amount = 123,
                description = "item 3  description",
                itemName = "my fat item 3",
                maxAmoount = 15
            };
            var item4 = new myitem
            {
                amount = -12,
                description = "item 4  description",
                itemName = "my fat item 4",
                maxAmoount = 15
            };

            warehouse.Add(item1);
            warehouse.Add(item2);
            warehouse.Add(item3);
            warehouse.Add(item4);
            while (true)
            {

                Console.Clear();
                Console.WriteLine("Hello, welcome in my shop");
                Console.WriteLine("What you want to buy?");
                var itemNumber = 1;
                foreach (var myitem in warehouse)
                {
                    Console.WriteLine("-------");
                    Console.WriteLine($"item number: {itemNumber++},");
                    Console.WriteLine($"item name: {myitem.itemName},");
                    Console.WriteLine($"item desc: {myitem.description},");
                    Console.WriteLine($"avaliable amount: {myitem.amount}");
                    Console.WriteLine("-------");
                }

                var selection = int.Parse(Console.ReadLine());
                Console.Write("please specify amount: ");
                var amount = int.Parse(Console.ReadLine());
                Console.WriteLine("Done!");
                warehouse[selection - 1].Sell(amount);
            }



        }
    }
}