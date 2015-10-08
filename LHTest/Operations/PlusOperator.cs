using LHTest.Operations.OpRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Operations
{
    public class PlusOperator : IOperator
    {
        public string Name
        {
            get
            {
                return "+";
            } 
        }

        public Func<int, int, float> TheOperation
        {
            get 
            {
                return (x, y) => x + y; 
            }
        }


        public Rules OperationRules
        {
            get
            {
                PlusRules p = new PlusRules();  
                return p;
            }
        }
    }
}
