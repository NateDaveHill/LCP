namespace LCP;

public class ContainsDuplicates
{
    public bool ContainsDuplicate(int[] nums)
    {
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                if (i != j)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}