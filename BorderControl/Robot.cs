namespace BorderControl
{
    using System;
    public class Robot:Visitor
    {
        public string Model { get; set; }

        public Robot(string model,string id)
        {
            this.Id = id;
            this.Model = model;
        }
    }
}
