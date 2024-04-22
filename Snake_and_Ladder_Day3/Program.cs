using System.Collections;

namespace Snake_and_Ladder_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder !! \n");
            Console.WriteLine("How many players are going to play? \n");
            int PlayersCount = Convert.ToInt32(Console.ReadLine());
            if(PlayersCount > 1 )
            {
                List<Player> players = new List<Player>(PlayersCount);

                for (int i = 0; i < PlayersCount; i++)
                {
                    Console.WriteLine("Enter player name " + (i + 1));
                    players.Add(new Player(Console.ReadLine()));
                }
                string[] winners = new string[PlayersCount];
                int j = 0;

                while (players.Count>1)
                {
                    string name;
                    for (int i = 0; i < players.Count; i++)
                    {
                        players[i].PlayGame();
                        if (players[i].getPosition() == 100)
                        {
                            
                            winners[j] = players[i].getName();
                            j++;
                            players.RemoveAt(i);
                            break; 
                        }
                        
                    }
                }
                winners[winners.Length-1] = players[0].getName();
                Console.WriteLine("Winning Positions: ");
                for(int i=0; i<winners.Length; i++)
                {
                    Console.WriteLine((i+1) +" "+ winners[i]);
                }

                Console.WriteLine("Press Any Key to exit. \n");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter Valid Count or greater than 1");
            }
        }
    }
}