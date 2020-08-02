using System.Linq;
using System.Text;

namespace CodeGenerator
{
    public static class CurryGenerator
    {
        public static string GetCurryFor(int args)
        {
            args++;
            var n = Enumerable.Range(1, args).ToArray();
            var ts = n.Select(x => "T" + x);
            string TsComma = string.Join(", ", ts);
            var letters = Enumerable.Range(1, args - 1).Select(x => "arg" + x);

            var templete = new StringBuilder();
            templete.Append("public static ");
            templete.Append(ts.AggregateRight((t1, t2) => "Func<" + t1 + ", " + t2 + ">") + " ");
            templete.Append("Curry<" + TsComma + ">");
            templete.Append("(this Func<" + TsComma + "> function)");
            templete.Append("\n    => ");
            templete.Append(string.Join(" => ", letters) + " => function(" + string.Join(", ", letters) + ");");

            return templete.Replace("T" + args, "TResult").Replace("return  =>", "return ").ToString();
        }
    }
}
