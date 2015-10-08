using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Operations.OpRules
{
    class MinusRules : Rules
    {

        public MinusRules()
        {
            this.MinNum = 0;
            this.MaxNum = 100;
        }

        private bool IsLessThanZero(int firstNum, int secondNum)
        {
            bool Isless = (firstNum - secondNum) < 0 ? true : false;

            return Isless;
        }

    }
}
