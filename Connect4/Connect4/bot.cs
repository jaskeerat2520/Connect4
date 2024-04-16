using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Connect4
{
    public class Bot : Player
    {
        private Random rnd = new Random();

        public Bot() : base("Computer", 2) { }

        public override int MakeMove(GameBoard board)
        {
            if (board.IsGameOver()) return -1; 

            // Random AI (Easy mode)
            if (rnd.Next(0, 2) == 0)
            {
                return MakeRandomMove(board);
            }

            // Minimax AI (Hard mode)
            return MakeMinMaxMove(board);
        }

        private int MakeRandomMove(GameBoard board)
        {
            // Check for available columns and choose a random one
            List<int> availableColumns = new List<int>();
            for (int col = 0; col < board.GetWidth(); col++)
            {
                if (!board.IsColumnFull(col))
                {
                    availableColumns.Add(col);
                }
            }

            if (availableColumns.Count == 0)
            {
                return -1; // No available moves
            }

            return availableColumns[rnd.Next(0, availableColumns.Count)];
        }

        private int MakeMinMaxMove(GameBoard board)
        {
            int bestMove = -1;
            int bestScore = int.MinValue;

            for (int col = 0; col < board.GetWidth(); col++)
            {
                if (!board.IsColumnFull(col))
                {
                    // Simulate dropping a piece in this column
                    int row = GetNextAvailableRow(board, col);
                    board.SetCell(row, col, id);

                    // Calculate the score for this move using the Minimax algorithm
                    int score = Minimax(board, 0, false);

                    // Undo the move
                    board.SetCell(row, col, 0);

                    // Update the best move and score if necessary
                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestMove = col;
                    }
                }
            }

            return bestMove;
        }

        private int Minimax(GameBoard board, int depth, bool maximizingPlayer)
        {
            int result = Evaluate(board);

            // If the game is over or the maximum depth is reached, return the evaluation score
            if (result != 0 || depth == 4)
            {
                return result;
            }

            if (maximizingPlayer)
            {
                int maxEval = int.MinValue;
                for (int col = 0; col < board.GetWidth(); col++)
                {
                    if (!board.IsColumnFull(col))
                    {
                        // Simulate dropping a piece in this column
                        int row = GetNextAvailableRow(board, col);
                        board.SetCell(row, col, id);

                        // Recursively call Minimax with the next depth and switch player
                        int eval = Minimax(board, depth + 1, false);

                        // Undo the move
                        board.SetCell(row, col, 0);

                        maxEval = Math.Max(maxEval, eval);
                    }
                }
                return maxEval;
            }
            else
            {
                int minEval = int.MaxValue;
                for (int col = 0; col < board.GetWidth(); col++)
                {
                    if (!board.IsColumnFull(col))
                    {
                        // Simulate dropping a piece in this column
                        int row = GetNextAvailableRow(board, col);
                        board.SetCell(row, col, id == 1 ? 2 : 1);

                        // Recursively call Minimax with the next depth and switch player
                        int eval = Minimax(board, depth + 1, true);

                        // Undo the move
                        board.SetCell(row, col, 0);

                        minEval = Math.Min(minEval, eval);
                    }
                }
                return minEval;
            }
        }

        private int GetNextAvailableRow(GameBoard board, int col)
        {
            for (int row = 0; row < board.GetHeight(); row++)
            {
                if (board.GetCell(row, col) == 0)
                {
                    return row;
                }
            }
            return -1; // Column is full
        }

        private int Evaluate(GameBoard board)
        {
            int score = 0;

            // Check for potential winning moves for the bot
            int botPotentialWins = CountPotentialWins(board, id);
            score += botPotentialWins * 100;

            // Check for potential winning moves for the opponent (to block them)
            int opponentPotentialWins = CountPotentialWins(board, id == 1 ? 2 : 1);
            score -= opponentPotentialWins * 100;

            // Evaluate the number of connected pieces in each direction
            score += EvaluateConnectedPieces(board, id) * 10;
            score -= EvaluateConnectedPieces(board, id == 1 ? 2 : 1) * 10;

            return score;
        }

        private int CountPotentialWins(GameBoard board, int playerId)
        {
            int potentialWins = 0;

            // Check horizontal potential wins
            for (int row = 0; row < board.GetHeight(); row++)
            {
                for (int col = 0; col <= board.GetWidth() - 4; col++)
                {
                    if (IsPotentialWin(board, row, col, 0, 1, playerId))
                    {
                        potentialWins++;
                    }
                }
            }

            // Check vertical potential wins
            for (int col = 0; col < board.GetWidth(); col++)
            {
                for (int row = 0; row <= board.GetHeight() - 4; row++)
                {
                    if (IsPotentialWin(board, row, col, 1, 0, playerId))
                    {
                        potentialWins++;
                    }
                }
            }

            // Check diagonal (top-left to bottom-right) potential wins
            for (int row = 0; row <= board.GetHeight() - 4; row++)
            {
                for (int col = 0; col <= board.GetWidth() - 4; col++)
                {
                    if (IsPotentialWin(board, row, col, 1, 1, playerId))
                    {
                        potentialWins++;
                    }
                }
            }

            // Check diagonal (top-right to bottom-left) potential wins
            for (int row = 0; row <= board.GetHeight() - 4; row++)
            {
                for (int col = 3; col < board.GetWidth(); col++)
                {
                    if (IsPotentialWin(board, row, col, 1, -1, playerId))
                    {
                        potentialWins++;
                    }
                }
            }

            return potentialWins;
        }

        private bool IsPotentialWin(GameBoard board, int row, int col, int rowDelta, int colDelta, int playerId)
        {
            for (int i = 0; i < 4; i++)
            {
                if (board.GetCell(row + i * rowDelta, col + i * colDelta) != playerId &&
                    board.GetCell(row + i * rowDelta, col + i * colDelta) != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private int EvaluateConnectedPieces(GameBoard board, int playerId)
        {
            int connectedPieces = 0;

            // Check horizontal connected pieces
            for (int row = 0; row < board.GetHeight(); row++)
            {
                for (int col = 0; col <= board.GetWidth() - 4; col++)
                {
                    connectedPieces += CountConnectedPieces(board, row, col, 0, 1, playerId);
                }
            }

            // Check vertical connected pieces
            for (int col = 0; col < board.GetWidth(); col++)
            {
                for (int row = 0; row <= board.GetHeight() - 4; row++)
                {
                    connectedPieces += CountConnectedPieces(board, row, col, 1, 0, playerId);
                }
            }

            // Check diagonal (top-left to bottom-right) connected pieces
            for (int row = 0; row <= board.GetHeight() - 4; row++)
            {
                for (int col = 0; col <= board.GetWidth() - 4; col++)
                {
                    connectedPieces += CountConnectedPieces(board, row, col, 1, 1, playerId);
                }
            }

            // Check diagonal (top-right to bottom-left) connected pieces
            for (int row = 0; row <= board.GetHeight() - 4; row++)
            {
                for (int col = 3; col < board.GetWidth(); col++)
                {
                    connectedPieces += CountConnectedPieces(board, row, col, 1, -1, playerId);
                }
            }

            return connectedPieces;
        }

        private int CountConnectedPieces(GameBoard board, int row, int col, int rowDelta, int colDelta, int playerId)
        {
            int connectedPieces = 0;
            int emptySpaces = 0;

            for (int i = 0; i < 4; i++)
            {
                if (board.GetCell(row + i * rowDelta, col + i * colDelta) == playerId)
                {
                    connectedPieces++;
                }
                else if (board.GetCell(row + i * rowDelta, col + i * colDelta) == 0)
                {
                    emptySpaces++;
                }
            }

            // If there are 4 connected pieces and no empty spaces, it's a winning configuration
            if (connectedPieces == 4 && emptySpaces == 0)
            {
                return 100; // Maximum score for winning configuration
            }

            return connectedPieces;
        }
    }
}
