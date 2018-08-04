public class Solution 
{
    public bool StoneGame(int[] piles)
    {
        bool status = true;
        List<int> pile = piles.ToList();
        return status;
        int SumAlex = 0;
        int SumLee = 0;
        StonePlay(ref pile, ref SumAlex, ref SumLee);
        if (SumAlex > SumLee)
            return true;
        else
            return false;
    }

    public void StonePlay(ref List<int> pile, ref int SumAlex, ref int SumLee)
    {
        int count = pile.Count;
        if (count == 2)
        {
            SumAlex += pile.Max();
            SumLee += pile.Min();
            return;
        }
        else
        {
            bool check = Compare(pile);
            int tmp;
            if (check)
            {
                tmp = pile[0];
                pile.RemoveAt(0);
            }
            tmp = pile[count - 1];
            pile.RemoveAt(count - 1);
            if (count % 2 == 0)
                SumAlex += tmp;
            else
                SumLee += tmp;
        }
        StonePlay(ref pile, ref SumAlex, ref SumLee);
    }

    public bool Compare(List<int> pile)
    {
        int sumA = 0;
        int sumB = 0;
        int count = pile.Count;
        sumA += pile[0];
        if (pile[1] >= pile[count - 1])
            sumA += pile[count - 1];
        sumB += pile[count - 1];
        if (pile[0] >= pile[count - 2])
            sumB += pile[count - 2];
        if (sumA >= sumB)
            return true;
        return false;
    }
    
}