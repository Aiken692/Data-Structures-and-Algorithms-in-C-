namespace Data_Structures_and_Algorithms.LearnDSAlgorithms.ADT;

public class Deletion
{
    public int[] IntArray { get; set; } = new int[9];

    public int Length { get; set; } = 0;

    public void DeleteValuesFromAnywhereInAnArray()
    {
        Length = 0;
        AddDataInTheArray(IntArray, Length);

        for (int i = 4; i < Length; i++)
        {
            IntArray[i - 1] = IntArray[i];
        }

        Length--;
        
        DisplayTheRemainingValues();
    }

    public void DeleteValuesFromEndOfAnArray()
    {
        Length = 0;
        AddDataInTheArray(IntArray, Length);

        Length--;
        
        DisplayTheRemainingValues();
    }

    public void DeleteValueFromStart()
    {
        Length = 0;
        AddDataInTheArray(IntArray, Length);

        for (int i = 1; i < Length; i++)
        {
            IntArray[i - 1] = IntArray[i];
        }

        Length--;
        
        DisplayTheRemainingValues();
    }

    public void DisplayTheRemainingValues()
    {
        Console.Clear();
        for (int i = 0; i < Length; i++)
        {
            Console.WriteLine(IntArray[i]);
        }    }
    
    public void AddDataInTheArray(int[] intArray, int length)
    {
        //Adds data for us
        for (int i = 0; i < 6; i++)
        {
            intArray[length] = i;
            length++;
            Console.WriteLine(intArray[i]);
        }

        Length = length;
    }
}