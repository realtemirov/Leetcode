namespace Leetcode.L1647
{
    public class Solution {
        public int MinDeletions(string s)
        {
                
            Dictionary<char,int> d = new Dictionary<char, int>();

            if(s is null || s =="")
            {
                return -1;
            }

            foreach (var c in s)
            {
                if (d.ContainsKey(c))
                    d[c]++;
                else
                    d.Add(c, 1);
            }

            foreach (var item in d)
            {
                System.Console.WriteLine(item.Key + " " + item.Value);
            }

            return 0;
        }
    }
}
