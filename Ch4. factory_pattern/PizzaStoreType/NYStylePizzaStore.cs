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
        public override Pizza createPizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                default:
                    return null;
            }
        }
    }
}
