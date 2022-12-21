using System.Diagnostics;

namespace Leetcode;

public class RemoveElementFromArray
{
    public int RemoveElement(int[] nums, int val)
    {
        var write = 0;
        var countRemoved = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[write] = nums[i];
                countRemoved++;
                write++;
            }
        }

        return countRemoved;
    }
}