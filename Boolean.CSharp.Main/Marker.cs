using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace Boolean.CSharp.Main
{
    public abstract class Marker
    {
        Board board = null;
        private string mark;
        private string playerName;

        protected Marker(string mark, string playerName, Board board)
        {
            this.mark = mark;
            this.board = board;
            this.playerName = playerName;
        }

        public string GetMark()
        {
            return mark;
        }

        public string GetName()
        {
            return playerName;
        }

        public string AddMarker(int index)
        {
            return board.AddMarker(this, index);
        }
    }
}