using LHTest.Equations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LHTest.Operations.OpRules;

namespace LHTest
{
    class Program
    {
        public delegate void  mydelegate();

        static void Main(string[] args)
        { 

            while (true)
            {

                EquationMaker em = new EquationMaker();
                Equation eq = em.CreateEquation();

                Console.WriteLine(eq.FullEquation + " " + eq.Answer);
                Console.ReadLine();
            }
        }
    }
}
