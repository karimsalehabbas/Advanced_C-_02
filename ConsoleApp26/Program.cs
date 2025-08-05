using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp26
{
    #region Q7 Class
    //public class MyQueue<T>
    //{
    //    private Queue<T> queue = new Queue<T>();
    //
    //    public void Enqueue (T item)
    //    {
    //        queue.Enqueue (item);
    //    }
    //
    //    public T Dequeue()
    //    {
    //       return queue.Dequeue();
    //    }
    //
    //    public int Count => queue.Count;
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Enter N And Q");
            string[] Input = Console.ReadLine().Split();
            int N = Convert.ToInt32(Input[0]);
            int Q = Convert.ToInt32(Input[1]);

            ArrayList arrayList = new ArrayList();
            string[] elements = Console.ReadLine().Split();
            foreach (string s in elements)
            {
                arrayList.Add(int.Parse(s));
            }

            for (int i = 0; i < Q; i++)
            {
                int X = Convert.ToInt32(Console.ReadLine());
                int Count = 0;

                foreach (int Num in arrayList)
                {
                    if (Num > X)
                    {
                        Count++;
                    }

                }
                Console.WriteLine(Count);
            }
            #endregion

            #region Q2
            //int n = int.Parse(Console.ReadLine());
            //
            //string[] Input = Console.ReadLine().Split();
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Input[i]);
            //}
            //
            //bool IsPalindrome = true;
            //
            //for(int i = 0; i < n/2; i++)
            //{
            //    if (array[i] != array[n - 1 - i])
            //    {
            //        IsPalindrome = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(IsPalindrome ? "Yes" : "No");
            #endregion

            #region Q3
            //Queue<int> MyQueue = new Queue<int>();
            //MyQueue.Enqueue(10);
            //MyQueue.Enqueue(20);
            //MyQueue.Enqueue(30);
            //MyQueue.Enqueue(40);
            //
            //Console.WriteLine("Original Queue : ");
            //foreach (int i in MyQueue)
            //{
            //    Console.WriteLine(i + " ");
            //}
            //
            //ReverseQueue(MyQueue);
            //
            //Console.WriteLine("\nReversed Queue : ");
            //foreach(int i in MyQueue)
            //{
            //    Console.WriteLine(i + " ");
            //}
            #endregion

            #region Q4
            //string input = "[()]{}";
            //bool isBalanced = IsBalance(input);
            //Console.WriteLine(isBalanced ? "Balanced" : "Not Balanced");
            #endregion

            #region Q5
            //int[] array = { 10, 15, 7, 10, 12, 7, 30, 31, 30, 15 };
            //int[] uniqueArray = RemoveDuplicates(array);
            //
            //Console.WriteLine("The Arrar After Remove Dublication : ");
            //
            //foreach (int num  in uniqueArray)
            //{
            //    Console.WriteLine(num + " ");
            //}
            #endregion

            #region Q6
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] EvenNumbers  = RemoveOddNumbers(array);
            //
            //Console.WriteLine("The Numbers After Remove Odd Numbers");
            //
            //foreach (int num in EvenNumbers)
            //{
            //    Console.WriteLine(num + " ");
            //}
            #endregion

            #region Q7
            //MyQueue<int> intQueue = new MyQueue<int>();
            //intQueue.Enqueue(1);
            //Console.WriteLine($"Dequeued From int Queue : {intQueue.Dequeue()}");
            //
            //MyQueue<string> stringQueue = new MyQueue<string>();
            //stringQueue.Enqueue("Apple");
            //Console.WriteLine($"Dequeued From string Queue : {stringQueue.Dequeue()}");
            //
            //MyQueue<double> doubleQueue = new MyQueue<double>();
            //doubleQueue.Enqueue(5.28);
            //Console.WriteLine($"Dequeued From double Queue : {doubleQueue.Dequeue()}");
            #endregion

            #region Q8
            //Stack<int> stack = new Stack<int>();
            //int[] numbers = { 5, 8, 9, 13, 3, 4, 7, 1, 30 };
            //foreach (int num in numbers)
            //{
            //    stack.Push(num);
            //}
            //
            //Console.WriteLine("Enter You Target Integer To Search For : ");
            //if (!int.TryParse(Console.ReadLine() , out int target))
            //{
            //    Console.WriteLine("Invalid Input Please Enter Your Triger As Integer.");
            //    return;
            //}
            //
            //int count = 0;
            //bool Found = false;
            //
            //Stack<int> tempStack = new Stack<int>(stack);
            //
            //while (tempStack.Count > 0)
            //{
            //    int Current = tempStack.Pop();
            //    if (Current == target)
            //    {
            //        Found = true;
            //        break;
            //    }
            //    count++;
            //}
            //
            //if (Found)
            //{
            //    Console.WriteLine($"Target was found successfully and the count = {count}");
            //}
            //else
            //{
            //    Console.WriteLine("Target was not found");
            //}
            #endregion

            #region Q9
            //int[] nums1 = { 1, 2, 3, 4, 4 };
            //int[] nums2 = { 10, 4, 4 };
            //
            //int[] intersection = GetIntersection(nums1, nums2);
            //
            //Console.WriteLine("Output:");
            //foreach (int num in intersection)
            //{
            //    Console.Write(num + " ");
            //}

            #endregion

            #region Q10
            //List<int> numbers = new List<int> { 1, 2, 3, 7, 5 };
            //int target = 12;
            //
            //List<int> result = FindSublist(numbers, target);
            //
            //Console.WriteLine("Output:");
            //if (result.Count > 0)
            //    Console.WriteLine(string.Join(", ", result));
            //else
            //    Console.WriteLine("No sublist found");

            #endregion

            #region Q11
            //Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            //int K = 3;
            //
            //Queue<int> result = ReverseKElements(queue, K);
            //
            //Console.WriteLine("Output:");
            //foreach (int num in result)
            //{
            //    Console.Write(num + " ");
            //}

            #endregion
        }

        #region Q3 Fun
        //static void ReverseQueue<T>(Queue<T> queue)
        //{
        //
        //    Stack<T> stack = new Stack<T>();
        //
        //    while (queue.Count > 0)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }
        //}

        #endregion

        #region Q4 Fun
        //static bool IsBalance(string str)
        //{ 
        //
        //  Stack<char> stack = new Stack<char>();
        //  Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        //  {
        //       {')', '('},
        //       {']', '['},
        //       {'}', '{'}
        //  };
        //
        //  foreach (char ch in str)
        //  {
        //      if (bracketPairs.ContainsValue(ch)) 
        //      {
        //          stack.Push(ch);
        //      }
        //      else if (bracketPairs.ContainsKey(ch)) 
        //      {
        //          if (stack.Count == 0 || stack.Pop() != bracketPairs[ch])
        //          {
        //              return false;
        //          }
        //      }
        //  }
        //
        //  return stack.Count == 0;
        //   
        //}
        #endregion

        #region Q5 Fun
        //static int[] RemoveDuplicates(int[] input)
        //{
        //    List<int> result = new List<int>();
        //    foreach (int num in input)
        //    {
        //        if (!result.Contains(num))
        //        {
        //            result.Add(num);
        //        }
        //    }
        //    return result.ToArray();
        //}
        #endregion

        #region Q6 Fun
        //static int[] RemoveOddNumbers (int[] input)
        //{
        //    List<int> result = new List<int>();
        //    foreach (int num in input)
        //    {
        //        if (num % 2 == 0)
        //        {
        //            result.Add (num);
        //        }
        //    }
        //    return result.ToArray ();
        //}
        #endregion

        #region Q9 Fun
        //static int[] GetIntersection(int[] arr1, int[] arr2)
        //{
        //    List<int> result = new List<int>();
        //    bool[] visited = new bool[arr2.Length];
        //
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        for (int j = 0; j < arr2.Length; j++)
        //        {
        //            if (!visited[j] && arr1[i] == arr2[j])
        //            {
        //                result.Add(arr1[i]);
        //                visited[j] = true;
        //                break;
        //            }
        //        }
        //    }
        //
        //    return result.ToArray();

        #endregion

        #region Q10 Fun
        //static List<int> FindSublist(List<int> list, int target)
        //{
        //    for (int start = 0; start < list.Count; start++)
        //    {
        //        int sum = 0;
        //        for (int end = start; end < list.Count; end++)
        //        {
        //            sum += list[end];
        //            if (sum == target)
        //                return list.GetRange(start, end - start + 1);
        //        }
        //    }
        //    return new List<int>();
        //}     
        #endregion

        #region Q11 Fun
        //static Queue<int> ReverseKElements(Queue<int> queue, int K)
        //{
        //    Stack<int> stack = new Stack<int>();
        //
        //    for (int i = 0; i < K; i++)
        //    {
        //        if (queue.Count > 0)
        //            stack.Push(queue.Dequeue());
        //    }
        //
        //    Queue<int> result = new Queue<int>();
        //    while (stack.Count > 0)
        //    {
        //        result.Enqueue(stack.Pop());
        //    }
        //
        //    while (queue.Count > 0)
        //    {
        //        result.Enqueue(queue.Dequeue());
        //    }
        //
        //    return result;
        //}
        #endregion
    }
}

