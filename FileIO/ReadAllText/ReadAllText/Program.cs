using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ReadAllTexts;

namespace ReadAllText
{
    class Program
    {
        public static void Main(string[] args)
        {
            var path = @"C:\Users\Bizruntime-50\source\repos\Aditya-N\File IO\ReadAllText\Sample.txt";
            var smallFilepath = @"C:\Users\Bizruntime-50\source\repos\Aditya-N\File IO\ReadAllText\ReadAllLineEx.txt";
            ReadTextFile(path);

            ReadAllLines rl = new ReadAllLines();
            rl.ReadAllLineFile(smallFilepath);

            var bytes = File.ReadAllBytes(path);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(bytes[i]);
            }
            Console.ReadLine();
        }
        public static void ReadTextFile(string path)
        {
            var text = File.ReadAllText(path);

            Console.WriteLine(text);
        }
    }
}
