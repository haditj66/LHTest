using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Operations.OpRules
{
    class DivideRules : Rules
    {
        public DivideRules()
        {
            this.MinNum = 0;
            this.MaxNum = 100;
        }

        private bool IsDividingByZero(int firstNum, int secondNum)
        {
            bool Isless = secondNum == 0 ? true : false;

            return Isless;
        }

        private bool IsDividingGivesFraction(int num1, int num2)
        {


            bool Isless = (num1%num2 !=0) ? true : false;

            return Isless;
        }


    }
}
