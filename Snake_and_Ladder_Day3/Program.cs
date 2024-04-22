namespace Snake_and_Ladder_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder !! \nPress Any Key to play the game \n");
            Console.WriteLine("Enter player 1 name: ");
            string p1Name = Console.ReadLine();
            Player p1 = new Player(p1Name);
            Console.WriteLine("Enter player 2 name: ");
            string p2Name = Console.ReadLine();
            Player p2 = new Player(p2Name);

            while((p1.getPosition() < 100) || (p2.getPosition() < 100))
            {
                p1.PlayGame();
                if (p1.getPosition() == 100)
                {
                    break;
                }
                
                p2.PlayGame();
                if (p2.getPosition() == 100)
                {
                    break;
                }

            }
            
            
            Console.WriteLine("Press Any Key to exit. \n");
            Console.ReadLine();
        }
    }
}