namespace BorderControl
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            var results = new List<Visitor>();
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split();
                if (tokens.Length ==2)
                {
                    Robot robot = new Robot(tokens[0], tokens[1]);
                    results.Add(robot);
                }
                else
                {
                    Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    results.Add(citizen);
                }                
            }
            var checkId = Console.ReadLine();

            foreach (var itm in results)
            {
                if (!itm.IsValid(checkId))
                {
                    Console.WriteLine($"{itm.Id}");
                }
            }
        }
    }
}
