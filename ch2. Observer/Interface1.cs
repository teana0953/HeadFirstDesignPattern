using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2.Observer
{
    public interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObservers();     // 主題狀態改變時以此方法來通知所有觀察者
    }

    public interface IObserver
    {
        void update(float temperature, float humidity, float pressure);    // 氣象觀測值改變時，主題會把這些狀態值以參數傳送給觀察者
    }

    public interface IDisplayElement
    {
        void display();
    }

}
