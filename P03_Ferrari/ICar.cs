namespace P03_Ferrari
{
    using System;
    public interface ICar
    {
        string Model { get; set; }
        string Driver { get; set; }

        string PushBrakes();
        string HitGas();
    }
}
