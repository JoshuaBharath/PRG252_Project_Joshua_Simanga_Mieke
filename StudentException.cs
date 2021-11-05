using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG252_Project_Joshua_Simanga_Mieke
{
    class StudentException : Exception
    {
        public StudentException()
        {
        }

        public StudentException(string message) : base(message)
        {
        }

        public StudentException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
