using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    public class User : Player



    {
        public User(int id, string name, string color) : base(name, id )
        {
        }


     

        public override int MakeMove()
        {
            throw new NotImplementedException();
        }
    }
}
