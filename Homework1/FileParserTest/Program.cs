using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class FileParserTest
    {
        static void Main(string[] args)
        {
            FileParser fp = new FileParser();
            myFile[] re = fp.getFile("E:/C#workplace/ConsoleApplication1/ConsoleApplication1");
            foreach (myFile s in re)
                Console.WriteLine(s.getName());
            Console.ReadLine();
        }
    }
}
