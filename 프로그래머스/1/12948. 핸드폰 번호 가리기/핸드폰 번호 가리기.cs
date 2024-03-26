public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        if (phone_number.Length >= 4 && phone_number.Length <= 20)
        {
            for (int i = 0; i < phone_number.Length; ++i)
            {
                if (i < phone_number.Length -4 )
                {
                    answer += "*";
                }
                else
                {
                    answer += phone_number[i];    
                }
                
            }
        }
        return answer;
    }
}