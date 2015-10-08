using LHTest.Operations.OpRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Equations
{
    /// <summary>
    /// Holds info about the equation
    /// </summary>
    public class Equation
    {
        public int FirstNum { get; set; }
        public int SecondNum { get; set; }
        public float Answer { get; set; }
        public string Operation { get; set; }

        public string FullEquation
        {
            get
            {
                StringBuilder eq = new StringBuilder();
                eq.Append(FirstNum);
                eq.Append(" ");
                eq.Append(Operation);
                eq.Append(" ");
                eq.Append(SecondNum);
                eq.Append("=");
                eq.Append(" ");

                return eq.ToString();
            } 
        } 

    }
}
