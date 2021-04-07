using System;

using System.CodeDom.Compiler;
using System.Reflection;

namespace Expresiones
{
    public class Evaluador
    {
        private MethodInfo mi;
        private Object evaluador;

        public Evaluador(string expresion)
        {
            string fuente = @"using System;
            namespace MiCodigo {
             class MiClase {
              public double Evaluar(double x)
               {
                 return " + expresion + @";
               }
             }
            }";

            CodeDomProvider compilador = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters cp = new CompilerParameters();
            cp.ReferencedAssemblies.Add("system.dll");
            cp.CompilerOptions = "/t:library";
            cp.GenerateInMemory = true;
            CompilerResults cr = compilador.CompileAssemblyFromSource(cp, fuente);
            Assembly a = cr.CompiledAssembly;
            evaluador = a.CreateInstance("MiCodigo.MiClase", false, System.Reflection.BindingFlags.CreateInstance, null, new object[0], null, null);
            Type t = evaluador.GetType();
            mi = t.GetMethod("Evaluar");
        }

        public double Evaluar(double x)
        {
            object oRet = mi.Invoke(evaluador, new object[]{x});
            return Convert.ToDouble(oRet);
        }
    }
}
