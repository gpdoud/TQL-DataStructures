using System;
namespace TQL_DataStructures {

    public class Queue<T> {
        private const int InitialSize = 8;
        private Item<T>[] queue;
        private int First = -1;
        private int Last = -1;
        public int Count { get; set; } = 0;
        private bool Full => Count == queue.Length;

        public void AddLast(T t) {
            if (Full)
                DoubleSize();
            if(Count == 0) {
                AddInitial(t);
                return;
            }
            var tNew = new Item<T>(t);
            var tLast = queue[Last];
            queue[++Last] = tNew;
            tLast.Next = Last;
            tNew.Prev = Last - 1;
            Count++;
        }

        private void AddInitial(T t) {
            var q = new Item<T>(t);
            queue[0] = q;
            First = 0;
            Last = 0;
            Count++;
        }

        private void DoubleSize() {
            var newQueue = new Item<T>[queue.Length * 2];
            for(var idx = 0; idx < queue.Length; idx++) {
                newQueue[idx] = queue[idx];
            }
            queue = newQueue;
        }
        public Queue() {
            queue = new Item<T>[InitialSize];
        }
    }
}
