﻿namespace BorderControl
{
    using System;
    public class Citizen:Visitor,IBirthable, IBuyer
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public string Birthday { get ; set; }
        public int Food { get; set; }

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
            this.Food = 0;
        }

        public int BuyFood()
        {
            return 10;
        }
    }
}
