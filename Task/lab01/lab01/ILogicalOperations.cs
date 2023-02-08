using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal interface ILogicalOperations
    {
        string OR();
        string AND();
        string NOT();
        string XOR();
    }
}
