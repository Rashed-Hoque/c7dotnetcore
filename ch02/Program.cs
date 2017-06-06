using System.Linq;
using System.Reflection;

namespace ch02
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(r.FullName));

                var methodsCount =0;
                foreach(var t in a.DefinedTypes)
                {
                    methodsCount += t.GetMethods().Count();
                }

                System.Console.WriteLine($"{a.DefinedTypes.Count()} types with {methodsCount} methods in {r.Name} assembly.");
            }
        }
    }
}
