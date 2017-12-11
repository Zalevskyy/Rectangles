using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Rectangles
{
    [Serializable]
    class SizeException: ApplicationException
    {
        public SizeException(string message) : base(message) { }
    }
}
