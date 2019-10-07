namespace P03_Ferrari
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Ferrari ferrari = new Ferrari("488-Spider", input);
            Console.WriteLine(ferrari.ToString());
        }
    }
}
