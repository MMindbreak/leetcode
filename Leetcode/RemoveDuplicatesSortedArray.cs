namespace Leetcode;

public class RemoveDuplicatesSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        var read = 1;
        var write = 1;
        while(read < nums.Length)
        {
            if (nums[read] == nums[read - 1])
            {
                read++;
            }
            else
            {
                nums[write] = nums[read];
                write++;
                read++;
            }
        }

        return write;
    }
}