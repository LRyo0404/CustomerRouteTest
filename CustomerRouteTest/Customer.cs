namespace CustomerRouting
{
    public class Customer
    {
        public string Name { get; }
        public int X { get; }
        public int Y { get; }

        public Customer(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }
}