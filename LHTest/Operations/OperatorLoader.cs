using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LHTest.Operations
{
    public static class OperatorLoader
    {
        //List<IOperator>
        public static List<IOperator> LoadOperators()
        {
            //reflects into assembly and gets all types inheriting from ioperator and is a class
            Assembly a = Assembly.GetExecutingAssembly();
            IEnumerable<Type> types = a.GetTypes().Where(t => t.IsClass)
                                                  .Where(t => typeof(IOperator).IsAssignableFrom(t));

            //create an instance of each Ioperator type
            List<IOperator> operators = new List<IOperator>(); 
            foreach (Type t in types)
            { 
                operators.Add(Activator.CreateInstance(t) as IOperator);
            }

            return operators;
        }
    }
}
