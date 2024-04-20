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
        
        public int getPosition()
        {
            return position;
        }

        public int getRandomDice()
        {
            Random r = new Random();
            return r.Next(1, 7);
        }

        public void Ladder(int dice)
        {
            
            position += dice;
            Console.WriteLine(position);
        }

        public void Snake(int dice)
        {
            
            position-=dice;
            Console.WriteLine(position);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder");

            Player p1 = new Player();
            int choice;

            do
            {
                Console.WriteLine("Enter no.: 1:No play, 2:Ladder, 3: Snake, 0:exit the game");
                choice = Convert.ToInt32(Console.ReadLine());
                if (p1.getPosition() < 100)
                {
                    
                    switch (choice)
                    {
                        case 1: Console.WriteLine("You have missed the chance to play"); break;
                        case 2: p1.Ladder(p1.getRandomDice()); break;
                        case 3: p1.Snake(p1.getRandomDice()); break;
                        case 0: Console.WriteLine("Exiting"); break;
                        default: Console.WriteLine("Enter valid choice"); break;
                    }
                }
                else
                {
                    Console.WriteLine("You are winner");
                    break;
                }
            } while (choice!=0);
            
        }
    }
}