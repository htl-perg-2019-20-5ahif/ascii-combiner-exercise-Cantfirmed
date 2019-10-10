using System;
using System.IO;

namespace AsciiExerciseLibrary {
    public class FileReader {
        private string[,] result;
        private int rows = 0;
        private int columns = 0;
        public FileReader() {

        }

        public void readFile(string[] lines) {
            if (rows == 0) {
                rows = lines.Length;
                columns = lines[0].Length;
                result = new string[rows,columns];
            }
            if(lines.Length != rows) {
                Console.WriteLine("Size not Equal!"); //Insert Error Message
                Console.ReadLine();
                Environment.Exit(5);
            }
            for (int i=0; i < rows; i++) {
                for(int j=0; j < columns; j++) {
                    var curSpot = lines[i].ToCharArray()[j].ToString();
                    if (lines[i].Length != columns) {
                        Console.WriteLine("Size not Equal!");
                        Console.ReadLine();
                        Environment.Exit(5);
                    }
                    if(curSpot == " " && result[i,j] == null) {
                        result[i, j] = curSpot;
                    }
                    if (curSpot != " " && result[i, j] == " " || result[i, j] == null) {
                        result[i, j] = curSpot;
                    }

                }
                    
            }
            
        }
        public string[,] getResult() {
            return result;
        }
    }
}
