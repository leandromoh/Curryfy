using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static CodeGenerator.PartialGenerator;

namespace CodeGenerator
{
    public static class PartialDiscardGenerator
    {
        public static string GetPartialDiscardDefinitionsFor(int args)
        {
            Debug.Assert(args > 0);

            var n = Enumerable.Range(1, args).ToArray();

            int[][] powerSet = FastPowerSet(n);

            var methods = powerSet
                            .Where(x => x.Length != 0 && x.Length != args)
                            .Select((x, i) => $"// {i + 1}\n" + Partial(args, x));

            Debug.Assert(Math.Pow(2, args) - 2 == methods.Count());

            return string.Join("\n\n", methods);
        }


        private static string Partial(int args, int[] parameters)
        {
            args++;
            var numbers = Enumerable.Range(1, args).ToArray();
            var templete = new StringBuilder();

            templete.Append("public static ");
            templete.Append("Func<" + string.Join(", ", numbers.Except(parameters).Select(x => "T" + x)) + "> ");
            templete.Append("ApplyPartial<" + string.Join(", ", numbers.Select(x => "T" + x)) + ">");
            templete.Append("(this Func<" + string.Join(", ", numbers.Select(x => "T" + x)) + "> function, ");
            templete.Append(string.Join(", ", numbers.SkipLast(1).Select(x => parameters.Contains(x) ? $"T{x} arg{x}" : $"__ arg{x}")));
            templete.Append(")");
         // templete.Append("\n{");
         // templete.Append("\n\treturn ");
            templete.Append("\n    => ");
            templete.Append("(" + string.Join(", ", numbers.SkipLast(1).Except(parameters).Select(x => $"_arg{x}")) + ")");
            templete.Append(" => ");
            templete.Append("function(" + string.Join(", ", numbers.SkipLast(1).Select(x => parameters.Contains(x) ? $"arg{x}" : $"_arg{x}")) + ");");
         // templete.Append("\n}");

            return templete.Replace("T" + args, "TResult").Replace("() =>", "=>").ToString();
        }
    }
}
