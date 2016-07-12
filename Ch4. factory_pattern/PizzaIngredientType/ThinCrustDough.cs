using System;

namespace Ch4.factory_pattern.PizzaIngredientType
{
    public class ThinCrustDough : IDough
    {
        public string toString()
        {
            return "ThinCrustDough";
        }
    }
}