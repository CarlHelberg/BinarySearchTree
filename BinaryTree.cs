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

            public Node<T> ReturnHead()
            {
                return Head;
            }

            public void Inorder(Node<T> _input)
            {
                if(_input != null)
                {
                    Inorder(_input.leftChild);
                    Console.Write(_input.value + " ");
                    Inorder(_input.rightChild);
                }
            }
            
            public void PostOrder(Node<T> _input)
            {
                if(_input != null)
                {
                    Inorder(_input.leftChild);
                    Inorder(_input.rightChild);
                    Console.Write(_input.value + " ");
                }
            }

            public void PreOrder(Node<T> _input)
            {
                if(_input != null)
                {
                    Console.Write(_input.value + " ");
                    Inorder(_input.leftChild);
                    Inorder(_input.rightChild);
                }
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}