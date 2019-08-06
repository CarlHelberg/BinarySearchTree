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

            public void Find(T _value)
            {
                var current = Head;
                Node<T> FindThis = new Node<T>(_value);
                if (Head == null)
                {
                    Console.WriteLine("This tree is empty!");
                }
                else if(current.value.CompareTo(FindThis.value) == 0)
                {
                    Console.WriteLine("The value {0} is at the Head of the tree", current.value);
                }
                else
                {
                    Console.WriteLine(current.value);
                    while (current != null)
                    {
                        if (current.value.CompareTo(FindThis.value) < 0)
                        {
                            current = current.rightChild;
                            if (current.value.CompareTo(FindThis.value) == 0)
                            {
                                Console.WriteLine(">" + current.value);
                                break;
                            }
                            Console.WriteLine(">" + current.value);
                        }

                        if (current.value.CompareTo(FindThis.value) > 0)
                        {
                            current = current.leftChild;
                            if (current.value.CompareTo(FindThis.value) == 0)
                            {
                                Console.WriteLine("<" + current.value);
                                break;
                            }
                            Console.WriteLine("<" + current.value);
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