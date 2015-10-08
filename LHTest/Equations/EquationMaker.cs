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

            //get the set of numbers that followed the rules of the operator
            SetsOfNumbersLoader ss = new SetsOfNumbersLoader(theOp.OperationRules);
            var setOfNumbers = ss.GetSetOfNumbers();

            //pick random set and set that into the equation
            var randCombo = setOfNumbers[r.Next(0, setOfNumbers.Count())]; 
            eq.FirstNum = randCombo.X;
            eq.SecondNum = randCombo.Y;
            eq.Answer = theOp.TheOperation(eq.FirstNum, eq.SecondNum); 

            return eq;
        }


        private IOperator GetRandomOperator()
        { 
            //get a random operator from the list of operators.
            return Operators[r.Next(0, (Operators.Count))];
        }

        private int GetRandomNumber(int min, int max)
        {
            return r.Next(min, max); 
        }
    }
}
