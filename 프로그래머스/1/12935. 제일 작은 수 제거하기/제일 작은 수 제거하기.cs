using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        if (arr.Length == 1) { arr[0] = -1; return arr;}
        int minimum = arr[0];
        for (int i = 0; i < arr.Length; ++i)
        {
            if (minimum > arr[i]) minimum = arr[i];
        }
        List<int> list = new List<int>();
        list.AddRange(arr);
        list.Remove(minimum);
        answer = list.ToArray();
        return answer;
    }
}