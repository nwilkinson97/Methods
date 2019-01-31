namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an Instance of the Point Class
                var point = new Point(10, 20);

                //  Pass the X & Y Coordinates as Integers and Display the Location
                point.Move(100, 200);
                System.Console.WriteLine("Point is at x {0} y {1}", point.X, point.Y);

                //  Pass the X & Y Coordinates as a new Point and Display the Location
                point.Move(new Point(40, 60));
                System.Console.WriteLine("Point is at x {0} y {1}", point.X, point.Y);

                // Lets now Change things up and pass a null value to the Move Method
                // Note:  When we run the code an error is thrown.  Because we have not
                //        done anything to handle the error.  
                point.Move(null);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
