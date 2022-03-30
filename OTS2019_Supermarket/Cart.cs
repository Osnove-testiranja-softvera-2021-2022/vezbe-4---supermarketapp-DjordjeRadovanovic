using OTS_Supermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Supermarket
{
    public class Cart
    {
        public List<Item> items;
        public int size;
        public double amount;

        public Cart()
        {
            items = new List<Item>();
            size = 0;
            amount = 0;
        }

        public void AddOneToCart(Item item)
        {
            if (size >= 10)
                throw new Exception("10 or less!");

            items.Add(item);
            size++;
            amount += item.Price;
        }

        public void AddMultipleToCart(Item item, int number)
        {
            for(int i = 0; i < number; i++)
            {
                if (size >= 10)
                    throw new Exception("10 or less!");

                items.Add(item);
                size++;
                amount += item.Price;
            }
        }
    }
}
