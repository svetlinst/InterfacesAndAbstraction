namespace BorderControl
{
    using System;
    public class Pet : IBirthable
    {
        public string Name { get; set ; }
        public string Birthday { get; set; }

        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
    }
}
