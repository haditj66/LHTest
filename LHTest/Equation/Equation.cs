using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Equation
{
    /// <summary>
    /// Holds info about the equation
    /// </summary>
    public class Equation
    {
        public string FirstNum { get; set; }
        public string SecondNum { get; set; }
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

                return eq.ToString();
            } 
        }

        public string Answer
        {
            get
            {
                return "";
            }
        }

    }
}
