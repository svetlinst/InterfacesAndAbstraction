namespace Telephony
{
    using System;
    using System.Linq;

    public class Smartphone : ICaller, IBrowser
    {
        public Smartphone()
        {

        }
        
        public string Browse(string site)
        {
            if (site.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {site}!";
        }

        public string CallPhonenumber(string number)
        {
            if (number.All(char.IsDigit))
            {
                return $"Calling... {number}";
            }
            else
            {
                return "Invalid number!";
            }
        }
    }
}
