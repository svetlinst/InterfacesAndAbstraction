namespace Telephony
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');
            var sites = Console.ReadLine().Split(' ');
            Smartphone smartphone = new Smartphone();
            foreach (var num in numbers)
            {
                Console.WriteLine(smartphone.CallPhonenumber(num));
            }
            foreach (var site in sites)
            {
                Console.WriteLine(smartphone.Browse(site));
            }
        }
    }
}
