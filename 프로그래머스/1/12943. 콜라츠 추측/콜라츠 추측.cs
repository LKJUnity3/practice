public class Solution {
    public int solution(long num) {
        int answer = 0;
        if (num < 8000000)
        {
            while(num != 1)
            {
                switch (num % 2)
                {
                    case 0:
                        num /= 2;
                        break;
                    case 1:
                        num = num * 3 + 1;
                        break;
                }
                answer++;
                if (answer > 500)
                {
                    answer = -1;
                    break;
                }
            }
            
        }
        return answer;
    }
}