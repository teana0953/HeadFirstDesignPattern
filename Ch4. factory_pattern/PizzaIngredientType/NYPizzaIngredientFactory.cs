using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.factory_pattern.PizzaIngredientType
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public override IClams CreateClam()
        {
            return new FreshClams();
        }

        public override IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public override IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public override ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public override IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = {new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}
