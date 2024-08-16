using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP
{
    public class PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if(n == 1 || n % 2 == 0)
            {
                return true;
            }
            else 
            {  
                return false; 
            }
        }
    }
}
