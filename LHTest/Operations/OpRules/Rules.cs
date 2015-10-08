using System;
using LHTest.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Operations.OpRules
{
   
    public abstract class Rules
    {
        public int MinNum = 0;
        public int MaxNum = 10;  

        protected delegate bool PredicateHandler(int firstNum, int secondNum); 

        protected List<PredicateHandler> GetRules()
        {
            List<PredicateHandler> Predicates = new List<PredicateHandler>();

            //get methods of this class with that signature
            Type t = this.GetType();
            MethodInfo[] oo = t.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance );
            IEnumerable<MethodInfo> m = oo.GetMethodsBySig(typeof(bool), typeof(int), typeof(int)); 
            
            //set all predicate methods into the predicates list as delegates
            foreach (MethodInfo method in m)
            {
                Predicates.Add((PredicateHandler)method.CreateDelegate(typeof(PredicateHandler), this)); 
            }

            return Predicates;
        }

        public bool IsCheckRulesPassed(int firstNum, int secondNum, params int[] moreNums)
        {
            List<PredicateHandler> rulesToCheck = GetRules();

            //check each rule
            foreach (var rule in rulesToCheck)
            {
                if(rule(firstNum, secondNum))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
