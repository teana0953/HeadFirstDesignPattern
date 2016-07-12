using Ch4.factory_pattern.PizzaStoreType;
using Ch4.factory_pattern.PizzaType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.factory_pattern
{
    class PizzaTestDrive
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Ethan ordered a "+pizza.Name + "\n");
            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine("Joel ordered a "+pizza.Name + "\n");

            Pizza pizza2 = nyStore.orderPizza("clam");
            Console.WriteLine("Ethan ordered a " + pizza2.Name + "\n");
            pizza2 = chicagoStore.orderPizza("clam");
            Console.WriteLine("Joel ordered a " + pizza2.Name);
        }
    }
}
