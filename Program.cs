namespace LabbPolymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry Square = new Square();
            Geometry Circle = new Circle();
            Geometry Rectangle = new Rectangle();
            Geometry Triangle = new Triangle();
            var shapes = new List<Geometry>()
            {
                new Square(),
                new Circle(),
                new Rectangle(),
                new Triangle()
            };
            //Console.WriteLine($"Area of square: {Square.Area()}cm²");
            foreach(var shape in shapes)
            {
                Console.WriteLine($"Area of {shape.Name}: {shape.Area()}cm²");
            }
        }
    }
}
