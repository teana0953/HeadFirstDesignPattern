using Ch4.factory_pattern.PizzaIngredientType;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.factory_pattern.PizzaType
{
    public abstract class Pizza     // product
    {
        private string name;
        public string Name { get {return name; } set {name = value; } }

        #region Members
        protected IDough dough;     // 麵糰
        protected ISauce sauce;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClams clam;
        protected IVeggies[] veggies;
        
        #endregion

        public abstract string Prepare();
       
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 mins at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
