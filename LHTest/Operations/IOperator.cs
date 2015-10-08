using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LHTest.Operations.OpRules;

namespace LHTest.Operations
{
    public interface IOperator
    {
        string Name { get; } 
        Func<int, int, float> TheOperation { get;}
        Rules OperationRules { get; }
    }
}
