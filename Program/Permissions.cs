using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    [Flags]
    internal enum Permissions
    {
        Read,
        Write,
        Delete,
        Execute
    }
}
