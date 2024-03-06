using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Menu
    {
        public string PizzaName 
        { get; set; }
        public int Price 
        { get; set; }

        public Menu (string pizzaName, int price)
        {
            PizzaName = pizzaName;
            Price = price;
        }

        private Menu[] menu = 
        {
            new Menu("(1)Margherita - Tomato & cheese", 69),
            new Menu("(2)Vesuvio - Tomato, cheese & ham", 75),
            new Menu("(3)Capriccsia - Tomato, cheese, ham & mushroom", 80),
            new Menu("(4)Calzone - Baked pizza tomato, cheese, ham & mushroom", 80),
            new Menu("(5)Quattro Stagioni - Tomato, cheese, ham, mushroom, shrimp & peppers", 85),
            new Menu("(6)Marinara - Tomato, cheese, shrimp, musssels & garlic", 85),
            new Menu("(7)Vegetarian - Tomato, cheese & vegetables", 80),
            new Menu("(8)Italiana - Tomato, cheese, onion & meat sauce", 75),
            new Menu("(9)Gorgonzola - Tomato, gorgonzola, onion, & mushroom", 85),
            new Menu("(10)Contadina - Tomato, cheese, mushroom & Olivers", 75)
        };

    }
}

