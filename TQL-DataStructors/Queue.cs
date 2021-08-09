using System;
namespace TQL_DataStructures {

    public class Queue<T> {
        private const int InitialSize = 8;
        private Item<T>[] queue;
        public int Count { get; set; } = 0;
        private bool Full => Count == queue.Length;
        public bool Empty => Count == 0;

        public T Dequeue() {
            var item = queue[0];
            Count--;
            Reorg();
            return item.t;
        }
        public void Enqueue(T t) {
            if (Full)
                DoubleSize();
            if(Count == 0) {
                AddInitial(t);
                return;
            }
            var tNew = new Item<T>(t);
            queue[Count++] = tNew;
        }

        private void AddInitial(T t) {
            var q = new Item<T>(t);
            queue[0] = q;
            Count = 1;
        }

        public void Reorg() {
            for(var idx = 0; idx < queue.Length - 1; idx++) {
                queue[idx] = queue[idx + 1];
            }
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
