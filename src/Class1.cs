using System.Collections;
using System.Numerics;

namespace TheTwoSneakyNumbers
{
    public class Class1
    {
        public int[] GetSneakyNumbers(int[] nums)
        {
            Hashtable numTable = new Hashtable();
            int[] ans = new int[2];
            int j = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (numTable.ContainsKey(nums[i]))
                {
                    ans[j] = nums[i];
                    j++;
                }
                else
                {
                    numTable.Add(nums[i], i);
                }
                
                if(j == 2)
                {
                    return ans;
                }
            }
            return ans;
        }
    }
}
