namespace Data_Structures_and_Algorithms.LearnDSAlgorithms.Queues;

public class Queue
{
    public int MaxSize { get; set; } //Sets the number of elements because this is an array
    public int[] QueueArray { get; set; } //Actual Array we will store elements in
    public int Front { get; set; } //Incdex to keep track of front
    public int Rear { get; set; } //Index to keep track of adds
    public int NItems { get; set; }//This will keep track of length

    public Queue(int size)
    {
        this.MaxSize = size;
        this.QueueArray = new int[size];
        Front = 0;
        Rear = -1;
    }

    public void Enqueue(int item)
    {
        Rear++; // Increment our pointer 
        QueueArray[Rear] = NItems; //Insert into where the rear was incremented
        NItems++; //Increment
    }

    public int Dequeue()
    {
        int temp = QueueArray[Front];
        Front++;
        if (Front == MaxSize)
        {
            Front = 0;
        }

        NItems--;
        return temp;
    }

    public int Peek()
    {
        return QueueArray[Front];
    }
}