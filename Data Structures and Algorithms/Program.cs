// See https://aka.ms/new-console-template for more information


using Data_Structures_and_Algorithms.LearnDSAlgorithms.ADT;
using Data_Structures_and_Algorithms.LearnDSAlgorithms.BinarySearch;
using Data_Structures_and_Algorithms.LearnDSAlgorithms.BinarySearchTree;
using Data_Structures_and_Algorithms.LearnDSAlgorithms.BubbleSort;
using Data_Structures_and_Algorithms.LearnDSAlgorithms.LinkedLists;
using Data_Structures_and_Algorithms.LearnDSAlgorithms.Queues;
using Data_Structures_and_Algorithms.LearnDSAlgorithms.Stacks;

Console.WriteLine("Hello, World!");

//Arrays 
//Array Inserttions & Deletions

//Inserting at the End of an Array
//Length indicates capacity 

Console.WriteLine("Inserting at the End of an Array");
Insertion insertion = new Insertion();

insertion.InsertToEnd();

Console.WriteLine("Inserting at the start of an Array");
insertion.InsertFromStart();

Console.WriteLine("Inserting any where of an Array");
insertion.InsertAnyWhere();

Console.Clear();

//Deleting
Console.WriteLine("Inserting any where of an Array has been finished");

Console.Clear();
Deletion delete = new();

Console.Clear();
Console.WriteLine("Deleting From the Start of an Array");
delete.DeleteValueFromStart();

Console.Clear();
Console.WriteLine("Deleting From the End of an Array");
delete.DeleteValuesFromEndOfAnArray();

Console.Clear();
Console.WriteLine("Deleting From the Any where of an Array");
delete.DeleteValuesFromAnywhereInAnArray();


//Linear Search in an Array
LinearSearchArray linearSearchArray = new();
linearSearchArray.LinearSearch(linearSearchArray.array, 4);
Console.WriteLine();



//Linked List
/*Node nodeA = new Node();
nodeA.Data = 100;

Node nodeB = new Node();
nodeB.Data = 300;

Node nodeC = new Node();
nodeC.Data = 500;

Node nodeD = new Node();
nodeD.Data = 700;

nodeA.Next = nodeB;
nodeB.Next = nodeC;
nodeC.Next = nodeD;*/
Console.Clear();
Console.WriteLine("Intializing a linked list.....");

LinkedList linkedList = new LinkedList();

linkedList.InsertFirst(1);
linkedList.InsertFirst(2);
linkedList.InsertFirst(3);
linkedList.InsertFirst(4);
linkedList.InsertFirst(5);
linkedList.InsertFirst(6);
linkedList.InsertFirst(7);
linkedList.InsertFirst(8);

linkedList.DeleteFirst();
linkedList.DeleteFirst();

linkedList.InsertLast(546);
linkedList.InsertLast(3434);

linkedList.DisplayList();

//Stacking
//Intro to stacks in c#
//Imagine a pile of bills on your desk 
Stack stack = new Stack(10);

for (int i = 0; i < 3; i++)
{
    stack.Push("Squirtle");
    stack.Push("Pickachu");
    stack.Push("Togo");
}

stack.Pop();
stack.Peek();

while (!stack.IsEmpty())
{
    var var = stack.Pop();
}

//Queues in DSA
Queue queue = new Queue(10);

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

queue.Dequeue();
queue.Dequeue();

queue.Peek();

Console.Clear();
Console.WriteLine("Binary Search operation Initializing......");
//Binary Search
BinarySearch binarySearch = new();
binarySearch.BinarySearchOperation(binarySearch.BinaryArray, 2);


//Binary Search Tree
Console.Clear();
Console.WriteLine("Binary Search Tree operation Initializing......");

BinarySearchTree bst = new();
bst.Insert(7, "RangeRover");
bst.Insert(23, "LandRover");
bst.Insert(151, "Lexus");
bst.Insert(4, "Toyota");
bst.Insert(1, "Subaru");

Console.WriteLine(bst.Find((151)));

//Bubble Sort
Console.Clear();
Console.WriteLine("Bubble Sort Operation Initializing......");

BubbleSort bubbleSort = new();
var IntArray = new[] { 6, 5, 1, 7, 2, 4 };

bubbleSort.BubbleSortOperation(IntArray);

Console.WriteLine("Bubble Sort Operation done......");


//Recursion r = new Recursion();
//r.calculate(3);
//Console.ReadKey();