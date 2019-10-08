namespace BorderControl
{
    using System;
    public class Rebel : IBuyer
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get; set; }

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }
        public int BuyFood()
        {
            return 5;
        }
    }
}
