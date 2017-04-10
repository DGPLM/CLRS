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

        /// <summary>
        /// return the minimum node in tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TNode<T> Tree_Minimum(TNode<T> root)
        {
            if (root == null)
            {
                Console.WriteLine("The given node is empty.");
                return null;
            }
            while (root.Left != null)
            {
                root = root.Left;
            }
            return root;
        }
        /// <summary>
        /// return the maximum node in tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TNode<T> Tree_Maximum(TNode<T> root)
        {
            if (root == null)
            {
                Console.WriteLine("The given node is empty.");
                return null;
            }
            while (root.Right != null)
            {
                root = root.Right;
            }
            return root;
        }

        /// <summary>
        /// return current node's successor node 
        /// 返回当前节点的后续节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public TNode<T> Tree_Successor(TNode<T> node)
        {
            if (node.Right != null) //两种情况，第一种情况，右子树不为空，则查找右子树最小值
            {
                return Tree_Minimum(node.Right);
            }
            else //第二种情况，右子树为空，则查找到父结点且父结点的左节点为当前结点时跳出，此时父节点为后继结点
            {
                TNode<T> p = node.Parent;
                while (p != null && node == p.Right)
                {
                    node = p;
                    p = p.Parent;
                }
                return p;
            }
        }
        /// <summary>
        /// return
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public TNode<T> Tree_PreDecessor(TNode<T> node)
        {
            if (node.Left != null) //两种情况，第一种情况，左子树不为空，则查找左子树最大值
            {
                return Tree_Maximum(node.Left);
            }
            else //第二种情况，左子树为空，则查找到父结点且父结点的右结点为当前结点时跳出，此时父节点为前继结点
            {
                TNode<T> p = node.Parent;
                while (p!= null && node == p.Left)
                {
                    node = p;
                    p = p.Parent;
                }
                return p;
            }
        }
        public TNode<T> Tree_Delete(TNode<T> node)
        {
            TNode<T> tempy = null;
            TNode<T> tempx = null;
            if (node.Left == null || node.Right == null) //第一个if，确定要删除的结点，是当前结点还是当前结点的后继结点
            {
                tempy = node;
            }
            else //第三种情况，结点含有两个子树，获取删除结点的后继结点
            {
                tempy = Tree_Successor(node);
            }
            if (tempy.Left != null) 
            {
                tempx = tempy.Left;
            }
            else
            {
                tempx = tempy.Right;
            }
            if (tempx != null)
            {
                tempx.Parent = tempy.Parent; //第一种情况，删除结点只含一个子树，将删除结点的子树与删除结点的父结点连接
            }
            if (tempy.Parent == null)
            {
                this.Root = node; 

            }
            else if (tempy == tempy.Parent.Left)
            {
                tempy.Parent.Left = tempx;
            }
            else if (tempy == tempy.Parent.Right)
            {
                tempy.Parent.Right = tempx;
            }
            if (tempy != node)
            {
                node.Value = tempy.Value;
            }
            return tempy;

        }

    }

}
