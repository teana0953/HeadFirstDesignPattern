using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.factory_pattern.PizzaIngredientType
{
    public class ThickCrustDough : IDough
    {
        public string toString()
        {
            return "ThickCrustDough";
        }
    }
}
