using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Operations
{
    public interface IOperator
    {
        string Name { get; } 
        Func<int, int, float> TheOperation { get;}  
    }
}
