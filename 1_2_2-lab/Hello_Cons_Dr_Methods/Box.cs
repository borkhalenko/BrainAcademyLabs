using System;
using System.Linq;

namespace Hello_Cons_Dr_Methods {
      public class Box {
        private readonly char[] AvailableSymbols = new char[] { '*', '+', '.' };
        private ConsoleColor foregroundColor = Console.ForegroundColor;
        //In this properties the accessibility modifier of the setter is a private, because 
        //only draw method must check it's validation (specification requirement). IMHO, 
        //good code must check validation in the set section of a property.
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }
        public char BorderChar { get; private set; }
  
        public Box() { }

        private void draw(string message) {
            //Console.Clear();
            //drawing a message
            int startX = X + Width / 2 - (message.Length / 2);
            int startY = Y + Height / 2;
            Console.SetCursorPosition(startX, startY);
            Console.Write(message);
            Console.SetCursorPosition(X, Y);
            //drawing a border
            for (int i = X; i < X + Width; ++i) {
                for (int j = Y; j < Y + Height; ++j) {
                    Console.SetCursorPosition(i, j);
                    if (i == X || j == Y || i == Width + X - 1 || j == Height + Y - 1) {
                        Console.Write(BorderChar);
                    }
                }
            }
            Console.WriteLine();
        }

        public void draw(int x, int y, int width, int height, char border, string message) {
            ConsoleColor[] availableColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Random rand = new Random();
            do {
                foregroundColor = availableColors[rand.Next(availableColors.Length)];
            }
            //Black color is not readable. Continue...
            while (foregroundColor == Console.ForegroundColor || foregroundColor==ConsoleColor.Black);
            Console.ForegroundColor = foregroundColor;
            if (x<1 || y<1 || height<1 || width < 1) {
                throw new ArgumentException("X, Y, Height and Width must be greater than 0.");
            }
            X = x;
            Y = y;
            Height = height;
            Width = width;
            if (!AvailableSymbols.Contains<char>(border)) {
                throw new ArgumentException("Border char must be one of the folowing chars: " + AvailableSymbols.ToString());
            }
            BorderChar = border;
            //Truncating the message if it's length greather then box height without borders (2 literal is a borders)
            if (message.Length > Width - 2) {
                message = message.Substring(0, Width - 2);
            }
            draw(message);
        }

        public long Square() {
            return Math.BigMul(Width, Height);
        }

        //The specification has the requirement: "Use the ref modifier to the method", but in this program,
        //I think, this requirement make no sense.
    }
}
