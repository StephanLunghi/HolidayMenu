using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HalloweenMenu
{
    struct Item
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Cost { get; set; }

        public List<FoodType> FoodTypes { get; set; }

        public MenuType Menu { get; set; }

    }
}
