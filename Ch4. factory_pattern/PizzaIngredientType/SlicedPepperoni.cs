using System;

namespace Ch4.factory_pattern.PizzaIngredientType
{
    public class SlicedPepperoni : IPepperoni
    {
        public string toString()
        {
            return "SlicedPepperoni";
        }
    }
}