using System;
namespace TQL_DataStructures {

    public class FixedArray<T> {

        private T[] blocks;
        private int nextBlk = 0;
        private int count = 0;
        private bool full => count == blocks.Length;

        public void Add(T t) {
            blocks[nextBlk++] = t;
            count++;
        }
        public void Delete(T t) {

        }
        private void DoubleCapacity() {
            var newBlock = new T[blocks.Length * 2];
            for(var i = 0; i < blocks.Length; i++) {
                newBlock[i] = blocks[i];
            }
        }

        public FixedArray(int size = 8) {
            blocks = new T[size];
        }
    }
}
