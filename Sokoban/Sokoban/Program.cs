namespace Sokoban
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Sokaban!!!";
            Console.CursorVisible = false;
            Console.Clear();
            int x = 5;
            int y = 10;
            int wall_x = 1;
            int wall_y = 1;
            string [] wall =  new string[]{"@","Λ",">","<","v"};

            Console.SetCursorPosition(x,y);
            Console.Write("*");
            
            int Infinity = 1;
            while (Infinity<5)
            {
                Console.SetCursorPosition(wall_x, wall_y);
                Console.Write($"{wall[1]}");
                ConsoleKeyInfo Input = (Console.ReadKey(true));

                switch (Input.Key)
                {
                    case ConsoleKey.DownArrow:

                        Console.Clear();
                        ++y;
                        break;

                    case ConsoleKey.UpArrow:

                        Console.Clear();
                        --y;
                        if (y == 0)
                        {
                            y++;
                        }
                        break;

                    case ConsoleKey.RightArrow:

                        Console.Clear();
                        ++x;

                        break;
                    case ConsoleKey.LeftArrow:

                        Console.Clear();
                        --x;
                        if (x == 0)
                        {
                            x++;
                        }

                        break;

                    case ConsoleKey.F5:
                        Console.Clear();

                        x = 5;
                        y = 10;

                        break;

                }

                Infinity++;
                Infinity--;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("*");

                if (Input.Key == ConsoleKey.Escape)
                {
                    break;
                }

                /*
                    if (Input.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(" ");
                        ++y;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("*");
                    }
                    else if (Input.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(" ");
                        --y;
                       if(y == 0)
                        {
                            y++;
                        }
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("*");
                    }
                    else if (Input.Key == ConsoleKey.RightArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(" ");
                        ++x;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("*");
                    }
                    else if (Input.Key == ConsoleKey.LeftArrow)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(" ");
                        --x;
                       if(x==0)
                        {
                            x++; 
                        }
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("*");
                    }

                */

            }
        }
    }
}
