namespace Assignment_2._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (double x, double y) coordinate;

            Console.Write("Input the value for X coordinate: ");
            coordinate.x = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input the value for Y coordinate: ");
            coordinate.y = Convert.ToDouble(Console.ReadLine());

            string quadrant = DetermineQuadrant(coordinate);
            Console.WriteLine($"The coordinate point {coordinate} lies in { (quadrant == "" ? "no" : "the " + quadrant) } quadrant.");
        }

        static string DetermineQuadrant((double x, double y) coordinate)
        {
            if (coordinate.x > 0 && coordinate.y > 0)
                return "First";
            else if (coordinate.x < 0 && coordinate.y > 0)
                return "Second";
            else if (coordinate.x < 0 && coordinate.y < 0)
                return "Third";
            else if (coordinate.x > 0 && coordinate.y < 0)
                return "Fourth";
            else
                return "";
        }
    }
}
