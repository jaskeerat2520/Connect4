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


       

        public override int MakeMove()
        {
            int randomColumn = rnd.Next(0, 7); // Adjust range according to the board width
            return randomColumn;
        }
    }
}