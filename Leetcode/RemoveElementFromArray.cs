namespace Leetcode;

public class RemoveElementFromArray
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
            return 0;

        if (nums.Length == 1 && nums[0] == val)
            return 0;

        var count = 0;
        var write = nums.Length - 1;
        var read = 0;
        
        while(read < nums.Length - 1)
        {
            if (read == write) 
                break;
            
            if (nums[read] == val)
            {
                while (nums[write] == val)
                {
                    if (read == write)
                        return 0;
                    write--;
                }

                nums[read] = nums[write];
                nums[write] = val;
                write--;
            }
            else
            {
                count++;
            }

            read++;
        }

        return count;
    }
}