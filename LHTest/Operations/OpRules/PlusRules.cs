using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Operations.OpRules
{
    public class PlusRules : Rules
    {  
        public PlusRules()
        {
            this.MinNum = 0;
            this.MaxNum = 100;
        }

        private bool IsSumMoreThan100(int firstNum, int secondNum)
        {
            bool Ismore = (firstNum + secondNum) > 100 ? true : false;

            return Ismore;
        }

        private bool IsLessThanZero(int firstNum, int secondNum)
        {
            bool Isless = (firstNum + secondNum) < 0 ? true : false;

            return Isless;
        }
    }
}
