using System.Linq;
using System.Text;

namespace CodeGenerator
{
    public static class UnCurryGenerator
    {
        public static string GetUnCurryFor(int args)
        {
            args++;
            
            var n = Enumerable.Range(1, args).ToArray();
            var ts = n.Select(x => "T" + x);
            var TsComma = string.Join(", ", ts);
            var letters = Enumerable.Range(1, args - 1).Select(x => "arg" + x);
            var templete = new StringBuilder();
            
            templete.Append("public static ");
            templete.Append("Func<" + TsComma + "> ");
            templete.Append("UnCurry<" + TsComma + ">");
            templete.Append("(this " + ts.AggregateRight((t1, t2) => "Func<" + t1 + ", " + t2 + ">") + " function)");
            templete.Append("\n    => ");
            templete.Append("(" + string.Join(", ", letters) + ") => function(" + string.Join(")(", letters) + ");");

            return templete.Replace("T" + args, "TResult").Replace("return () =>", "return ").ToString();
        }
    }
}
