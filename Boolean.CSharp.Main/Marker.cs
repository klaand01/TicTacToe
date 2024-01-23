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
        private string mark;
        private string playerName;

        protected Marker(string mark, string playerName)
        {
            this.mark = mark;
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
    }
}