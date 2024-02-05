using System;
using System.Linq;

public class Solution {
    public int[] solution(long n) {
        string index = n.ToString();
        int[] answer = new int[index.Length];
        for (int i = 0; i< index.Length; i++)
        {
            answer[i] = int.Parse(index[i].ToString());
        }
        Array.Reverse(answer);
        return answer;
    }
}