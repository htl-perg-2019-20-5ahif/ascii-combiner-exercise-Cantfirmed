using System;
using System.IO;
using AsciiExerciseLibrary;
namespace AsciiArtCombiner {
    class Program {
        static void Main(string[] args) {
            var reader = new FileReader();
            if(args.Length < 2) {
                Console.WriteLine("Only one or less files specified");
                Console.ReadLine();
                Environment.Exit(5);
            }
            foreach (var path in args) {
                try {
                    reader.readFile(File.ReadAllLines(path));
                } catch (Exception ex) {
                    Console.WriteLine("File does not exist!");
                    Console.ReadLine();
                    Environment.Exit(5);
                }
                
            }
            //Console.WriteLine(Arrays.deepToString(reader.getResult()));
            var result = reader.getResult();
            for (int i = 0; i <= result.GetLength(0)-1; i++) {
                for (int j = 0; j <= result.GetLength(1)-1; j++) {
                    Console.Write(result[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
