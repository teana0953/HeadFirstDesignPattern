using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.factory_pattern.PizzaIngredientType
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClams CreateClam()
        {
            return new FrozenClams();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = {new BlackOlives(),new Spinach(),new EggPlant()};
            return veggies;
        }
    }
}
