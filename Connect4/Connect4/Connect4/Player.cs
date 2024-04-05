using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public class Player
    {
        public int id;
        public string Name { get; set; }
        public string color;

     

        public Player(int id, string name, string color)
        {
            this.id = id;
            Name = name;
            this.color = color;
        }

        public virtual void MakeMove(int collomn)
        {
        }



    }
}
