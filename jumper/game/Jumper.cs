using System;
using System.Collections.Generic;

namespace Jumper

{
    /// <summary>
    /// Jumper class controls the parachute.
    /// </summary>    
    public class Jumper
    {
        private TerminalService _terminalService = new TerminalService();
        private List<string> _jumper = new List<string>();
        
        /// <summary>
        /// Constructs a new instance of Jumper.
        /// </summary>
        public Jumper()
        {
            _jumper.Add(@" ___ ");
            _jumper.Add(@"/___\");
            _jumper.Add(@"\   /");
            _jumper.Add(@" \ / ");
            _jumper.Add(@"  O");
            _jumper.Add(@"/ | \");
            _jumper.Add(@" / \");
            displayJumper();
        }
        
        /// <summary>
        /// Removes parts of the parachute one at a time.
        /// </summary>
        public void updateJumper()
        {
            if (_jumper[0] == "  O")
            {
                _jumper[0] = "  X";
            } else 
            {
                _jumper.RemoveAt(0);
            }
        }
        /// <summary>
        /// Checks to see if the player has any turns left.
        /// </summary>
        public bool checkLoss() 
        {
            return (_jumper[0] == "  X");
        }
        /// <summary>
        /// Displays the parachute.
        /// </summary>
        public void displayJumper()
        {
            for (int i=0;i<_jumper.Count;i++)
            {
                _terminalService.WriteText(_jumper[i]);
            }
        }

        
      
    }
}