namespace Line_Comparison
{
    class Line
    {
        private double x1, y1, x2, y2;

        public Line()
        {
            Console.WriteLine("Enter (x1,y1) : ");
            this.x1 = Convert.ToDouble(Console.ReadLine());
            this.y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter (x2,y2) : ");
            this.x2 = Convert.ToDouble(Console.ReadLine());
            this.y2 = Convert.ToDouble(Console.ReadLine());
        }

        public double CalLength()
        {
            return Math.Sqrt((Math.Pow((this.x1 - this.x2), 2)) + (Math.Pow((this.y1 - this.y2), 2)));
        }


    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            
            Line l1 = new Line();
            double length1 = l1.CalLength();
            Console.WriteLine("Length of first line: " + length1);

            Line l2 = new Line();
            double length2 = l1.CalLength();
            Console.WriteLine("Length of second line: " + length2);

            if(length1.Equals(length2)) {
                Console.WriteLine("The Lines are of Equal Length");
            }
            else
            {
                Console.WriteLine("Length of lines are not equal");
            }
        }
    }
}