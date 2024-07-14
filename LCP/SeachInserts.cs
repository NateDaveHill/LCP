namespace LCP;

public class SeachInserts
{
    public int SearchInsert(int[] nums, int target)
    {
        //int indexOfTarget = Array.IndexOf(nums, target);

        int indexOfTarget = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                indexOfTarget = i;
            }
        }

        if (indexOfTarget == -1)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (target > nums.Max())
                {
                    return nums.Length;
                }
                else if (target > nums[i] && target < nums[i+1])
                {
                    return i + 1;
                }
                else if (target < nums.Min())
                {
                    return 0;
                }
            }
        }

        return indexOfTarget;
    }
}