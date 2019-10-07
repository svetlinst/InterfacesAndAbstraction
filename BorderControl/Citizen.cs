namespace BorderControl
{
    using System;
    public class Citizen:Visitor
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

    }
}
