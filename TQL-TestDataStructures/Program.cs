using System;
using TQL_DataStructures;

namespace TQL_TestDataStructures {
    class Program {
        static void Main(string[] args) {

            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            while (!queue.Empty) {
                Console.WriteLine($"{queue.Dequeue()}");
            }

            //var stack = new Stack<int>();
            //for (var idx = 0; idx < 1000; idx++) {
            //    stack.Push(idx);
            //}
            //while (!stack.Empty) {
            //    Console.Write($"{stack.Pop()},");
            //}
        }
    }
}
