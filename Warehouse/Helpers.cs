﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public class Helpers
    {
        //typy wartościowe niejawnie dziedziczą po System.Valuetype
        //zaliczamy typy proste, enumy i struktury. Typy wartościowe znajdują się na stosie.

        public int GiveMeNumber()
        {
            //SomeStructure stru = new SomeStructure(1, "i");  wywołanie konstruktorów
            SomeStructure stru = new SomeStructure();

            char character = 'i';

            bool isTrue = false;
            
            int number1;  //F12 na int przenosi do okna definicji

            number1 = 0;

            int number = 0;

            return number;

        }
        public enum ItemType
        {
            Grocery,
            Clothing,
            Electronisc
        }

        public struct SomeStructure
        {
            private int numberForStructure;
            private string nameOfStructure;

            public SomeStructure(int number, string name) 
            {
                numberForStructure = number;
                nameOfStructure = name;
            }
        }
    }
}