using Ch4.factory_pattern.PizzaIngredientType;
using Ch4.factory_pattern.PizzaType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.factory_pattern.PizzaStoreType
{
    public class NYStylePizzaStore : PizzaStore     // concreteCreator
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "New York Style Cheese Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "New York Style Clam Pizza";
                    break;
            }
            return pizza;
        }
    }
}
