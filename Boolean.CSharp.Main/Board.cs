using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main
{
    public class Board
    {
        private string[] spaces = new string[9];

        public Board()
        {
            spaces[0] = "___";
            spaces[1] = "|___|";
            spaces[2] = "___";

            spaces[3] = "___";
            spaces[4] = "|___|";
            spaces[5] = "___";

            spaces[6] = "___";
            spaces[7] = "|___|";
            spaces[8] = "___";
        }

        public void DrawBoard()
        {
            string board = "";

            for (int i = 0; i < spaces.Length; i++)
            {
                if (i % 3 == 0)
                    board += "\n";

                board += spaces[i];
            }
            
            Console.WriteLine(board);
        }
    }
}