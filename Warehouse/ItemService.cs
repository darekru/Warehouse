using System;
using System.Collections.Generic;
using System.Linq;
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

        public int AddNewItem()
        {
            Item item = new Item() { Id = 200, Name = "Apple"};
            Items.Add(item);
            return item.Id;
        }
    }
}
