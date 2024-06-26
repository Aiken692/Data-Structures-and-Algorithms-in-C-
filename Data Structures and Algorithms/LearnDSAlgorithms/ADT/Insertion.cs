namespace Data_Structures_and_Algorithms.LearnDSAlgorithms.ADT;

public class Insertion
{
    public int[] IntArray { get; set; } = new int[10];

    public int Length { get; set; } = 0;
    
    public void InsertToEnd()
    {
        AddDataInTheArray(IntArray, Length);
        
        Console.WriteLine("Inserting at the End of an Array");
        IntArray[Length] = 10;
    }

    public void InsertFromStart()
    {
        Console.WriteLine("Inserting at the start of an Array"); 
        
        for (int i = 5; i >= 0; i--)
        {
            IntArray[i + 1] = IntArray[i];
        }

        IntArray[0] = 99;
    }

    public void InsertAnyWhere()
    {
        Console.WriteLine("Inserting any where of an Array");

        for (int i = 4; i >= 2; i--)
        {
            //This a shift element one position to the right
            IntArray[i + 1] = IntArray[i];
        }

        IntArray[2] = 75;
    }
    
    public void AddDataInTheArray(int[] intArray, int length)
    {
        //Adds data for us
        for (int i = 0; i <= 8; i++)
        {
            intArray[length] = i;
            length++;
        }

        Length = length;
    }
    
}