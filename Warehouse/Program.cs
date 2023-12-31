using System;
using System.ComponentModel;
using static Warehouse.Helpers;

namespace Warehouse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to warehouse app!");
            Console.WriteLine("Please let me know what you want to do:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Check Item");
            Console.WriteLine("Press 1,2 or 3...");

            string choice = Console.ReadLine();

            Console.WriteLine($"You have chosen option number: {choice}");

            //Stała
            const string FILE_NAME = "C\\WarehouseFiles\\ImportFile.xlsx";
            //const string FILE_NAME = @"C\WarehouseFiles\ImportFile.xlsx";  //@ małpa - nie potrzeba w ścieżce pdwójnych backslashy

            //zmienna
            int chosenOption = 0;

            Int32.TryParse(choice, out chosenOption);
            Console.WriteLine($"wybrana opcja: {chosenOption}");
            Console.WriteLine($"wybrana nowa opcja: {chosenOption}");

            //----L_2.4

            int a = 5;
            int b = a;

            Console.WriteLine(a); //Wyświetli 5
            Console.WriteLine(b); //Wyświetli 5

            b = 50;
            Console.WriteLine(a); //Wyświetli 5
            Console.WriteLine(b); //Wyświetli 50

            Item item = new Item() { Id = 1, Name = "Apple" };
            Item item2 = item; //przypisujemy referencję ze zmiennej item
         

            Console.WriteLine(item.Name); //wyświetli Apple
            Console.WriteLine(item2.Name); //wyświetli Apple

            item2.Name = "Watermelon";
            Console.WriteLine(item.Name); //NIE! wyświetli Apple
            Console.WriteLine(item2.Name); //NIE! wyświetli Apple

            string str = "Napisy o dowolnej długości";

            Console.WriteLine("Select item category: \r\n 1. Groceery \r\n 2. Clothing \r\n 3. Electronics");
            Console.WriteLine("To jest backslash \\ a to cudzysłów \" "); // znak za backslashem jest normalnie wyświetlany
            Console.WriteLine(@"tak można wyświetlić backslash \ ale nie cudzysłów"); //znak @ przed stringiem
            Console.WriteLine($"to jest string z wstrzykniętymi wartościami {str}, {chosenOption}");

            //-----L_2.5

            Console.WriteLine("Select item category");
            Console.WriteLine("1. Groceery");
            Console.WriteLine("2. Clothing");
            //Console.WriteLine("3. Electronics");

            string category = Console.ReadLine();

            ItemType chosenCategory;

            Enum.TryParse(category, out chosenCategory);

            if (chosenOption == 1)
            {
                if (chosenCategory == ItemType.Clothing) //zagnieżdżony if
                {
                    //.....
                }
                Item item1 = new Item() { Id = 2, Name = "Strawberry" };
                item1.CategoryId = chosenCategory == ItemType.Grocery ? 1 : 2;  //operator trójargumentowy
            }
            else if(chosenOption == 2)
            {
                //usuwanie produktu
            }
            else if(chosenOption == 4)
            {

            }
            else
            {
                // inna operacja
            }

            ItemService itemservice = new ItemService();

            switch (chosenOption)
            {
                case 1:
                    itemservice.AddItem();
                    break;
                case 2:
                    itemservice.RemoveItem();
                    break;
                default:
                    // wyrzuć wyjątek
                    break;
            }

            //switch expressions
            Item item3 = new Item() { Id = 3, Name = "Strawberry" };
            item3.CategoryId = chosenCategory switch
            {
                ItemType.Grocery => 1,
                ItemType.Clothing => 2, 
                ItemType.Electronisc => 3,
                _ => -1    //to jest default
            };  // tu musi być średnik

            // L 2.6 L_2.7
            // a++ a += 2, a-- (!=) - nie równe && || ! - zaprzeczenie
            
            // L 2.8 pętle

            int c = 0;
            while (c < 10)
            {
                Console.WriteLine(c);
                c++;
            }

            c = 10; //wykona się tylko raz
            do
            {
                Console.WriteLine($"{c} do while");
                c++;
            }
            while (c < 10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} for");
            }

            //L 2.10 tablice

            int[] ta = new int[10];
            int[] ta2 = new int[10] {1,2,3,4,5,6,7,8,9,10};

            //L 2.11 listy

            List<int> list = new List<int>();

            list.Add(5);

            list.AddRange(new List<int>() {1,2,3,4});

            List<Item> listOfItems = new List<Item>();

            listOfItems.Add(new Item() { Id = 10, Name = "Apple" });
            listOfItems.Add(new Item() { Id = 11, Name = "Strawberry" });
            listOfItems.Add(new Item() { Id = 12, Name = "Watermelon" });

            foreach(var itemx in listOfItems)
            {
                Console.WriteLine("Aktualny produkt to: " + itemx.Name);
            }

            //listOfItems.Sort(); nie działa!!!
            listOfItems.Remove(new Item() { Id = 10, Name = "Apple" });
            listOfItems.RemoveRange(0, 2);

            //L_2.12 enum

            ItemType itemType = ItemType.Electronisc;
            Console.WriteLine(itemType);
            int categoryId = (int)itemType;   //rzutowanie na int
            Console.WriteLine(categoryId);

        }
    }
}
