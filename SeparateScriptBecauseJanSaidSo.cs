using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divider_by_two
{
    class SeparateScriptBecauseJanSaidSo
    {
        //1
        public void Halver(int a)
        {
            Console.WriteLine("Your number " + a + " divided by 2 = " + a * .5f);
        }
    }
    static class StaticClass
    {
        //4
        public static int HalverINT(int a)
        {
            Console.WriteLine("Your number " + a + " divided by 2 = " + a * .5f);
            return Convert.ToInt32(a * .5f);
        }
        //5
        public static int HalverINT(int a, int numberOfTimes)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine("Your number " + a + " divided by 2 = " + a * .5f);
            }
            return Convert.ToInt32(a * .5f);
        }
    }
}
