using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public int Battery { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Tesla(string model, string color, int batteries)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = batteries;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name.ToString()} {this.Model} with {Battery} Batteries");
            sb.AppendLine(this.Start());
            sb.AppendLine(this.Stop());
            return sb.ToString();
        }
    }
}
