using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Registry_Recorder_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("What is the first registry backup called? ");
            string file1 = Console.ReadLine();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("What is the current registry backup called?");
            string file2 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Threading.Thread.Sleep(2000);
            String directory = @"C:\.......\";
            String[] linesA = File.ReadAllLines(Path.Combine(directory, $"{file1}"));
            String[] linesB = File.ReadAllLines(Path.Combine(directory, $"{file2}"));

            IEnumerable<String> onlyB = linesB.Except(linesA);

            File.WriteAllLines(Path.Combine(directory, "Result.txt"), onlyB);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Result has been outputted to 'Result.txt' file in the C: Drive!");
            Console.Read();
        }
    }
}
