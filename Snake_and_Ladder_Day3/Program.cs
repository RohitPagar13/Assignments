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
            if (10 - position >= dice)
            {
                position += dice;
                Console.WriteLine("Yay !! You have got Ladder " + dice + " and now you are at position:  " + this.getPosition()+"\n");
            }
            else
            {
                Console.WriteLine("Oh-Shit !! You have got ladder " + dice + "  but you need only " + (10 - position) + " points to win \n");
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
            Console.WriteLine("Welcome to Snake and Ladder !! \nPress Enter to play the game \n");

            Player p1 = new Player();
            int choice;
            
            while(p1.getPosition()<10)
            {
                choice = p1.getRandomChoice();
                    switch (choice)
                    {
                        case 1: 
                            Console.WriteLine("Oops !! You have missed the chance to play and you are at position: "+ p1.getPosition() + "\n"); 
                            break;

                        case 2:
                            int diceLadder = p1.getRandomDice();
                            p1.Ladder(diceLadder);
                             
                            if (p1.getPosition() == 10) { 
                                Console.WriteLine("Congratulations !!! You are winner. \n");
                                }
                            break;

                        case 3:
                            int diceSnake = p1.getRandomDice();
                            p1.Snake(diceSnake);
                            Console.WriteLine("Oh-no !! You have got Snake "+ diceSnake + " and now you are at position: " + p1.getPosition() + "\n");
                            break;
                    }
            }
            Console.WriteLine("Press Enter to exit. \ns");
            Console.ReadLine();
        }
    }
}