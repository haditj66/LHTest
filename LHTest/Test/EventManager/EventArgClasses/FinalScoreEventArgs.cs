using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Test.EventManager.EventArgClasses
{
    public class FinalScoreEventArgs : EventArgs
    {
        public float FinalScore { get; set; }
        public bool Passed 
        {
            get
            {
                if(FinalScore >= 70)
                {
                    return true;
                }
                return false;
            }
        }

    }
}
