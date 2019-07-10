using System;

using Color = System.ConsoleColor;

namespace Binary_Search_Tree {
  public static class Printer {
    static Color NodeRootColor = Color.Red;

    static Color NodeLeftColor = Color.Green;

    static Color NodeRightColor = Color.Cyan;

    public static void Log(string text, Color color) {
      Console.ForegroundColor = color;
      Console.WriteLine(text);
      Console.ResetColor();
    }

    public static Color GetNodeColor(int depth, bool left) {
      if (depth == 0) return NodeRootColor;
      return left ? NodeLeftColor : NodeRightColor;
    }
  }
}
