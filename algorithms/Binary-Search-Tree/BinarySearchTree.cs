using System;
using System.Collections.Generic;

namespace Binary_Search_Tree {
  public class BinarySearchTree {
    public Node Root;

    public void Print(ref Node root, int depth = 0, bool left = true) {
      string pad = new string(' ', depth * 2);

      Printer.Log(pad + root.Value, Printer.GetNodeColor(depth, left));

      if (root.Left != null)
        Print(ref root.Left, depth + 1);
      if (root.Right != null)
        Print(ref root.Right, depth + 1, false);
    }

    public Node Insert(ref Node root, int value) {
      if (root == null)
        return new Node(value);

      if (value <= root.Value)
        root.Left = Insert(ref root.Left, value);
      else
        root.Right = Insert(ref root.Right, value);

      return root;
    }

    public static bool Compare(ref Node a, ref Node b) {
      if (a == null && b == null) return true;
      if (a == null || b == null) return false;

      return a.Value == b.Value && Compare(ref a.Left, ref b.Left) && Compare(ref a.Right, ref b.Right);
    }

    public ref Node Delete(ref Node root, int value) {
      if (root != null) {
        if (value < root.Value) {
          root.Left = Delete(ref root.Left, value);
        } else if (value > root.Value) {
          root.Right = Delete(ref root.Right, value);
        } else if (root.Left == null && root.Right == null) { // Node is leaf
          root = null;
        } else if (root.Left == null || root.Right == null) { // Node has one child
          root = root.Left == null ? root.Right : root.Left;
        } else { // Node has two children
          Node min = root.Right;

          while (min.Left != null) {
            min = min.Left;
          }

          root.Value = min.Value;
          root.Right = Delete(ref root.Right, min.Value);
        }
      }

      return ref root;
    }

    public int LowestCommonAncestor(int a, int b) {
      if (a >= b) {
        throw new Exception("LCA: a must be less than b!");
      }

      Node root = Root;

      while (a > root.Value || root.Value > b) {
        root = (root.Value > b) ? root.Left : root.Right;
      }

      return root.Value;
    }

    public bool IsBST(ref Node root, int min = int.MinValue, int max = int.MaxValue) {
      if (root == null)
        return true;
      if (root.Value < min || root.Value > max)
        return false;

      return IsBST(ref root.Left, min, root.Value - 1) && IsBST(ref root.Right, root.Value + 1, max);
    }

    public void LevelOrder(ref Node root) {
      Queue<Node> list = new Queue<Node>(new[] { root });

      while (list.Count != 0) {
        Node item = list.Dequeue();

        Console.WriteLine(item.Value);

        if (item.Left != null)
          list.Enqueue(item.Left);
        if (item.Right != null)
          list.Enqueue(item.Right);
      }
    }

    public void Inorder(ref Node root) {
      if (root != null) {
        Inorder(ref root.Left);
        Console.WriteLine(root.Value);
        Inorder(ref root.Right);
      }
    }

    public void Preorder(ref Node root) {
      if (root != null) {
        Console.WriteLine(root.Value);

        Preorder(ref root.Left);
        Preorder(ref root.Right);
      }
    }

    public void Postorder(ref Node root) {
      if (root != null) {
        Postorder(ref root.Left);
        Postorder(ref root.Right);

        Console.WriteLine(root.Value);
      }
    }
  }
}
