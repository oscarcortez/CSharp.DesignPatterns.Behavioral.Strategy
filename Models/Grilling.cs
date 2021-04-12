using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Grilling : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine($"Cooking {food} by grilling it.");
        }
    }
}
