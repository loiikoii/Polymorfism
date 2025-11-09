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
            foreach(var shape in shapes) //Prints out message in console, shape.Name & shape.Area will change accordingly to the right shape.
            {
                Console.WriteLine($"Area of {shape.Name}: {shape.Area()}cm²");
            }
        }
    }
}
