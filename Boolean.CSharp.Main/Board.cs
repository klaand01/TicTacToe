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
        private bool haveWon;

        public Board()
        {
            haveWon = false;

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

            //Looping through all the spaces
            for (int i = 0; i < spaces.Length; i++)
            {
                if (i % 3 == 0)
                    board += "\n";

                board += spaces[i];
            }
            
            Console.WriteLine(board);
        }

        public string AddMarker(Marker player, int i)
        {
            //Checking parameters
            if (player == null)
                return "Player is not initialized";

            if ((i - 1) > spaces.Length || (i - 1) < 0)
                return "Not a possible space";

            //Setting up changes
            int markIndex = 1;
            int index = i - 1;
            string mark = player.GetMark();

            if (spaces[index][0] == '|')
                markIndex++;

            //Replaces the character with the marker
            if (spaces[index].Contains('O') || spaces[index].Contains('X'))
                return "Space already taken!";

            spaces[index] = spaces[index].Insert(markIndex, mark);
            spaces[index] = spaces[index].Remove(markIndex + 1, 1);
            
            //Afterchecks for the players
            DrawBoard();
            CheckWinCondition(player, index);
            return "";
        }

        private void CheckRow(string mark, int index)
        {
            int check1 = 0;
            int check2 = 0;

            //Checking the row
            if (index % 3 == 0)
            {
                check1 = index + 1;
                check2 = index + 2;
            }
            else if (index % 3 == 1)
            {
                check1 = index + 1;
                check2 = index - 1;
            }
            else if (index % 3 == 2)
            {
                check1 = index - 1;
                check2 = index - 2;
            }

            if (spaces[check1].Contains(mark) && spaces[check2].Contains(mark))
                haveWon = true;
        }

        private void CheckColumn(string mark, int index)
        {
            int check1 = 0;
            int check2 = 0;

            //Checking the column
            if (index < 3)
            {
                check1 = index + 3;
                check2 = index + 6;
            }
            else if (index < 6)
            {
                check1 = index + 3;
                check2 = index - 3;
            }
            else if (index < 9)
            {
                check1 = index - 3;
                check2 = index - 6;
            }

            if (spaces[check1].Contains(mark) && spaces[check2].Contains(mark))
                haveWon = true;
        }

        private void CheckWinCondition(Marker player, int index)
        {
            string mark = player.GetMark();
            
            CheckRow(mark, index);
            CheckColumn(mark, index);
            
            //Checking diagonal
            if (spaces[4].Contains(mark))
            {
                if (spaces[0].Contains(mark) && spaces[8].Contains(mark))
                    haveWon = true;
                else if (spaces[2].Contains(mark) && spaces[6].Contains(mark))
                    haveWon = true;
            }
        }

        public bool PlayerHaveWon()
        {
            return haveWon;
        }
    }
}