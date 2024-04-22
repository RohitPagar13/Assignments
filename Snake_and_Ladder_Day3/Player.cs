using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder_Day3
{
    internal class Player
    {
        private int position;
        private int count;
        private string name;

        public Player(string name)
        {
            position = 0;
            this.name = name;
        }

        public int getPosition()
        {
            return position;
        }

        public int getCount()
        {
            return count;
        }
        
        public string getName()
        {
            return name;
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
            count++;
            if (100 - position >= dice)
            {
                position += dice;
                Console.WriteLine("Yay !! " + this.name + " have got Ladder " + dice + " and now you are at position:  " + this.getPosition() + "\n");

            }
            else
            {
                Console.WriteLine("Oh-Shit !! " + this.name + " have got ladder " + dice + "  but you need only " + (100 - position) + " points to win. \n");
            }

        }

        public void Snake(int dice)
        {
            count++;
            position -= dice;
            if (position < 0)
            {
                position = 0;
            }
            Console.WriteLine("Oh-no !! " + this.name + "  have got Snake " + dice + " and now you are at position: " + this.getPosition() + "\n");
        }

        public void PlayGame()
        {
            while (this.getPosition() < 100)
            {
                int dice = this.getRandomDice();
                int choice = this.getRandomChoice();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Oops !! " + this.name + " have missed the chance to play and you are at position: " + this.getPosition() + "\n");
                        break;

                    case 2:

                        this.Ladder(dice);

                        if (this.getPosition() == 100)
                        {
                            Console.WriteLine("Congratulations  " + this.name + " !!! You are winner. You took " + this.getCount() + " chances to win." + "\n");
                        }

                        this.PlayGame();

                        break;

                    case 3:
                        this.Snake(dice);
                        break;

                }
                break;
            }
        }
    }
}
