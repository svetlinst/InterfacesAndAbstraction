namespace BorderControl
{
    using System;
    public abstract class Visitor
    {
        public string Id { get; set; }

        public bool IsValid(string id)
        {
            if (this.Id.EndsWith(id))
            {
                return false;
            }
            return true;
        }
    }
}
