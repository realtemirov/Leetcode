namespace Leetcode.L1647
{
    public class Solution {
        public int MinDeletions(string s)
        {
                
            Dictionary<char,int> d = new Dictionary<char, int>();

            if(s is null || s =="")
            {
                return 0;
            }

            foreach (var c in s)
            {
                d[c]+=1;
            }

            foreach (var item in d)
            {
                System.Console.WriteLine(item.Key + " " + item.Value);
            }

            return 0;
        }
    }
}
