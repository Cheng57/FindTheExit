using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoublyLinkedLists;

namespace FindTheExit
{
    class Stack<T>
    {
        /// <summary>
        /// Gets or sets the size of the stack.
        /// </summary>
        public int Size
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the head of the stack.
        /// </summary>
        public Node<T> Head
        {
            get; set;
        }

        /// <summary>
        /// Initializes an instance of Stack with default size and head.
        /// </summary>
        public Stack()
        {
            this.Size = 0;
            this.Head = null;
        }

        /// <summary>
        /// Returns true if the stack is empty, else returns false.
        /// </summary>
        /// <returns>True if the stack is empty, else false.</returns>
        public Boolean IsEmpty()
        {
            return Size == 0;
        }

        /// <summary>
        /// Creates a new Node with the specified element and adds it to the top of the stack.
        /// </summary>
        /// <param name="element">The specified element.</param>
        public void Push(T element)
        {
            Node<T> node = new Node<T>(element);

            if (!IsEmpty())
            {
                node.Previous = Head; 
            }
            
            Head = node;
            Size++;
        }

        /// <summary>
        /// Throws an exception when the stack is empty.
        /// </summary>
        private void EmptyStackThrowException()
        {
            if (IsEmpty())
            {
                throw new ApplicationException("This stack is empty.");
            }
        }

        /// <summary>
        /// Returns the top element on the stack without removing it.
        /// </summary>
        /// <returns>The top element.</returns>
        public T Top()
        {
            EmptyStackThrowException();

            return Head.Element;
        }

        /// <summary>
        /// Returns the top element on the stack and removes it.
        /// </summary>
        /// <returns>The top element.</returns>
        public T Pop()
        {
            EmptyStackThrowException();

            T element = Head.Element;
            Head = Head.Previous;

            Size--;
            return element;
        }

        /// <summary>
        /// Empty all elements from the stack.
        /// </summary>
        public void Clear()
        {
            EmptyStackThrowException();

            while (Size > 0)
            {
                Head = Head.Previous;
                Size--;
            }
        }
    }
}
