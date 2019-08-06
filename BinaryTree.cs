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

            public void Add(T _value)
            {
                Node<T> AddThis = new Node<T> (_value);
                var current = Head;

                if (Head == null)
                {
                    Head = AddThis;
                    return;
                }

                else
                {
                    while (current != AddThis)
                    {
                        if (AddThis.CompareTo(current) >= 0)
                        {
                            if (current.rightChild == null)
                            {
                                current.rightChild = AddThis;
                                AddThis.parent = current;
                                return;
                            }
                            current = current.rightChild;
                        }
                        else if (AddThis.CompareTo(current) < 0)
                        {
                            if (current.leftChild == null)
                            {
                                current.leftChild = AddThis;
                                AddThis.parent = current;
                                return;
                            }
                            current = current.leftChild;
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