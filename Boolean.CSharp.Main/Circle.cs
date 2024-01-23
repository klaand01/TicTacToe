using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Circle : Marker
    {
        public Circle(string playerName, Board board) : base("O", playerName, board)
        {

        }
    }
}