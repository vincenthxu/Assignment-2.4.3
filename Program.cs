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
            Console.WriteLine($"The coordinate point {coordinate} lies in {(quadrant == "" ? "no" : "the " + quadrant)} quadrant.");
        }

        static string DetermineQuadrant((double, double) coordinate)
        {
            switch (coordinate)
            {
                case ( > 0, > 0 ):
                    return "First";
                case ( < 0, > 0 ):
                    return "Second";
                case ( < 0, < 0 ):
                    return "Third";
                case ( > 0, < 0 ):
                    return "Fourth";
                default:
                    return "";
            }
        }
    }
}
