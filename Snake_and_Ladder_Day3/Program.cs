namespace Snake_and_Ladder_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder !! \n");

            Console.WriteLine("How many players are going to play? \n");
            int PlayersCount = Convert.ToInt32(Console.ReadLine());
            Player[] players = new Player[PlayersCount];

            for(int i= 0; i<PlayersCount; i++)
            {
                Console.WriteLine("Enter player name "+ (i+1));
                players[i]= new Player(Console.ReadLine());
            }

            
            while (true)
            {
                bool flag = false;
                for(int i = 0; i < PlayersCount; i++)
                {
                    players[i].PlayGame();
                    if (players[i].getPosition() == 100)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            
            Console.WriteLine("Press Any Key to exit. \n");
            Console.ReadLine();
        }
    }
}