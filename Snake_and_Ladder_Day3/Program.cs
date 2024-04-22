namespace Snake_and_Ladder_Day3
{
    class Player
    {
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

        public int getRandomChoice()
        {
            Random r = new Random();
            return r.Next(1, 4);
        }

        public void Ladder(int dice)
        {
            
            position += dice;
            if (position > 100)
            {
                position = 100;
            }

        }

        public void Snake(int dice)
        {
            
            position-=dice;
            if(position < 0 )
            {
                position = 0;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder !! \nPress Enter to play the game");

            Player p1 = new Player();
            int choice;

            while(p1.getPosition()<100)
            {
                choice = p1.getRandomChoice();
                Console.ReadLine();
                    switch (choice)
                    {
                        case 1: 
                            Console.WriteLine("Oops !! You have missed the chance to play and you are at position: "+ p1.getPosition()); 
                            break;

                        case 2:
                            int diceLadder = p1.getRandomDice();
                            p1.Ladder(diceLadder);
                            Console.WriteLine("Yay !! You have got Ladder "+ diceLadder + " and now you are at position:  " + p1.getPosition()); 
                            if (p1.getPosition() >= 100) { 
                                Console.WriteLine("Congratulations !!! You are winner.");
                                }
                            break;

                        case 3:
                            int diceSnake = p1.getRandomDice();
                            p1.Snake(diceSnake);
                            Console.WriteLine("Oh-no !! You have got Snake "+ diceSnake + " and now you are at position: " + p1.getPosition());
                            break;
                    }
            }
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}