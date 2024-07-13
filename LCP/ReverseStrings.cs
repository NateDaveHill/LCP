namespace LCP;

public class ReverseStrings
{
    public void ReverseString(char[] s)
    {
        int j = 0;
        char[] sClone = (char[])s.Clone();

        for (int i = s.Length - 1; i != -1; i--)
        {
            s[j] = sClone[i];
            j++;
        }

        Console.WriteLine(s);
    }
}