using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressRestApi.Valications
{
    public class PerPageValidation
    {
        public static void Validate(int value)
        {
            if (value < 1 || value > 100) throw new ArgumentException("PerPage must be between 1 and 100");
        }
    }
}
