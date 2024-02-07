public class Solution {
    public long solution(long n) {
        long answer = 0;
        for (long i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        if (n / i == i)
        {
            answer = i;
            break;
        }
    }
}
if (answer > 0)
{
    answer++;
    answer *= answer;
}
else
{
    answer = -1;
}
        
        
        return answer;
    }
}