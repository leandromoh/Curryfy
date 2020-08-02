using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodeGenerator
{
    public static class PartialGenerator
    {
        public static string GetPartialDefinitionsFor(int args)
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
            templete.Append(string.Join(", ", parameters.Select(x => $"T{x} arg{x}")));
            templete.Append(")");
         // templete.Append("\n{");
         // templete.Append("\n\treturn ");
            templete.Append("\n    => ");
            templete.Append("(" + string.Join(", ", numbers.SkipLast(1).Except(parameters).Select(x => $"arg{x}")) + ")");
            templete.Append(" => ");
            templete.Append("function(" + string.Join(", ", numbers.SkipLast(1).Select(x => $"arg{x}")) + ");");
         // templete.Append("\n}");

            return templete.Replace("T" + args, "TResult").Replace("() =>", "=>").ToString();
        }

        // https://stackoverflow.com/a/19891145/4854924
        public static T[][] FastPowerSet<T>(T[] seq)
        {
            var powerSet = new T[1 << seq.Length][];
            powerSet[0] = new T[0]; // starting only with empty set
            for (int i = 0; i < seq.Length; i++)
            {
                var cur = seq[i];
                int count = 1 << i; // doubling list each time
                for (int j = 0; j < count; j++)
                {
                    var source = powerSet[j];
                    var destination = powerSet[count + j] = new T[source.Length + 1];
                    for (int q = 0; q < source.Length; q++)
                        destination[q] = source[q];
                    destination[source.Length] = cur;
                }
            }
            return powerSet;
        }
    }
}
