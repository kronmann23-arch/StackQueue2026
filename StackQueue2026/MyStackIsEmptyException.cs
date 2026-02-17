using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue2026
{
    public class MyStackIsEmptyException: Exception
    {
        public MyStackIsEmptyException(string message)
             : base(message)
        {

        }
    }
}
