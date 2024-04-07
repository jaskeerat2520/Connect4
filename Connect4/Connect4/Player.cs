using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public abstract class Player
    {
        protected string name;
        protected int id;

        public string Name { get { return name; } }


        public Player(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public abstract int MakeMove();
    }



}

