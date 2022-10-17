using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class TicTacToe
    {
        static string[,] board =
         {
            {"1","2","3" },
            {"4","5","6"},
            {"7","8","9" }
        };
        static string player1 = "X", player2 = "O";
        static void Main(string[] args)
        {
            bool tryAgain = false;
            string winner;
            while (true)
            {
                Console.Clear();
                DisplayBoard(board);
                Console.WriteLine("\n");

                do
                {
                    Console.WriteLine("Player 1 Choose your field: ");
                    int player1Choice = int.Parse(Console.ReadLine());
                    tryAgain = CheckBoardAndAdd(board, player1Choice, player1);
                } while (tryAgain);


                winner = CheckWin(board);
                if (CheckFull(board) == true || winner=="X" || winner=="O")
                {
                    break;
                }
                
                Console.Clear();
                DisplayBoard(board);
                Console.WriteLine("\n");

                do
                {
                    Console.WriteLine("Player 2 Choose your field: ");
                    int player2Choice = int.Parse(Console.ReadLine());
                    tryAgain = CheckBoardAndAdd(board, player2Choice, player2);
                } while (tryAgain);

                winner = CheckWin(board);
                if (CheckFull(board) == true || winner == "X" || winner == "O")
                {
                    break;
                }

            }

            if (CheckFull(board) == true && winner=="0")
            {
                Console.Clear();
                DisplayBoard(board);
                Console.WriteLine("\n");
                Console.WriteLine("The game ends in a draw");
            }
            if (winner == "X")
            {
                Console.Clear();
                DisplayBoard(board);
                Console.WriteLine("\n");
                Console.WriteLine("Player 1 wins!!");
            }
            else if(winner == "O")
            {
                Console.Clear();
                DisplayBoard(board);
                Console.WriteLine("\n");
                Console.WriteLine("Player 2 wins!!");
            }


            Console.Read();

        }


        public static void DisplayBoard(string[,] board)
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + board[0,0] + " | " + board[0,1] + " | " + board[0,2]  + " ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2] + " ");
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + " ");
            Console.WriteLine("   |   |   ");
        }

        public static bool CheckBoardAndAdd(string[,] board, int pos,string player)
        {
            
            switch (pos)
            {
                case 1:
                    if (board[0, 0] == "X" || board[0, 0] == "O") { Console.WriteLine("Incorrect input! Choose another field"); return true; }
                    else { board[0, 0] = player; return false; }
                    
                case 2:
                    if (board[0, 1] == "X" || board[0, 1] == "O") { Console.WriteLine("Incorrect input! Choose another field"); return true; }
                    else { board[0, 1] = player; return false; }
                    
                case 3:
                    if (board[0, 2] == "X" || board[0, 2] == "O") { Console.WriteLine("Incorrect input! Choose another field"); return true; }
                    else { board[0, 2] = player; return false; }
                    
                case 4:
                    if (board[1, 0] == "X" || board[1, 0] == "O") { Console.WriteLine("Incorrect input! Choose another field"); return true; }
                    else { board[1, 0] = player; return false; }
                    
                case 5:
                    if (board[1, 1] == "X" || board[1, 1] == "O") { Console.WriteLine("Incorrect input! Choose another field"); return true; }
                    else { board[1, 1] = player; return false; }
                    
                case 6:
                    if (board[1, 2] == "X" || board[1, 2] == "O") { Console.WriteLine("Incorrect input! Choose another field"); return true; }
                    else { board[1, 2] = player; return false; }
                    
                case 7:
                    if (board[2, 0] == "X" || board[2, 0] == "O") { Console.WriteLine("Incorrect input! Choose another field"); return true; }
                    else { board[2, 0] = player; return false; }
                    
                case 8:
                    if (board[2, 1] == "X" || board[2, 1] == "O") { Console.WriteLine("Incorrect input! Choose another field"); return true; }
                    else { board[2, 1] = player; return false; }
                    
                case 9:
                    if (board[2, 2] == "X" || board[2, 2] == "O") { Console.WriteLine("Incorrect input! Choose another field"); return true; }
                    else { board[2, 2] = player; return false; }

                default:
                    Console.WriteLine("Incorrect Position! Try again!");
                    return true;
            }
        }


        
        public static string CheckWin(string[,] board)
        {
            //horizontal across check
            int countX = 0, countO = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "X")
                    {
                        countX++;
                    }
                    else if (board[i, j] == "O")
                    {
                        countO++;
                    }
                }
                if (countX == 3) { return player1; }
                else if (countO == 3) { return player2; }
                countX = 0;
                countO = 0;
            }
            

            //vertical down check
            
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, j] == "X")
                    {
                        countX++;
                    }
                    else if (board[i, j] == "O")
                    {
                        countO++;
                    }
                }
                if (countX == 3) { return player1; }
                else if (countO == 3) { return player2; }
                countX = 0;
                countO = 0;
            }
            

            //diagonal 1 check
            
            for (int i = 0; i < 3; i++)
            {
                if (board[i, i] == "X")
                {
                    countX++;
                }
                else if (board[i, i] == "O")
                {
                    countO++;
                }
            }
            if (countX == 3) { return player1; }
            else if (countO == 3) { return player2; }


            //diagonal 2 check
            countX = 0;
            countO = 0;
            for (int i = 0, j = 2; i < 3; i++, j--)
            {if (board[i, j] == "X")
                {
                    countX++;
                }
                else if  (board[i, j] == "O")
                {
                    countO++;
                }
            }
            if (countX == 3) { return player1; }
            else if (countO == 3) { return player2; }
            return "0";
        }
        
       public static bool CheckFull(string[,] board)
        {
            int count = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    if(board[i,j]=="X" || board[i, j] == "O") { count++; }
                }
            }
            if (count != board.Length)
            {
                return false;
            }
            else { return true; }
            
        }
      
    }
}
