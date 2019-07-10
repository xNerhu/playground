using System;

namespace FizzBuzz {
  class Program {
    static void Main(string[] args) {
      int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
      string str = "";

      for (int i = 0; i < list.Length; i++) {
        if (list[i] % 15 == 0) {
          str = "fizz buzz";
        } else if (list[i] % 3 == 0) {
          str = "fizz";
        } else if (list[i] % 5 == 0) {
          str = "buzz";
        }

        Console.WriteLine(string.Format("{0} {1}", list[i], str));
      }

      Console.ReadLine();
    }
  }
}
