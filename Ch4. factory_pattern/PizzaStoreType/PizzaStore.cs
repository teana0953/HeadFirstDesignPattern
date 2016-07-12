using Ch4.factory_pattern.PizzaType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ch4.factory_pattern.PizzaStoreType
{
    public abstract class PizzaStore    // creator
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza;
            pizza = createPizza(type);
            Console.WriteLine(pizza.Prepare());
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza createPizza(string type);     // 根據不同加盟店其製作pizza的方式會有差異
    }
}
