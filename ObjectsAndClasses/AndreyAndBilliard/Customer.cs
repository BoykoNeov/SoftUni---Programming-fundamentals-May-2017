// Class for holding customer Name and Buys

namespace AndreyAndBilliard
{
    using System.Collections.Generic;

   public class Customer
    {
       public string Name { get; set; }

       public Dictionary<string, int> Buys { get; set; }
    }
}
