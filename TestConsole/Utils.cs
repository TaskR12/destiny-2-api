using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public static class Utils
    {
        public static IEnumerable<Type> FindSubClassesOf<T>()
        {
            var baseType = typeof(T);
            var assembly = baseType.Assembly;

            return assembly.GetTypes().Where(t => t.IsSubclassOf(baseType));
        }

        public static Type FindSubClassOf<T>(string lookupChildClassName)
        {
            return FindSubClassesOf<T>().FirstOrDefault(elt => elt.Name == lookupChildClassName);
        }
    }
}
