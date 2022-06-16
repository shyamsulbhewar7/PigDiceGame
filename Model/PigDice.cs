using System;
using System.Collections.Generic;
using System.Text;

namespace PigDiceOOP.Model
{
    public class PigDice
    {
        private int _totalscore;
        public PigDice()
        {
            _totalscore = 0;
        }
        public int Play()
        {
            Random rnd = new Random();
            int turns = 1;
            int current = 0;
            while (_totalscore < 21)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("TURN " + turns);
                turns++;
                current = 0;
                while (true)
                {
                    Console.WriteLine("Roll or Hold ? ( r/h ) : ");
                    char p;
                    p = Console.ReadLine()[0];
                    if (p == 'r')
                    {
                        int number = rnd.Next(1, 7);
                        Console.WriteLine("Die : " + number);
                        if (number > 1)
                        {
                            current += number;
                        }
                        else
                        {
                            current = 0;
                            Console.WriteLine("Turn Over. No Score. ");
                            break;
                        }
                    }
                    else
                    {
                        _totalscore += current;
                        break;
                    }
                }
                Console.WriteLine("Total Score :" + _totalscore);
                Console.WriteLine("Score for this turn :" + current);
            }
            return turns;
        }


    }
}
