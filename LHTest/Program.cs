using LHTest.Equations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest
{
    class Program
    {
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
