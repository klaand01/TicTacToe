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

        public void AddMarker(string mark, int i)
        {
            if (i > spaces.Length || i < 0)
                return;

            if (mark != "X" && mark != "O")
                return;

            int markIndex = 1;
            int index = i - 1;

            if (spaces[index][0] == '|')
                markIndex = 2;

            spaces[index] = spaces[index].Insert(markIndex, mark);
            spaces[index] = spaces[index].Remove(markIndex + 1, 1);
            DrawBoard();
        }
    }
}