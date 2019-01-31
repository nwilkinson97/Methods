using System;

namespace Methods
{
    public class Point
    {
        // X & Y Fields for Coordinates
        public int X;
        public int Y;

        //  Class Constructor
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            // Pass a New Point to the Move Method
            Move(new Point(x, y));
        }

        public void Move(Point newLocation)
        {
            // Throw Exception if passed a NULL value (DEFENSIVE PROGRAMMING)
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            
            // Set the Location of the pointer
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }


    }
}
