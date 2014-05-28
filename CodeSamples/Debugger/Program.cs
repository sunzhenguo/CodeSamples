using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger
{
    class Program
    {
        static void Main(string[] args)
        {


            ICode c = new Code.OfType();

            c.Start();
        }
    }
}
