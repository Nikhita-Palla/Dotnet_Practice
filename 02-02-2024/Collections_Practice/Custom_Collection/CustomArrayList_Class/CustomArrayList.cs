using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArrayList_Class
{
    // node class for doubly linked list node
    public class DoublyLLNode<T>
    {
        public T Data { get; set; }
        public DoublyLLNode<T> Next { get; set; }
        public DoublyLLNode<T> Previous { get; set; }


        public DoublyLLNode(T data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }

    // Custom collection Country Implementation
    public class CustomArrayList<T> : IEnumerable<T>, ICollection<T>

    {
        public DoublyLLNode<T> head;
        public DoublyLLNode<T> tail;
        public int Count { get; set; }

        public bool IsReadOnly => false;

        // Add an element to the beginning of the list
        public void AddFirst(T item)
        {
            DoublyLLNode<T> newNode = new DoublyLLNode<T>(item);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
            Count++;

        }
        public void AddLast(T item)
        {
            DoublyLLNode<T> newNode = new DoublyLLNode<T>(item);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }
            Count++;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                return;
            }
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            Count--;
        }
        public void RemoveLast()
        {
            if (tail == null)
            {
                return;
            }
            if (head == tail)
            {
                tail = null;
                head = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }
            Count--;
        }
        public bool Remove(T item)
        {
            DoublyLLNode<T> current = head;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, item))
                {
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        tail = current.Previous;
                    }

                    Count--;
                    return true;
                }

                current = current.Next;
            }
            return false;
        }
        public bool InsertAt(int given_index, T value)
        {
            if (given_index < 0)
            {
                throw new ArgumentException(nameof(given_index));
            }
            DoublyLLNode<T> newNode = new DoublyLLNode<T>(value);
            if (given_index == 0)
            {
                if (head == null)
                {
                    head = newNode;
                }

                newNode.Next = head;
                head = newNode;
                Count++;
                return true;
            }
            else
            {
                DoublyLLNode<T> current = head;
                for (int i = 0; i < given_index - 1; i++)
                {
                    current = current.Next;
                }
                newNode.Previous = current;
                newNode.Next = current.Next;

                if (current.Next != null)
                {
                    current.Next.Previous = newNode;
                }

                current.Next = newNode;


            }
            Count++;
            return true;
        }
        public bool DeleteAt(int given_index)
        {
            if (given_index < 0)
            {
                throw new ArgumentException("Index cannot be negative.", nameof(given_index));
            }

            if (head == null)
            {
                throw new Exception("No elements in the collection");
            }

            if (given_index == 0)
            {
                head = head.Next;
            }
            else
            {
                DoublyLLNode<T> current = head;
                for (int i = 0; i < given_index - 1; i++)
                {
                    if (current == null || current.Next == null)
                    {
                        throw new ArgumentOutOfRangeException(nameof(given_index));
                    }
                    current = current.Next;
                }

                if (current.Next == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(given_index));
                }

                current.Next = current.Next.Next;

                if (current.Next != null)
                {
                    current.Next.Previous = current;
                }
            }

            Count--;
            return true;
        }

        public bool Contains(T item)
        {
            DoublyLLNode<T> current = head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void AddRange(ICollection<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            foreach (var element in collection)
            {
                AddLast(element);

            }


        }
        public void RemoveRange(int index, int count)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (count < 0)
            {
                throw new ArgumentException("Count must be non-negative.", nameof(count));
            }

            if (index + count > Count)
            {
                throw new ArgumentException("Invalid range specified.");
            }

            for (int i = 0; i < index; i++)
            {
                head = head.Next;
            }

            DoublyLLNode<T> current = head;
            for (int i = 0; i < count; i++)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }

                current = current.Next;
            }

            Count -= count;
        }
        public T[] ToArray()
        {
            T[] array = new T[Count];
            DoublyLLNode<T> current = head;

            for (int i = 0; i < Count; i++)
            {
                if (current != null)
                {
                    array[i] = current.Data;
                    current = current.Next;
                }

            }

            return array;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public void Add(T item)
        {
            AddLast(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(arrayIndex) + "Destination array cannot be null");

            if (arrayIndex < 0 || arrayIndex >= array.Length)
                throw new ArgumentOutOfRangeException(nameof(arrayIndex));

            if (Count > array.Length - arrayIndex)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            DoublyLLNode<T> current = head;
            while (current != null)
            {
                array[arrayIndex++] = current.Data;
                current = current.Next;
            }

        }


        public IEnumerator<T> GetEnumerator()
        {
            DoublyLLNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
