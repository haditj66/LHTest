using LHTest.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Equations
{

    /// <summary>
    /// this class will randomly generate an equation for the next question
    /// </summary>
    public class EquationMaker
    {

        private static Random r = new Random();
        private static List<IOperator> Operators; 

        public EquationMaker()
        {
            // first get all operators available
            Operators = OperatorLoader.LoadOperators();
        }


        public Equation CreateEquation()
        {
            Equation eq = new Equation();
            IOperator theOp = GetRandomOperator();

            eq.Operation = theOp.Name;
             
            //while a rule is broken, generate a different set of numbers to get an appropriate equation
            bool ruleBroken = true; 
            while (ruleBroken)
            {
                eq.FirstNum = GetRandomNumber(1, 50);
                eq.SecondNum = GetRandomNumber(1, 50);
                eq.Answer = theOp.TheOperation(eq.FirstNum, eq.SecondNum);

                //this is where I would check the rule
                ruleBroken = false; 
            }

            return eq;
        }


        private IOperator GetRandomOperator()
        { 
            //get a random operator from the list of operators.
            return Operators[r.Next(0, (Operators.Count - 1))];
        }

        private int GetRandomNumber(int min, int max)
        {
            return r.Next(min, max); 
        }
    }
}
