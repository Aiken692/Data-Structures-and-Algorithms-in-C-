// See https://aka.ms/new-console-template for more information


using Data_Structures_and_Algorithms.LearnDSAlgorithms.ADT;
using Data_Structures_and_Algorithms.LearnDSAlgorithms.LinkedLists;

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

//Recursion r = new Recursion();
//r.calculate(3);
//Console.ReadKey();