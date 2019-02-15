using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divider_by_two
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            var newscript = new SeparateScriptBecauseJanSaidSo();
            bool goodInputReceived = false;
            while (!goodInputReceived)
            {
                try
                {
                    //3
                    Console.Write("You are asked to enter a number: ");
                    var answer1 = Console.ReadLine();
                    newscript.Halver(Convert.ToInt32(answer1));
                    goodInputReceived = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Uhh, what ?");
                }
            }

            Console.WriteLine("Was that as good for you as it was for me?");
            Console.ReadKey();
        }
    }
}
