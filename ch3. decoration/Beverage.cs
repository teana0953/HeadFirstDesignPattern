using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3.decoration
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description+" ,"+size;
        }

        public abstract double cost();  // 在子類實現

        // 增加尺寸選項
        public enum SizeEnum
        {
            tall,       // 小杯
            grande,     // 中杯
            venti       // 大杯
        }
        private SizeEnum size;
        public SizeEnum Size { get {return size; } set {size = value; } }
    }

    public class Espresso:Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override double cost()
        {
            return 0.89;
        }
    }

    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }

        public override double cost()
        {
            return 1.05;
        }
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast Coffee";
        }

        public override double cost()
        {
            return 0.99;
        }
    }
}
