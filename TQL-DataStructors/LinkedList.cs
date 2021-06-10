using System;
namespace TQL_DataStructures {

    public class LinkedList<T> {

        private const int InitialSize = 8;
        private LinkedList<T>[] linkedlist;
        public LinkedList<T> Next { get; set; } = null;
        private LinkedList<T> Top { get; set; } = null;

        

        public LinkedList() {
            linkedlist = new LinkedList<T>[InitialSize];
        }
    }
}
