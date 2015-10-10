using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Test.EventManager.EventArgClasses
{
    
    public class StartedTestEventArgs : EventArgs
    { 
        public string Name { get; set; }
        public string Difficulty { get; set; }

        public StartedTestEventArgs(string name, string difficulty)
        {
            this.Name = name;
            this.Difficulty = difficulty;
        }
    }
}
