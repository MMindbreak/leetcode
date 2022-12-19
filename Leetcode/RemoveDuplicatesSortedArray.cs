namespace Leetcode;

public class RemoveDuplicatesSortedArray
{
    private void _shift(int[] nums, int index)
    {
        _shiftMany(nums, index, 1);
    }
    public int RemoveDuplicates(int[] nums)
    {
        /*
        for (var i = 0; i < nums.Length - 1; i++)
        {
            var j = i;
            while (j < nums.Length - 1 && nums[i] == nums[i+1])
            {
                _shift(nums, i);
                j++;
            }
        }
        */
        _removeDuplicatesFast(nums);
        
        var count = 0;
        while (count < nums.Length - 1 && nums[count] != nums[count + 1])
        {
            count++;
        }
        
        return count + 1;
    }

    private void _removeDuplicatesFast(int[] nums)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] >= nums[i + 1])
            {
                var j = i + 1;
                while (j < nums.Length - 1 && nums[i + 1] == nums[j + 1])
                {
                    j++;
                }

                nums[i] = nums[j];
            }
        }
    }

    private void _shiftMany(int[] nums, int atIndex, int amount)
    {
        for (var i = atIndex + 1; i < nums.Length - amount; i++)
        {
            nums[i] = nums[i + amount];
        }
    }
}