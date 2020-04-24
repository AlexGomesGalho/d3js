using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadAllTexts
{
    class ReadAllLines
    {
        public void ReadAllLineFile(string path)
        {
            try
            {
                var line = File.ReadAllLines(path);
                Console.WriteLine(line.Length);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
