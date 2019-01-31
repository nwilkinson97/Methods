namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20);

            point.Move(100, 200);
            System.Console.WriteLine("Point is at x {0} y {1}", point.X, point.Y);


            point.Move(new Point(40, 60));
            System.Console.WriteLine("Point is at x {0} y {1}", point.X, point.Y);
        }
    }
}
