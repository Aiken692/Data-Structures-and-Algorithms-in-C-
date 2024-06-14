namespace Data_Structures_and_Algorithms.LearnDSAlgorithms.LinkedLists;

public class Node
{
    public int Data { get; set; }
    public Node? Next { get; set; }

    public void DisplayNode()
    {
        Console.WriteLine(Data);
    }
}