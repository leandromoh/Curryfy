using System.Linq;
using System.Text;

namespace CodeGenerator
{
    public static class PartialIncrementalGenerator
    {
        public static string CreatePartialIncrementalFunc(int args)
        {
            args++;

            var n = Enumerable.Range(1, args).ToArray();

            var definitions = Enumerable.Range(1, args -2).Select(i =>
            {
  
                var templete = new StringBuilder();
                
                templete.Append("// " + i);
                templete.Append("\n");
                templete.Append("public static ");
                templete.Append("Func<" + string.Join(", ", n.Skip(i).Select(x => "T" + x)) + "> ");
                templete.Append("ApplyPartial<" + string.Join(", ", n.Select(x => "T" + x)) + ">");
                templete.Append("(this Func<"   + string.Join(", ", n.Select(x => "T" + x)) + "> function, ");
                templete.Append(string.Join(", ", n.Take(i).Select(x => $"T{x} arg{x}")));
                templete.Append(")");
                templete.Append("\n    => ");
                templete.Append("(" + string.Join(", ", n.Skip(i).SkipLast(1).Select(x => $"arg{x}")) + ")");
                templete.Append(" => ");
                templete.Append("function(" + string.Join(", ", n.SkipLast(1).Select(x => $"arg{x}")) + ");");

                return templete.Replace("T" + args, "TResult").Replace("return  =>", "return ").ToString();
            });

            return string.Join("\n\n", definitions);
        }
    }
}
