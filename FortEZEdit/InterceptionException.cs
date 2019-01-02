using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortEZEdit
{
    class InterceptionException : Exception
    {
        public InterceptionException(string message) : base(message)
        {
        }
    }
}
