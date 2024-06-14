namespace Data_Structures_and_Algorithms.LearnDSAlgorithms.LinkedLists;

public class LinkedList
{
    public Node? First { get; set; }

    public void InsertFirst(int data)
    {
        //Creaye the node
        Node newNode = new Node();
        //Put the data in the node
        newNode.Data = data;
        //Put the old node in next
        newNode.Next = First; 
        //Make the first the new node
        First = newNode;
    }

    public Node DeleteFirst()
    {
        //Assign the temporary variable
        Node temp = First;
        //Assign the next dead
        First = First.Next;
        
        return temp;
    }

    public void DisplayList()
    {
        Console.WriteLine("Iterating thru list...");
        Node current = First;

        while (current != null)
        {
            current.DisplayNode();
            current = current.Next;
        }
    }

    public void InsertLast(int data)
    {
        Node current = First;

        while (current.Next != null)
        {
            current = current.Next;
        }

        Node newNode = new Node();
        newNode.Data = data;
        current.Next = newNode;
    }
    
}