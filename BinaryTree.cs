using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        class BinarySearchTree<T> where T : IComparable
        {
            public class Node<T> : IComparable where T : IComparable 
            {
                public T value;
                public Node<T> leftChild;
                public Node<T> rightChild;
                public Node<T> parent;

                public Node(T _value) 
                {
                    value = _value;
                    leftChild = null;
                    rightChild = null;
                    parent = null;
                }

                public int CompareTo(object obj)
                {
                    if (obj == null) return 1;

                    Node<T> otherObject = obj as Node<T>;
                    if (otherObject != null)
                    {
                        return this.value.CompareTo(otherObject.value);
                    }

                    else
                    {
                        throw new ArgumentException("Object is not 'AnObject'");
                    }
                }
            }
            public Node<T> Head;

            public void Delete(T _value)
            {
                Node<T> DeleteThis = new Node<T>(_value);
                var current = Head;

                if (Head == null)
                {
                    Console.WriteLine("This tree is empty!"); 
                    return;
                }

                else
                {
                    while (DeleteThis.CompareTo(current) != 0)
                    {
                        if (DeleteThis.CompareTo(current) < 0)
                        { 
                            if (DeleteThis.CompareTo(current) < 0 && current.leftChild == null)
                            {
                            Console.WriteLine("The value you are trying to delete does not exist in this tree");
                            return;
                            }
                                current = current.leftChild;
                        }
                        else if (DeleteThis.CompareTo(current) > 0)
                        {
                            if (DeleteThis.CompareTo(current) > 0 && current.rightChild == null)
                            {
                                Console.WriteLine("The value you are trying to delete does not exist in this tree");
                                return;
                            }
                            current = current.rightChild;
                        }
                    }

                    if (DeleteThis.CompareTo(current) == 0)
                    {
                        if (current.leftChild != null)
                        {
                            current.leftChild.parent = current.parent;
                            current.parent.leftChild = current.leftChild;
                            current.leftChild = null;
                        }
                        if (current.rightChild != null)
                        {
                            current.rightChild.parent = current.parent;
                            current.parent.rightChild = current.rightChild;
                            current.rightChild = null;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}