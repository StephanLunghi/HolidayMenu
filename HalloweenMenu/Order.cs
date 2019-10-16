using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace HalloweenMenu
{
    class Order
    {

        private static decimal startingBalance = 0;


        #region Properties
        public List<Item> Items { get; set; }

     

        public decimal TotalCost
        {
            get
            {
                decimal total = 0;
                foreach (var item in Items)
                {
                    total += item.Cost;
                }
                return total;

            }
            
        }



        #endregion



        #region Methods

        public void AddItem(Item item )
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
            

        }





        #endregion




    }
}
