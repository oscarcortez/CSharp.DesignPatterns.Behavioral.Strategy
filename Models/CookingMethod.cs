using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CookingMethod
    {
        public string Food { private get; set; }
        public CookStrategy CookStrategy { private get; set; }


        public CookingMethod()
        {
        }

        public CookingMethod(CookStrategy cookStrategy)
        {
            CookStrategy = cookStrategy;
        }

        public void Cook()
        {
            CookStrategy.Cook(Food);
            Console.WriteLine();
        }

    }
}
