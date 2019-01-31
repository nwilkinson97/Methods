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

            //  Here we can Implement the TryParse Method which 
            //  allows us to implemnt a new integer variable inline
            //  and determine if the function succeeded.
            //  Using the 'out' keyword allows us to return two
            //  different pieces of relevant information.  In this
            //  case we receive the result which is a boolean value
            //  and if applicable and successfully convert the string
            //  to an integer we can use the value parsed out to 'number'
            var result = int.TryParse("abc", out int number);    

            //  If Result is (TRUE) the display the integer value
            if (result)
            {
                System.Console.WriteLine(number);
            }
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
