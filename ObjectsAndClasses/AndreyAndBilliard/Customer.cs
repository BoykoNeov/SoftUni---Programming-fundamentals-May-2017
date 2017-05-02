namespace AndreyAndBilliard
{
    using System.Collections.Generic;

    /// <summary>
    /// Class for holding customer Name and Buys
    /// </summary>
    public class Customer
    {
       public string Name { get; set; }

       public Dictionary<string, int> Buys { get; set; }
    }
}