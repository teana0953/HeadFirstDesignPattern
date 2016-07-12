using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.factory_pattern.PizzaIngredientType
{
    public abstract class PizzaIngredientFactory
    {
        public abstract Dough CreateDough();
        public abstract Sauce CreateSauce();
        public abstract Cheese CreateCheese();
        public abstract IVeggies[] CreateVeggies();
        public abstract Pepperoni CreatePepperoni();
        public abstract IClams CreateClam();
    }
}
