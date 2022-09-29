using System;
using System.Collections.Generic;

namespace TicTacToe // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> board = emptyBoard();
            string currentPlayer = "y";
            
            // Continues the game until it is won
            while (!winner(board, currentPlayer) && !tie(board))
            {
                currentPlayer = switchPlayer(currentPlayer);
                displayBoard(board);
    
                int choice = playerMoves(currentPlayer);
                updateBoard(currentPlayer, board, choice);
            }
            displayBoard(board);

            if (winner(board, currentPlayer))
            {
                Console.WriteLine($"Congratulations player {currentPlayer}! You won!");
            }
            else
            {
                Console.WriteLine("Game over. Game ends in a tie!");
            }
            
        }

        // Generate list to display board
        static List<string> emptyBoard() 
        {
            List<string> boardValues = new List<string>();
            
            for (int i = 1; i < 10; i++) 
            {
                boardValues.Add(i.ToString());
            }
            return boardValues;
        }

        // Generate and display board
        static void displayBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("- + - + -");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("- + - + -");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }

        // Prompt and record user input
        static int playerMoves(string player) 
        {
            Console.WriteLine($"{player}'s turn to choose a square (1-9): ");
            string move = Console.ReadLine();
            int value = int.Parse(move);

            return value;
        }

        // Update board with player moves
        static void updateBoard(string player, List<string> board, int choice)
        {
            int index = choice - 1;
            board[index] = player;
        }

        // Handles players' turns
        static string switchPlayer(string activePlayer)
        {
            if (activePlayer == "x") {
                activePlayer = "y";
            }
            else 
            {
                activePlayer = "x";
            }
            return activePlayer;
        }

        // Determines if game is won
        static bool winner(List<string> board, string player)
        {
            bool winner = false;

            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player))
            {
                winner = true;
            }
            return winner;
        }

        static bool tie(List<string> board)
        {
            bool foundDigit = true;

            foreach (string value in board)
            {
                if (char.IsDigit(value[0]))
                {
                    foundDigit = true;
                    break;
                }
            }
            return !foundDigit;
        }
    }
}
