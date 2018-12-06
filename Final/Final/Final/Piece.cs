using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Piece
    {
        private string name = "";
        private char fInitial;
        private char team;
        private Boolean first;

        public Piece(String name, char Team)
        {
            this.name = name;
            this.team = Team;
            fInitial = name.ToCharArray()[0];
            first = true;
        }

        public String display()
        {
            return team.ToString() + fInitial.ToString();
        }
        public int[] Move()
        {
            int[] temp = new int[2];
            switch (name) {
                case "Rook":
                    break;
                case "Bishop":
                    break;
                case "Knight":
                    break;
                case "King":
                    break;
                case "Queen":
                    break;
                case "Pawn":
                    break;





            }
            return temp;
        }














    }
}
