namespace CourseApp
{
    using System;

    public class AndroidPhone : SmartPhone, IProduct
    {
        public AndroidPhone(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public void Present()
        {
            Console.WriteLine($"Name: {Name} Price: {Price}$");
        }
    }
}
