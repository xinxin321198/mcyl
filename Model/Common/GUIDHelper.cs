using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public class GUIDHelper
    {
        public static string getGuid()
        {
            return Guid.NewGuid().ToString("N").ToUpper();
        }
    }
}
