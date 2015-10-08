using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Operations.OpRules
{
    class MultiplyRules : Rules
    {
        public MultiplyRules()
        {
            this.MinNum = 0;
            this.MaxNum = 15;
        }

        private bool IsMoreThan200(int firstNum, int secondNum)
        {
            bool Isless = (firstNum * secondNum) > 200 ? true : false;

            return Isless;
        }

    }
}
