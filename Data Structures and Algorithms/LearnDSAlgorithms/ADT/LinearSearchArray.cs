namespace Data_Structures_and_Algorithms.LearnDSAlgorithms.ADT;

public class LinearSearchArray
{
    public int[] array { get; set; } = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    public bool LinearSearch(int[] array, int key)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == key)
            {
                return true;
            }
        }

        return false;
    }
}