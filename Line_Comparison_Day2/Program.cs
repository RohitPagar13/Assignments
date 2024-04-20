namespace Line_Comparison
{
    class Line
    {
        private int x1, y1, x2, y2;

        public Line()
        {
            Console.WriteLine("Enter x1 : ");
            this.x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 : ");
            this.y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 : ");
            this.x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 : ");
            this.y2 = Convert.ToInt32(Console.ReadLine());
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

        }
    }
}