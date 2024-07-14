namespace LCP;

public class ContainsDuplicates
{
    public bool ContainsDuplicate(int[] nums)
    {

        //for (int i = 0; i < nums.Length; i++)
        //{
        //    for (int j = 1; j < nums.Length; j++)
        //    {
        //        if (i != j)
        //        {
        //            if (nums[i] == nums[j])
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //}

        //return false;


        //someone elses solution to help the time out error when a huge data set is being given
        Dictionary<int, bool> d = new Dictionary<int, bool>();

        foreach (int x in nums)
        {
            if (d.ContainsKey(x))
                return true;
            else
                d[x] = false;
        }
        return false;
    }
}