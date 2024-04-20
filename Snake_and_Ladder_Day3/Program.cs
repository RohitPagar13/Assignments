namespace Snake_and_Ladder_Day3
{
    class Player
    {
        int start=0;
        int position;

        public Player()
        {
            position=0;
        }

        public int getRandomDice()
        {
            Random r = new Random();
            return r.Next(1, 7);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder");

            Player p1 = new Player();
            p1.getRandomDice();
        }
    }
}