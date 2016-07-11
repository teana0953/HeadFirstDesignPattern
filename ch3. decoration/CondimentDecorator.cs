using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3.decoration
{
    public abstract class CondimentDecorator:Beverage
    {
       
    }

    public class Mocha: CondimentDecorator
    {
        Beverage beverage;  // 傳入被裝飾者的 ref
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";   // 新行為是通過在舊行為前面或後面做一些計算來添加
        }

        public override double cost()
        {
            return GetSize(beverage.Size);               // 新行為是通過在舊行為前面或後面做一些計算來添加
        }

        private double GetSize(Beverage.SizeEnum size)
        {
            switch(size)
            {
                case SizeEnum.tall:
                    return 0.20 + beverage.cost();
                case SizeEnum.grande:
                    return 0.35 + beverage.cost();
                case SizeEnum.venti:
                    return 0.40 + beverage.cost();
                default:
                    return 0.20;    // never
            }
        }
    }
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double cost()
        {
            return 0.10 + beverage.cost();
        }
    }
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double cost()
        {
            return 0.15 + beverage.cost();
        }
    }
}
