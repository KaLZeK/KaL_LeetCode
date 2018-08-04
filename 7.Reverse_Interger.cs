public class Solution
{
    public int Reverse(int x)
    {
        bool check = x<0;
        long result=0;
        long tmp = x;
        long div;
        if (check)
        {
            tmp*=-1;
        }
        while(true)
        {
            div = tmp%10;
            result += div;
            tmp /= 10;
            if (tmp==0)
                break;
            else
                result*=10;
        }
        if (check)
        {
            result*=-1;
        }
        if (result< -2147483648 || result >=2147483648)
            result = 0;
        return Convert.ToInt32(result);
    }
}