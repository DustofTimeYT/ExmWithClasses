namespace CourseApp
{
    using System;

    public class IOSPhone : SmartPhone, IProduct
    {
        public IOSPhone(string name, float diagonal, double price)
        {
            Name = name;
            Price = price;
            Diagonal = diagonal;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public void Present()
        {
            Console.WriteLine($@"Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Diagonal: {Diagonal} Price: {Price}$");
        }
    }
}
