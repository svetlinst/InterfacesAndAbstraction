namespace P03_Ferrari
{
    using System;
    public class Ferrari : ICar
    {
        public string Model { get; set; }
        public string Driver { get; set; }

        public Ferrari(string model, string driver)
        {
            this.Model = model;
            this.Driver = driver;
        }

        public string HitGas()
        {
            return "Gas!";
        }

        public string PushBrakes()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{Model}/{this.PushBrakes()}/{this.HitGas()}/{Driver}";
        }
    }
}
