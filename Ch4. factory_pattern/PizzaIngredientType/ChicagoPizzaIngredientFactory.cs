using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.factory_pattern.PizzaIngredientType
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public override IClams CreateClam()
        {
            return new FrozenClams();
        }

        public override IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public override IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public override ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public override IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = {new BlackOlives(),new Spinach(),new EggPlant()};
            return veggies;
        }
    }
}
