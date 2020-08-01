using static CodeGenerator.PartialGenerator;
using static CodeGenerator.PartialIncrementalGenerator;
using static CodeGenerator.Common;
using static CodeGenerator.UnCurryGenerator;
using static CodeGenerator.CurryGenerator;
using System.Linq;

namespace CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCurryFuncFiles();
            CreateUnCurryFuncFiles();

            CreatePartialActionFiles();
            CreatePartialFuncFiles();

            CreatePartialIncrementalFuncFiles();
            CreatePartialIncrementalActionFiles();
        }

        public static void CreatePartialIncrementalActionFiles()
        {
            for (int i = 9; i < 17; i++)
            {
                var methodsText = CreatePartialIncrementalFunc(i)
                    .Replace("Func", "Action")
                    .Replace(", TResult", string.Empty)
                    .Replace("Action<TResult>", "void");

                var classText = GetClass(methodsText, identationLevel: 2);

                CreateFileInsideProject(classText, $@"PartialIncrementalAction\ActionOf{i}.cs");
            }
        }

        public static void CreatePartialIncrementalFuncFiles()
        {
            for (int i = 9; i < 17; i++)
            {
                var methodsText = CreatePartialIncrementalFunc(i);

                var classText = GetClass(methodsText, identationLevel: 2);

                CreateFileInsideProject(classText, $@"PartialIncrementalFunc\FuncOf{i}.cs");
            }
        }

        public static void CreateCurryFuncFiles()
        {
            var methodsText = Enumerable
                                    .Range(2, 15)
                                    .Select(i => $"// {i}\n"+ GetCurryFor(i));

            var classContent = string.Join("\n\n", methodsText);

            var classText = GetClass(classContent, identationLevel: 2);
            CreateFileInsideProject(classText, $@"Curry\Curry.cs");

        }

        public static void CreateUnCurryFuncFiles()
        {
            var methodsText = Enumerable
                                    .Range(2, 15)
                                    .Select(i => $"// {i}\n" + GetUnCurryFor(i));

            var classContent = string.Join("\n\n", methodsText);

            var classText = GetClass(classContent, identationLevel: 2);
            CreateFileInsideProject(classText, $@"Curry\UnCurry.cs");
        }

        public static void CreatePartialActionFiles()
        {
            for (int i = 2; i < 9; i++)
            {
                var methodsText = GetPartialDefinitionsFor(i)
                    .Replace("Func", "Action")
                    .Replace(", TResult", string.Empty)
                    .Replace("Action<TResult>", "void");

                var classText = GetClass(methodsText, identationLevel: 2);

                CreateFileInsideProject(classText, $@"PartialAction\ActionOf{i}.cs");
            }
        }

        public static void CreatePartialFuncFiles()
        {
            for (int i = 2; i < 9; i++)
            {
                var methodsText = GetPartialDefinitionsFor(i);
                var classText = GetClass(methodsText, identationLevel: 2);

                CreateFileInsideProject(classText, $@"PartialFunc\FuncOf{i}.cs");
            }
        }
    }
}
