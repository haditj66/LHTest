using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Operations.OpRules
{
    class ExponentRules : Rules
    {
        public ExponentRules()
        {
            this.MinNum = 0;
            this.MaxNum = 10;
        }

        private bool IsMoreThan100(int firstNum, int secondNum)
        {
            bool Isless = Math.Pow(firstNum, secondNum) > 100 ? true : false;

            return Isless;
        }

    }
}
