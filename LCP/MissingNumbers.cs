using System.Runtime.InteropServices.ComTypes;
using Microsoft.Win32.SafeHandles;

namespace LCP;

public class MissingNumbers
{
    public int MissingNumber(int[] nums)
    {
        IEnumerable<int> missingNumbers = null;

        if (nums != null)
        {
            missingNumbers = Enumerable.Range(0, nums.Length).Except(nums);

            if (missingNumbers != null)
            {
                foreach (var number in missingNumbers)
                {
                    return number;
                }
            }

            if (missingNumbers.Count() == 0)
            { 
                return nums.Length;
            }
        }

        return 0;
    }
}