﻿using System;

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



        }
    }
}
