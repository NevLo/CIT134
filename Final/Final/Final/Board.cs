using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Board
    {
        public Piece[,] board = new Piece[8,8];

        public Board()
        {
            this.NewGame();
        }

        private void NewGame()
        {
            board[0, 0] = new Piece("Rook",   'B');
            board[0, 1] = new Piece("Knight", 'B');
            board[0, 2] = new Piece("Bishop", 'B');
            board[0, 3] = new Piece("King",   'B');
            board[0, 4] = new Piece("Queen",  'B');
            board[0, 5] = new Piece("Bishop", 'B');
            board[0, 6] = new Piece("Knight", 'B');
            board[0, 7] = new Piece("Rook",   'B');

            board[1, 0] = new Piece("Pawn", 'B');
            board[1, 1] = new Piece("Pawn", 'B');
            board[1, 2] = new Piece("Pawn", 'B');
            board[1, 3] = new Piece("Pawn", 'B');
            board[1, 4] = new Piece("Pawn", 'B');
            board[1, 5] = new Piece("Pawn", 'B');
            board[1, 6] = new Piece("Pawn", 'B');
            board[1, 7] = new Piece("Pawn", 'B');

            board[2, 0] = new Piece(" ", ' ');
            board[2, 1] = new Piece(" ", ' ');
            board[2, 2] = new Piece(" ", ' ');
            board[2, 3] = new Piece(" ", ' ');
            board[2, 4] = new Piece(" ", ' ');
            board[2, 5] = new Piece(" ", ' ');
            board[2, 6] = new Piece(" ", ' ');
            board[2, 7] = new Piece(" ", ' ');

            board[3, 0] = new Piece(" ", ' ');
            board[3, 1] = new Piece(" ", ' ');
            board[3, 2] = new Piece(" ", ' ');
            board[3, 3] = new Piece(" ", ' ');
            board[3, 4] = new Piece(" ", ' ');
            board[3, 5] = new Piece(" ", ' ');
            board[3, 6] = new Piece(" ", ' ');
            board[3, 7] = new Piece(" ", ' ');

            board[4, 0] = new Piece(" ", ' ');
            board[4, 1] = new Piece(" ", ' ');
            board[4, 2] = new Piece(" ", ' ');
            board[4, 3] = new Piece(" ", ' ');
            board[4, 4] = new Piece(" ", ' ');
            board[4, 5] = new Piece(" ", ' ');
            board[4, 6] = new Piece(" ", ' ');
            board[4, 7] = new Piece(" ", ' ');

            board[5, 0] = new Piece(" ", ' ');
            board[5, 1] = new Piece(" ", ' ');
            board[5, 2] = new Piece(" ", ' ');
            board[5, 3] = new Piece(" ", ' ');
            board[5, 4] = new Piece(" ", ' ');
            board[5, 5] = new Piece(" ", ' ');
            board[5, 6] = new Piece(" ", ' ');
            board[5, 7] = new Piece(" ", ' ');

            board[6, 0] = new Piece("Pawn", 'W');
            board[6, 1] = new Piece("Pawn", 'W');
            board[6, 2] = new Piece("Pawn", 'W');
            board[6, 3] = new Piece("Pawn", 'W');
            board[6, 4] = new Piece("Pawn", 'W');
            board[6, 5] = new Piece("Pawn", 'W');
            board[6, 6] = new Piece("Pawn", 'W');
            board[6, 7] = new Piece("Pawn", 'W');

            board[7, 0] = new Piece("Rook",   'W');
            board[7, 1] = new Piece("Knight", 'W');
            board[7, 2] = new Piece("Bishop", 'W');
            board[7, 4] = new Piece("King",   'W');
            board[7, 3] = new Piece("Queen",  'W');
            board[7, 5] = new Piece("Bishop", 'W');
            board[7, 6] = new Piece("Knight", 'W');
            board[7, 7] = new Piece("Rook",   'W');
        }

        public void display()
        {
            for(int i = 0; i < board.Length; i++)
            {
                if(i < 8)
                {
                    Console.WriteLine("----------------------------------------");
                        for (int j = 0; j < board.Length; ++j)
                    {
                        if(j < 8)
                        Console.Write($"| {board[i , j].display()} ");
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("----------------------------------------");
            }
        }

    }
}
