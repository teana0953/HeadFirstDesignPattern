using Ch4.factory_pattern.PizzaIngredientType;
using Ch4.factory_pattern.PizzaType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.factory_pattern.PizzaStoreType
{
    public class ChicagoStylePizzaStore : PizzaStore       // concreteCreator
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory(); 
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "Chicago Style Cheese Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "Chicago Style Clam Pizza";
                    break;
            }
            return pizza;
        }
    }
}
