using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tiping_test
{
    internal class User /*: IComparable*/
    {
        public string name;
        public double tip_per_sec;
        public float tip_per_min;

        public User(string n, int tip) 
        {
            name = n;
            tip_per_sec = tip/60.0;
            tip_per_min = tip;
        }
        /*Потуги сделать сортировку списка моего класса, если видите это, то они не увенчались успехом*/
       /* public int CompareTo(object ? obj)
        {
            if ((obj == null) || (!(obj is User)))
            {
                return 0;
            }
            else
                return Convert.ToDouble(tip_per_min, ((User)obj).tip_per_min);
        } */

        public void getter()
        {
            Console.WriteLine("Имя:   " + name);
            Console.WriteLine("Сим/мин:" + tip_per_min);
            Console.WriteLine("Сим/сек:" + tip_per_sec); 
        }
    }
}
