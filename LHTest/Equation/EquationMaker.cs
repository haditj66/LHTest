using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest
{

    /// <summary>
    /// this class will randomly generate an equation for the next question
    /// </summary>
    public class EquationMaker
    {

        private static Random r = new Random(); 

        public EquationMaker()
        {
            
        }


        public string CreateEquation()
        {
            bool ruleBroken = true;
            StringBuilder theEquation = new StringBuilder();

            Action<int, int> theOperationAction;
            string theOp = GetRandomOperator(out theOperationAction);

            //while a rule is broken, generate a different set of numbers to get 
            while (ruleBroken)
            {
                
            }

            return "";
        }


        private string GetRandomOperator(out Action<int, int> theOperationAction)
        {
            int randOper = r.Next(1,4);
            string theOp = "";
            theOperationAction = (x, y) => Console.WriteLine("");

            switch (randOper)
            {
                case 1: 
                    theOp = "+";
                    theOperationAction = (x, y) =>
                    {
                        float p = x + y;
                    };
                    break;
                case 2:
                    theOp = "-";
                    theOperationAction = (x, y) =>
                    {
                        float p = x - y;
                    };
                    break;
                case 3:
                    theOp = "X";
                    theOperationAction = (x, y) =>
                    {
                        float p = x * y;
                    };
                    break;
                case 4:
                    theOp = "/";
                    theOperationAction = (x, y) =>
                    {
                        float p = x * y;
                    };
                    break; 
                    
            }

            return theOp;
        }

        private string GetRandomNumber(int min, int max)
        {
            int randnum = r.Next(min,max);

            return randnum.ToString();
        }
    }
}
