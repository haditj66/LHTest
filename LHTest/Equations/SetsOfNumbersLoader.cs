using LHTest.Operations;
using LHTest.Operations.OpRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Equations
{
    public class SetsOfNumbersLoader
    {
        Rules TheOPRules;
        int MinNum;
        int MaxNum;

        public SetsOfNumbersLoader(Rules theRules)
        {
            this.TheOPRules = theRules;
            this.MinNum = TheOPRules.MinNum;
            this.MaxNum = TheOPRules.MaxNum;
        }

        public dynamic[] GetSetOfNumbers()
        {
            Dictionary<int, int> setOfValidNums = new Dictionary<int,int>();
            List<int> d = new List<int>();

            var setOfNum1 = Enumerable.Range(MinNum, MaxNum); 
            var setOfNum2 = Enumerable.Range(MinNum, MaxNum);

            //go through each combination of numbers and check if that combination passes the rules
            var query =
                (from num1 in setOfNum1
                 from num2 in setOfNum2
                 where TheOPRules.IsCheckRulesPassed(num1, num2)
                 select new { X = num1, Y = num2 }); 
                 //ToDictionary.(
                 //(n) => n.n1,
                 //(n) => n.n2
            //);

            #region IN CASE I EVER WANT TO REMOVE REVERSED COMBINATION DUBLICATES... HERES HOW TO DO IT. (A-B IS A REVERSED DUP OF B-A)
            //var reversedQuery = query.Select((n) => new { X = n.Y, Y = n.X }).Intersect(query);

            //var queryWithoutDupCombos = query.Except(reversedQuery);
            #endregion 

            return query.ToArray();
            
        } 
    }
}
