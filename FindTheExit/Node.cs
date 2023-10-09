namespace DoublyLinkedLists
{
    /// <summary>
    /// Represents a node.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {

        /// <summary>
        /// Initializes an instance of Node with an element, a previousNode and a nextNode.
        /// </summary>
        /// <param name="element">The element of the node.</param>
        /// <param name="previousNode">The previousNode of the node.</param>
        /// <param name="nextNode">The nextNode of the node.</param>
        public Node(T element, Node<T> previousNode, Node<T> nextNode)
        {
            this.Element = element;
            this.Previous = previousNode;
            this.Next = nextNode;
        }

        /// <summary>
        /// Initializes an instance of Node with an element, default previousNode and nextNode.
        /// </summary>
        /// <param name="element">The element of the node.</param>
        public Node(T element) : this(element, null, null)
        {

        }

        /// <summary>
        /// Initializes an instance of Node with properties in default.
        /// </summary>
        public Node() : this(default, null, null)
        {

        }

        /// <summary>
        /// Gets or sets the element of the node.
        /// </summary>
        public T Element
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the previous of the node.
        /// </summary>
        public Node<T> Previous
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the next of the node.
        /// </summary>
        public Node<T> Next
        {
            get; set;
        }
    }
}