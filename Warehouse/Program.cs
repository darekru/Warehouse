using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;


namespace Warehouse
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            // L_2.14 metody

            ItemService itemService = new ItemService();
            //itemService.CreateListItems();
            itemService.AddNewItem();
            List<Item> result = itemService.GetAllItems();

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
