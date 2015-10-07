using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Operations
{
    class MultiplyOperator :IOperator
    { 

        public string Name
        {
            get { return "X"; }
        }

        public Func<int, int, float> TheOperation
        {
            get {return (x,y) => x * y; }
        }
    }
}
