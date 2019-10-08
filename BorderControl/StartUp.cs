namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, IBuyer> results = new Dictionary<string, IBuyer>();
            var ibuyers = int.Parse(Console.ReadLine());
            for (int i = 0; i < ibuyers; i++)
            {
                input = Console.ReadLine();
                var tokens = input.Split();
                if (tokens.Length==4)
                {                    
                    Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                    if (!results.ContainsKey(citizen.Name))
                    {
                        results.Add(citizen.Name,citizen);
                    }
                }
                else
                {
                    Rebel rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    if (!results.ContainsKey(rebel.Name))
                    {
                        results.Add(rebel.Name, rebel);
                    }   
                }
            }
            var totalFood = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                if (results.ContainsKey(input))
                {
                    totalFood += results[input].BuyFood();
                }
            }
            Console.WriteLine(totalFood);
        }
    }
}
