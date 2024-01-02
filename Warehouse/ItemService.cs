using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
    // L_2.14 metody
{
    public class ItemService
    {
        public List<Item> Items { get; set; }

        public List<Item> GetAllItems() 
        { 
            return Items; 
        }


        //public void CreateListItems()
        public ItemService()
        {
            List<Item> Items = new List<Item>();
            this.Items = Items;
        }
        

        public int AddNewItem()
        {
            Item item = new Item() { Id = 200, Name = "Apple"};
            Items.Add(item);

            /*
            Item item1 = new Item() { Id = 201, Name = "Acer" };
            Items.Add(item1);

            Item item2 = new Item() { Id = 202, Name = "Lenovo" };
            Items.Add(item2);
            */

            return item.Id;
        }
    }
}
