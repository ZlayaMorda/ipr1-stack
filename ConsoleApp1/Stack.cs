using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipr1
{
    public class Stack<T>
    {
        private List<T> Stack_Col;

        public delegate void CollHandler(string message);                   //event declaration
        public event CollHandler Notify;


        public Stack()
        {
            Stack_Col = new List<T>();
        }

        public void Add(T item)
        {
            Stack_Col.Add(item);
            Notify?.Invoke($"item {item} has been added");
        }

        public int Count
        {
            get
            {
                return Stack_Col.Count;
            }
        }


        public bool Remove(out T item)
        {
            bool result = false;
            if(Stack_Col.Count!= 0)
            {
                item = Stack_Col[Stack_Col.Count-1];
                Notify?.Invoke($"object {item} has been removed");
                Stack_Col.RemoveAt(Stack_Col.Count-1);
                result = true;
            }
            else 
            { 
                item = default(T); 
                Notify?.Invoke("It's unable to remove - Stack is empty"); 
            }

            return result;
        }

        public T Peek()
        {
            if (Stack_Col.Count != 0) { return Stack_Col[Stack_Col.Count - 1]; }

            else { return default(T); }
        }

        public void Clear()
        {
            Stack_Col.Clear();
            Notify?.Invoke("Stack has been freed");
        }

    }
}
