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
        private const string sufix = "Extensions";

        static void Main(string[] args)
        {
            CreateCurryFuncFiles("Curry" + sufix);
            CreateUnCurryFuncFiles("Curry" + sufix);

            CreatePartialSubsetActionFiles("PartialSubsetAction" + sufix);
            CreatePartialSubsetFuncFiles("PartialSubsetFunc" + sufix);

            CreatePartialIncrementalFuncFiles("PartialIncrementalFunc" + sufix);
            CreatePartialIncrementalActionFiles("PartialIncrementalAction" + sufix);
        }

        public static void CreatePartialIncrementalActionFiles(string className)
        {
            for (int i = 2; i < 17; i++)
            {
                var methodsText = CreatePartialIncrementalFunc(i)
                    .Replace("Func", "Action")
                    .Replace(", TResult", string.Empty)
                    .Replace("Action<TResult>", "void");

                var classText = GetClass(className, methodsText, identationLevel: 2);

                CreateFileInsideProject(classText, $@"{className}\ActionOf{i}.cs");
            }
        }

        public static void CreatePartialIncrementalFuncFiles(string className)
        {
            for (int i = 2; i < 17; i++)
            {
                var methodsText = CreatePartialIncrementalFunc(i);

                var classText = GetClass(className, methodsText, identationLevel: 2);

                CreateFileInsideProject(classText, $@"{className}\FuncOf{i}.cs");
            }
        }

        public static void CreateCurryFuncFiles(string className)
        {
            var methodsText = Enumerable
                                    .Range(2, 15)
                                    .Select(i => $"// {i}\r\n"+ GetCurryFor(i));

            var classContent = string.Join("\r\n\r\n", methodsText);

            var classText = GetClass(className, classContent, identationLevel: 2);
            CreateFileInsideProject(classText, $@"{className}\Curry.cs");

        }

        public static void CreateUnCurryFuncFiles(string className)
        {
            var methodsText = Enumerable
                                    .Range(2, 15)
                                    .Select(i => $"// {i}\r\n" + GetUnCurryFor(i));

            var classContent = string.Join("\r\n\r\n", methodsText);

            var classText = GetClass(className, classContent, identationLevel: 2);
            CreateFileInsideProject(classText, $@"{className}\UnCurry.cs");
        }

        public static void CreatePartialSubsetActionFiles(string className)
        {
            for (int i = 2; i < 9; i++)
            {
                var methodsText = GetPartialDefinitionsFor(i)
                    .Replace("Func", "Action")
                    .Replace(", TResult", string.Empty)
                    .Replace("Action<TResult>", "void");

                var classText = GetClass(className, methodsText, identationLevel: 2);

                CreateFileInsideProject(classText, $@"{className}\ActionOf{i}.cs");
            }
        }

        public static void CreatePartialSubsetFuncFiles(string className)
        {
            for (int i = 2; i < 9; i++)
            {
                var methodsText = GetPartialDefinitionsFor(i);
                var classText = GetClass(className, methodsText, identationLevel: 2);

                CreateFileInsideProject(classText, $@"{className}\FuncOf{i}.cs");
            }
        }
    }
}
