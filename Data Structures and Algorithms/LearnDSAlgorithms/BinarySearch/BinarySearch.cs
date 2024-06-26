namespace Data_Structures_and_Algorithms.LearnDSAlgorithms.BinarySearch;

public class BinarySearch
{
    public int[] BinaryArray = { -22, -15, 2, 7, 20, 30, 54 };
    
    public int BinarySearchOperation(int[] intArray, int value)
    {
        int start = 0;
        int end = BinaryArray.Length;
    
        //Start end + whileless than is going criss crossing
        while (start < end)
        {
            //Put the parenthensis because add them incorrect
            int midpoint = (start + end) / 2;
        
            //Search the middle of the book
            if (BinaryArray[midpoint] == value)
            {
                return midpoint;
            }
            else if (BinaryArray[midpoint] < value)
            {
                start = midpoint + 1;
            }
            else
            {
                end = midpoint;
            }
        }
        return -1;
    }
}

