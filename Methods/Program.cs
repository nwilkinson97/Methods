namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            UsePoint();
            UseCalculator();

            // Note Run Code and you will receive an error because 
            //     a string cannot be converted to an integer
            //var number = int.Parse("abc");


        }

        private static void UseCalculator()
        {
            // Create new Instance of Calculator Class
            var calculator = new Calculator();

            // Using parmas we can pass integers like this
            System.Console.WriteLine(calculator.Add(1, 2));
            System.Console.WriteLine(calculator.Add(1, 2, 3));
            System.Console.WriteLine(calculator.Add(1, 2, 3, 4));
            System.Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));

            // Or as an integer array like this
            System.Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }

        private static void UsePoint()
        {
            // Quick Actions Keyboard Shortcut was used here to Extract Method and Name the Function
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
