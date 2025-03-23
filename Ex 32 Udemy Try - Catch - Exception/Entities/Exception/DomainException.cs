using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_32_Udemy_Try___Catch___Exception.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
