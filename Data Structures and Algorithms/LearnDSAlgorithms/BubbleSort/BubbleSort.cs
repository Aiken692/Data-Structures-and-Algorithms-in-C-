namespace Data_Structures_and_Algorithms.LearnDSAlgorithms.BubbleSort;

public class BubbleSort
{
    public int[] IntArray { get; set; } = new[] { 6, 5, 1, 7, 2, 4 };

    public int[] BubbleSortOperation(int[] array)
    {

        int temp = 0;

       
        for (int pointer = 0; pointer < array.Length; pointer++)
        {
            
            for (int sort = 0; sort < array.Length - 1; sort++)
            {
               
                if (array[sort] > array[sort + 1])
                {
                    
                    temp = array[sort + 1];
                    
                    
                    array[sort + 1] = array[sort];
                    
                   
                    array[sort] = temp;
                }
            }
        }

        return IntArray;
    }
}