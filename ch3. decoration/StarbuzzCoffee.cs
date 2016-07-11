using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3.decoration
{
    class StarbuzzCoffee
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $"+beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2.Size = Beverage.SizeEnum.venti;
            beverage2 = new Mocha(beverage2);       // 添加摩卡
            beverage2 = new Mocha(beverage2);       // 添加摩卡
            beverage2 = new Whip(beverage2);        // 添加奶泡
            Console.WriteLine(beverage2.GetDescription()+" $"+beverage2.cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.cost());

        }
    }
}
