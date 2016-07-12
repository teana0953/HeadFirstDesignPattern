using Ch4.factory_pattern.PizzaIngredientType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.factory_pattern.PizzaType
{
    public class CheesePizza: Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override string Prepare()
        {
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            veggies = ingredientFactory.CreateVeggies();

            StringBuilder sb = new StringBuilder();
            sb.Append("Preparing " + Name + "\n");
            sb.Append(dough.toString() + "\n");
            sb.Append(sauce.toString() + "\n");
            sb.Append(cheese.toString() + "\n");
            for (int i = 0; i < veggies.Length; i++)
            {
                sb.Append(veggies[i].toString());
                if (i != veggies.Length - 1)
                    sb.Append(", ");
            }

            return sb.ToString();
        }
    }
}
