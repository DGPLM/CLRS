using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToAlgorithms
{

    /// <summary>
    /// 泛型树节点类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TNode<T> where T : IComparable<T>
    {

       public TNode()
        {
            this.Parent = null;
            this.Left = null;
            this.Right = null;
            this.Value = default(T);         
        }
        public TNode(T root)
        {
            this.Parent = null;
            this.Left = null;
            this.Right = null;
            this.Value = root;
        }
        

        //定义泛型数据       
        public T Value { get; set; }

        //泛型父节点
        public TNode<T> Parent { get; set; }

        //泛型左子节点
        public TNode<T> Left { get; set; }

        //泛型右子树节点        
        public TNode<T> Right { get; set; }

        public void DisplayValue()
        {
            Console.WriteLine(this.Value);
        }
        
    }
    public class Tree<T> where T:IComparable<T>
    {
        public Tree()
        {
            this.Count = 0;
            this.Root = null;
        }
        public Tree(TNode<T> root)
        {
            this.Count++;
            this.Root = root;
        }
       

        //定义树节点的总数,初始化为0
       public int Count { get; set; }
        //定义树的根节点,初始化为空
       public TNode<T> Root { get; set; }



        //定义树的中序遍历
        public void Inorder_Tree_Walk(TNode<T> root)
        {
            if (root != null)
            {
                Inorder_Tree_Walk(root.Left);
                root.DisplayValue();
                Inorder_Tree_Walk(root.Right);
            }
        }
       
        //定义树的前序遍历
        public void Preorder_Tree_Walk(TNode<T> root)
        {
            if (root != null)
            {
               root.DisplayValue();
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
                root.DisplayValue();
            }
        }

        
        

        /// <summary>
        /// 二叉树查找循环版本
        /// </summary>
        /// <param name="root">树节点</param>
        /// <param name="value">查找的泛型值</param>
        /// <returns>返回查到到的节点，没有返回空</returns>
        public TNode<T> Tree_Search(TNode<T> root ,T value)
        {
            if (root == null)
            {
                Console.WriteLine("The tree is empty");
                return null;
            }
            while(root.Value.CompareTo(value) != 0)
            {
                if (root.Value.CompareTo(value) >0)
                {
                    root = root.Left;
                }
                else
                {
                    root = root.Right;
                }
                if (root == null)
                {
                    Console.WriteLine("There is no such element exist.");
                    return null;
                }
            }
            return root;
        }

        /// <summary>
        /// 二叉树查找迭代版本，无效，TODO List
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        //public TNode<T> Tree_Search(TNode<T> root, T value)
        //{
        //    if (root == null || root.Value.CompareTo(value) == 0)
        //    {            
        //        return root;
        //    }
        //    if (root.Value.CompareTo(value) > 0)
        //    {
        //        //大于根节点，往左节点迭代
        //        Tree_Search(root.Left, value);
        //    }
        //    else
        //    {
        //        Tree_Search(root.Right, value);
        //    }            
        //}

        public void Tree_Insert(TNode<T> node)
        {
            TNode<T> p = null;
            TNode<T> temp = this.Root;
            //find the insert location
            while (temp != null)
            {
                p = temp;
                if (temp.Value.CompareTo(node.Value) > 0)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            //set the insert node's parent equal to p
            node.Parent = p;
            if (p == null)
            {
                //represent the tree is empty
                this.Root = node;
            }
            else
            {
                if (p.Value.CompareTo(node.Value) >0)
                {
                    p.Left = node;
                    this.Count++;
                }
                else
                {
                    p.Right = node;
                    this.Count++;
                }
            }
        }
        public void Tree_Delete()
        {

        }

    }

}
