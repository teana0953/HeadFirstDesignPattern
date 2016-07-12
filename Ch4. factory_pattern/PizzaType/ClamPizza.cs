using Ch4.factory_pattern.PizzaIngredientType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.factory_pattern.PizzaType
{
    public class ClamPizza:Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override string Prepare()
        {
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clam = ingredientFactory.CreateClam();

            StringBuilder sb = new StringBuilder();
            sb.Append("Preparing " + Name + "\n");
            sb.Append(dough.toString() + "\n");
            sb.Append(sauce.toString() + "\n");
            sb.Append(cheese.toString() + "\n");
            sb.Append(clam.toString());

            return sb.ToString();
        }
    }
}
