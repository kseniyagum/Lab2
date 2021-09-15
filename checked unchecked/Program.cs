using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checked_unchecked
{
    class Program
    {
        static void funChecked() {
            checked { int intMaxVal = System.Int32.MaxValue+1; }
            
        }
        static void funUnchecked()
        {
            unchecked { int intMaxVal = System.Int32.MaxValue+1; }
        }
        static void Main(string[] args)
        {
            funChecked();
            funUnchecked();
            int k = 0;
        }
    }
}
