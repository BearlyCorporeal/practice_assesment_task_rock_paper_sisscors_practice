using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_task_rock_paper_sisscors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int cptwin = 0;
            int you_lose = 0;
            int cprwin = 0;
            int ptwin = 0;
            int prwin = 0;
            int pinput = 0;
            int roundnum = 1;
            int turnnum = 1;
            int cpinput = 0;
            string input;
            Console.WriteLine("lets play rock papeer sisscors best of three three rounds.");
            while (roundnum < 3) {
                while (turnnum < 3)
                {
                    input = Console.ReadLine();
                    if (input == "rock")
                    {
                        pinput = 1;
                    }
                    if (input == "scissors")
                    {
                        pinput = 2;
                    }
                    if (input == "paper")
                    {
                        pinput = 3;
                    }
                    cpinput = r.Next(1, 3);
                    if (cpinput == 1)
                    {
                        Console.WriteLine("rock");
                    }
                    if (cpinput == 2)
                    {
                        Console.WriteLine("scissors");
                    }
                    if (cpinput == 3)
                    {
                        Console.WriteLine("paper");
                    }
                    if (cpinput == 1 && pinput == 1)
                    {
                        Console.WriteLine("draw");
                    }
                    if (cpinput == 3 && pinput == 3)
                    {
                        Console.WriteLine("draw");
                    }
                    if (cpinput == 2 && pinput == 2)
                    {
                        Console.WriteLine("draw");
                    }
                    if (cpinput == 1 && pinput == 2)
                    {
                        cptwin = cptwin + 1;
                        Console.WriteLine("I win this turn");
                        turnnum = turnnum + 1;
                    }
                    if (cpinput == 2 && pinput == 3)
                    {
                        cptwin = cptwin + 1;
                        Console.WriteLine("I win this turn");
                        turnnum = turnnum + 1;
                    }
                    if (cpinput == 3 && pinput == 1)
                    {
                        cptwin = cptwin + 1;
                        Console.WriteLine("I win this turn");
                        turnnum = turnnum + 1;
                    }
                    if (cpinput == 1 && pinput == 3)
                    {
                        Console.WriteLine("you win this turn");
                        ptwin = ptwin + 1;
                        turnnum = turnnum + 1;
                    }
                    if (cpinput == 3 && pinput == 2)
                    {
                        Console.WriteLine("you win this turn");
                        ptwin = ptwin + 1;
                        turnnum = turnnum + 1;
                    }
                    if (cpinput == 2 && pinput == 1)
                    {
                        Console.WriteLine("you win this turn");
                        ptwin = ptwin + 1;
                        turnnum = turnnum + 1;
                    }
                    if (turnnum == 3 && cptwin > ptwin)
                    {
                        Console.WriteLine("i win this round");
                        prwin = prwin + 1;
                        ptwin = 0;
                        turnnum = 0;
                    }
                    if (turnnum == 3 && cptwin < ptwin)
                    {
                        Console.WriteLine("you win this round");
                        cprwin = cprwin + 1;
                        ptwin = 0;
                        turnnum = 1;
                    }
                    if (roundnum == 3 && cptwin < ptwin)
                    {
                        Console.WriteLine("you win i guess");
                    }
                    if (roundnum == 3 && cptwin < ptwin)
                    {
                        Console.WriteLine("i win");
                        while(you_lose < 200000)
                        {
                            Console.Write("HA ");
                            you_lose = you_lose + 1;
                        }
                    }
                }
            }
           
            

        }
    }
}
