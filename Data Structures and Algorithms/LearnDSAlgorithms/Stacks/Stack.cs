namespace Data_Structures_and_Algorithms.LearnDSAlgorithms.Stacks;

public class Stack
{
    public int MaxSize { get; set; } //Array stacks you need a maxsize to init Array
    //This holds our array
    public string[] StackArray { get; set; }
    //this keeps track of the top
    public int Top { get; set; }

    public Stack(int size)
    {
        //This holds constructor value
        this.MaxSize = size;
        //Creates array with size
        this.StackArray = new string[MaxSize];
        //We give the top -1 because array is zero index; if we don't, it will skip first elemnt
        this.Top = -1;
    }
    
    public void Push(string item)
    {
        Top++;
        StackArray[Top] = item;
    }

    public string Pop()
    {
        int old_top = Top;
        Top--;
        return StackArray[old_top];
    }

    public string Peek()
    {
        return StackArray[Top];
    }

    public bool IsEmpty()
    {
        return Top == 0;
    }

    public bool isFull()
    {
        return MaxSize - 1 == Top;
    }
}