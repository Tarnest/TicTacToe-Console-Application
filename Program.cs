using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe();
        }

        static void TicTacToe()
        {
            string[] elements = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            string[] newElements = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool isX = true;
            bool gameOver = false;
            
            while (true)
            {
                Console.Clear();
                GenerateBoard(elements);

                string replacement;

                if (isX)
                {
                    replacement = "X";
                    isX = false;
                } else
                {
                    replacement = "O";
                    isX = true;
                }

                Console.WriteLine("\n{0} pick a number!", replacement);
                string num = Console.ReadLine();


                // num is lowercase because of "stop" case
                switch (num.ToLower())
                {
                    case "stop":
                        System.Environment.Exit(0);
                        break;
                    case "1":
                        if (elements[0] == "1")
                        {
                            elements[0] = replacement;
                        } else
                        {
                            goto default;
                        }
                        break;

                    case "2":
                        if (elements[1] == "2")
                        {
                            elements[1] = replacement;
                        }
                        else
                        {
                            goto default;
                        }
                        break;

                    case "3":
                        if (elements[2] == "3")
                        {
                            elements[2] = replacement;
                        }
                        else
                        {
                            goto default;
                        }
                        break;

                    case "4":
                        if (elements[3] == "4")
                        {
                            elements[3] = replacement;
                        }
                        else
                        {
                            goto default;
                        }
                        break;

                    case "5":
                        if (elements[4] == "5")
                        {
                            elements[4] = replacement;
                        }
                        else
                        {
                            goto default;
                        }
                        break;

                    case "6":
                        if (elements[5] == "6")
                        {
                            elements[5] = replacement;
                        }
                        else
                        {
                            goto default;
                        }
                        break;

                    case "7":
                        if (elements[6] == "7")
                        {
                            elements[6] = replacement;
                        }
                        else
                        {
                            goto default;
                        }
                        break;

                    case "8":
                        if (elements[7] == "8")
                        {
                            elements[7] = replacement;
                        }
                        else
                        {
                            goto default;
                        }
                        break;

                    case "9":
                        if (elements[8] == "9")
                        {
                            elements[8] = replacement;
                        }
                        else
                        {
                            goto default;
                        }
                        break;

                    default:
                        Console.WriteLine("try again!");
                        isX = !isX;

                        Thread.Sleep(2000);

                        continue;
                }

                string result = AnalyzeResult(elements);

                if (result != null)
                {
                    Console.Clear();
                    GenerateBoard(elements);
                    Console.WriteLine("{0} wins with {1}.", replacement, result);
                    gameOver = true;
                }

                if (gameOver)
                {
                    Console.WriteLine("\nNew Game?");
                    string answer = Console.ReadLine();

                    if (answer.ToLower() == "no")
                    {
                        break;
                    }
                    else
                    {
                        gameOver = false;
                        elements = newElements;

                        Console.Clear();
                        Console.WriteLine("Starting a new game");
                        Thread.Sleep(750);

                        Console.Clear();
                        Console.WriteLine("Starting a new game.");
                        Thread.Sleep(750);

                        Console.Clear();
                        Console.WriteLine("Starting a new game..");
                        Thread.Sleep(750);

                        Console.Clear();
                        Console.WriteLine("Starting a new game...");
                        Thread.Sleep(750);
                    }
                }
            }
        }

        static void GenerateBoard(string[] elements)
        {
            /* Example output
             *  ____________
             * | 1 | 2 | 3 |
             * | 4 | 5 | 6 |
             * | 7 | 8 | 9 |
             *  ____________
             *
            */

            Console.WriteLine(" ____________");
            Console.WriteLine("| {0} | {1} | {2} |", elements[0], elements[1], elements[2]);
            Console.WriteLine("| {0} | {1} | {2} |", elements[3], elements[4], elements[5]);
            Console.WriteLine("| {0} | {1} | {2} |", elements[6], elements[7], elements[8]);
            Console.WriteLine(" ____________ ");
        }

        static string AnalyzeResult(string[] elements)
        {
            // first row horizontal
            if (elements[0] == elements[1] && elements[0] == elements[2])
            {
                return "First Row Horizontal";
            } 

            // second row horizontal
            else if (elements[3] == elements[4] && elements[3] == elements[5])
            {
                return "Second Row Horizontal";
            } 
            
            // third row horizontal
            else if (elements[6] == elements[7] && elements[6] == elements[8])
            {
                return "Third Row Horizontal";
            }
            
            // first column vertical
            else if (elements[0] == elements[3] && elements[0] == elements[6])
            {
                return "First Column Vertical";
            }
            
            // second column vertical
            else if (elements[1] == elements[4] && elements[1] == elements[7])
            {
                return "Second Column Vertical";
            }
            
            // third column vertical
            else if (elements[2] == elements[5] && elements[2] == elements[8])
            {
                return "Third Column Vertical";
            }
            
            // top left to bottom right diagonal
            else if (elements[0] == elements[4] && elements[0] == elements[8])
            {
                return "Top Left to Bottom Right Diagonal";
            }
            
            // bottom left to top right diagonal
            else if (elements[6] == elements[4] && elements[6] == elements[2])
            {
                return "Bottom Left to Top Right Diagonal";
            }

            // not a win
            return null;
        }
    }
}
