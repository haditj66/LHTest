using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Extensions
{
    public static class LinqExtensions
    { 
        public static IEnumerable<MethodInfo> GetMethodsBySig(this Type type, Type returnType, bool includePrivate , params Type[] parameterTypes)
        {
            BindingFlags access = includePrivate ? BindingFlags.NonPublic : BindingFlags.Public;

            return type.GetMethods(access).Where((m) =>
            {
                if (m.ReturnType != returnType) return false;
                var parameters = m.GetParameters();
                if ((parameterTypes == null || parameterTypes.Length == 0))
                    return parameters.Length == 0;
                if (parameters.Length != parameterTypes.Length)
                    return false;
                for (int i = 0; i < parameterTypes.Length; i++)
                {
                    if (parameters[i].ParameterType != parameterTypes[i])
                        return false;
                }
                return true;
            });
        }

        public static IEnumerable<MethodInfo> GetMethodsBySig(this MethodInfo[] methods, Type returnType,  params Type[] parameterTypes)
        { 
            return methods.Where((m) =>
            {
                if (m.ReturnType != returnType) return false;
                var parameters = m.GetParameters();
                if ((parameterTypes == null || parameterTypes.Length == 0))
                    return parameters.Length == 0;
                if (parameters.Length != parameterTypes.Length)
                    return false;
                for (int i = 0; i < parameterTypes.Length; i++)
                {
                    if (parameters[i].ParameterType != parameterTypes[i])
                        return false;
                }
                return true;
            });
        }
    }
}
