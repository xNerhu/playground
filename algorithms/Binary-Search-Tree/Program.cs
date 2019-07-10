using System;

namespace Binary_Search_Tree {
  class Program {
    static void Main(string[] args) {
      var tree = new BinarySearchTree() {
        Root = new Node(1) {
          Left = new Node(2) {
            Left = new Node(4),
            Right = new Node(5),
          },
          Right = new Node(3),
        }
      };

      Console.WriteLine("\n\n");
      tree.Print(ref tree.Root);

      Console.ReadLine();
    }
  }
}
