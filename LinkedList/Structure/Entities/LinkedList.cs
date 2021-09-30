using System;
using System.Text;
using Structure.Interfaces;

namespace Structure.Entities
{
    public sealed class LinkedList<T> : ILinkedList<T>
    {
        private Node<T> _Head { get; set; } = null;

        private Node<T> _Tail { get; set; } = null;

        private int _Size 
        { 
            get 
            {
                var size = 0;
                for(var current = _Head; current != null; size++)
                    current = current.Next;
                
                return size;
            }
        }

        public int Count => _Size;

        public T GetAt(int index){
            if (index >= _Size)
                throw new Exception("List out of bounds");


            var current = _Head;
            for(int i = 0; i < index && current.Next != null; i++)
                current = current.Next;
            
            return current.Value;
        }

        public void Append(T value)
        {
            var node = new Node<T>(value);

            if(_Size == 0)
            {
                _Head = node;
                _Tail = _Head;
            }
            else
            {
                _Tail.Next = node;
                _Tail = node;
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= _Size)
                throw new Exception("List out of bounds");
            
            Node<T> previous = null;
            var current = _Head;

            for(var i = 0; i < index; i++)
            {
                previous = current;
                current = current.Next;
            }

            if (current != _Head)
            {
                if (current == _Tail)
                    _Tail = previous;

                previous.Next = current.Next;
            }
            else
                _Head = current.Next;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            
            var current = _Head;
            for(var i = 0; i < _Size && current != null; i++)
            {
                sb.Append(current !=_Tail ? $"({current.Value}) -> " : $"({current.Value})");
                current = current.Next;
            }

            return sb.ToString();
        }
    }
}