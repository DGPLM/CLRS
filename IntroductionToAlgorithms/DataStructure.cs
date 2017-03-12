using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{
    public class DataStructure
    {
        #region 数据结构
       
      
        /// <summary>
        /// 泛型树节点类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class TNode<T>
        {
            //定义泛型数据
            private T value;
            public T Value
            {
                get { return value;}
                set { this.value = value; }
            }
            //泛型父节点
            private TNode<T> parent;
            public TNode<T> Parent
            {
                get { return parent; }
                set { parent = value; }
            }
            //泛型左子树节点
            private TNode<T> left;
            public TNode<T> Left
            {
                get { return left; }
                set { left = value; }
            }
            //泛型右子树节点
            private TNode<T> right;
            public TNode<T> Right
            {
                get { return right; }
                set { right = value; }
            }                        
        }
        public class Tree<T>
        {
            //定义树节点的总数,初始化为0
            private int count;
            public int Count
            {
                get { return count; }
                set { count = value; }
            }
            //定义树的根节点,初始化为空
            private TNode<T> root;
            public TNode<T> Root
            {
                get { return root; }
                set { root = value; }
            }
            //定义树的中序遍历
            public void Inorder_Tree_Walk(TNode<T> root)
            {               
                if (root != null)
                {
                    Inorder_Tree_Walk(root.Left);
                    Console.WriteLine(root.Value);
                    Inorder_Tree_Walk(root.Right);
                }               
            }
            //定义树的前序遍历
            public void Preorder_Tree_Walk(TNode<T> root)
            {
                if (root != null)
                {
                    Console.WriteLine(root.Value);
                    Preorder_Tree_Walk(root.Left);
                    Preorder_Tree_Walk(root.Right);
                }
            }
            //定义树的后序遍历
            public void Postorder_Tree_Walk(TNode<T> root)
            {
                if (root != null)
                {
                    Postorder_Tree_Walk(root.Left);
                    Postorder_Tree_Walk(root.Right);
                    Console.WriteLine(root.Value);
                }
            }
            public void Tree_Insert(TNode<T> node)
            {
                TNode<T> temp = this.Root;
                TNode<T> temp1 = null;
                while (temp != null)
                {
                    temp1 = temp;
                    if (node.Value < temp1.Value)
                    {

                    }
                }
            }
            public static bool operator < (TNode<T> node1,TNode<T> node2)
            {
                if (node1.Equals(node2))
                {
                    Equals()
                }
            } 
                
        }
        #endregion

    }
}
