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
        protected string dough;     // 麵糰
        protected string sauce;
        protected List<string> toppings = new List<string>();
        //protected ICheese cheese;
        //protected IPepperoni pepperoni;
        //protected IClams clam;
        #endregion

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough..." + dough);
            Console.WriteLine("Adding sauce..." + sauce);
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine(" " + toppings[i]);
            }

        }
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
