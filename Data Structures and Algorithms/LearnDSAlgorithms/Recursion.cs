namespace Data_Structures_and_Algorithms.LearnDSAlgorithms;

public class Recursion
{
    public void calculate(int n)
    {
        if (n > 0)
        {
            calculate(n - 1);
            int k = n * n;
            Console.WriteLine(k);
            calculate(n - 1);
        }
    }
}