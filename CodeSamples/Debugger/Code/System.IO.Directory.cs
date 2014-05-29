using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Debugger.Code
{
    class IODirectory : ICode
    {ce's'


        public void Start()
        {

            Test_Exists();


        }


        private void Test_Exists()
        {

            Console.WriteLine("NULL".PadRight(10) + Directory.Exists(null));
            Console.WriteLine("空白".PadRight(8) + Directory.Exists(""));
            Console.WriteLine("c".PadRight(10) + Directory.Exists("c"));
            Console.WriteLine("c:".PadRight(10) + Directory.Exists("c:"));
            Console.WriteLine(@"c:\".PadRight(10) + Directory.Exists(@"c:\"));
            Console.WriteLine(@"c:\w".PadRight(10) + Directory.Exists(@"c:\w"));

        }




    }
}
