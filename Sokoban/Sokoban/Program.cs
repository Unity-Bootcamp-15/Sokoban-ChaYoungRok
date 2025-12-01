using System;

namespace Sokoban
{

    internal class Program
    {
       static void StageMakerSub2()
        {
            string Wall1 = "★";
            string Wall2 = "Λ";
            string Wall3 = "☆";
            string Wall4 = "-";
            for (int i = 0; i < 20; i++)
            {
                Console.Write(Wall4);
            }
        }
       static void StageMakerSub1()
        {
            string Wall1 = "★";
            string Wall2 = "Λ";
            string Wall3 = "☆";
            string Wall4 = "|";
            int LineMaker = 0;

            for (int i = 1; i < 10; i++)
            {
                Console.SetCursorPosition(LineMaker, i);
                Console.Write($"{Wall4}");
                Console.SetCursorPosition(LineMaker + 20, i);
                Console.WriteLine($"{Wall4}");
            }
        }
       static void StageMaker()
        {
            string Wall1 = "★";
            string Wall2 = "Λ";
            string Wall3 = "☆";
            string Wall4 = "-";
            Random CanMoveWall = new Random();
            Random DontMoveWall = new Random();

            StageMakerSub2();
            StageMakerSub1();
            StageMakerSub2();

        }
       static void Worldmap()
            {

                int WorldMake = int.Parse(Console.ReadLine());

                if (WorldMake == 1)
                {
                    Console.WriteLine();
                }

            }

            static void Main(string[] args)
            {
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Title = "Sokaban!!!";
                Console.CursorVisible = false;
                Console.Clear();

                int Playerx = 1;
                int Playery = 1;
                int Wallx = 6;
                int Wally = 3;
                string[] WallCheck = new string[] {"★", "Λ", "☆"};
                int MapSizeMax_x = 20;
                int MapSizeMax_y = 10;
                int MapSizeMin_x = 0;
                int MapSizeMin_y = 0;
                int Goalx = 15;
                int Goaly = 7;
                int Boxx = 7;
                int Boxy = 4;
                int DoubleMaker = 0;
                int DoubleMakerSub1 = 3;
                Random RandomWallmaker = new Random();
                int[] ToMantyWallx = new int[] {9,10,11};
                int[] ToMantyWally = new int[] {4,1,3};

            Console.SetCursorPosition(Playerx, Playery);
                Console.Write("*");


            bool Infinity = true;
            while (Infinity)
            {
                Console.SetCursorPosition(0, 0);
                StageMaker();

                Console.SetCursorPosition(Wallx, Wally);
                Console.WriteLine(WallCheck[1]);

                //for(int i =0; , i<3; i++)
                Console.SetCursorPosition(ToMantyWallx[0], ToMantyWally[0]);
                Console.WriteLine(WallCheck[1]);

                    if (Goalx == Boxx && Goaly == Boxy)
                    {
                        Console.SetCursorPosition(Boxx, Boxy);
                        Console.Write($"{WallCheck[0]}");
                        Console.SetCursorPosition(0, 21);
                        Console.Write("clear");

                        break;
                    }
                    else
                    {
                        Console.SetCursorPosition(Goalx, Goaly);
                        Console.Write($"{WallCheck[2]}");
                    }
                
                    Console.SetCursorPosition(Boxx, Boxy);
                    Console.Write($"{WallCheck[0]}");

                    ConsoleKeyInfo Input = (Console.ReadKey(true));

                    switch (Input.Key)
                    {
                        case ConsoleKey.DownArrow:

                        Console.Clear();
                        ++Playery;
                        if (Playery == Wally && Playerx == Wallx)
                        {
                            Console.SetCursorPosition(0, 21);
                            Console.Write("충돌함");
                            --Playery;
                        }

                        if(Playery == ToMantyWally[0] && Playerx == ToMantyWallx[0])
                        {
                            Console.SetCursorPosition(0, 21);
                            Console.Write("충돌함");
                            --Playery;
                        }

                        if (Playery == MapSizeMax_y)
                        {
                            Console.SetCursorPosition(0, 21);
                            Console.Write("맵 밖으로 탈출하지 마라");
                            --Playery;
                        }

                        if (Playery == Boxy && Playerx == Boxx)
                        {
                            ++Boxy;
                            if (Boxy == MapSizeMax_y)
                            {
                                --Boxy;
                            }
                            if (Wallx == Boxx && Wally == Boxy)
                            {
                                --Boxy;
                            }
                            if (ToMantyWallx[0] == Boxx && ToMantyWally[0] == Boxy)
                            {
                                --Boxy;
                            }

                            if (Playery == Boxy && Playerx == Boxx)
                            {
                                --Playery;
                            }

                            Console.SetCursorPosition(Boxx, Boxy);
                            Console.Write($"{WallCheck[2]}");
                        }

                        break;

                        case ConsoleKey.UpArrow:

                            Console.Clear();
                            --Playery;

                            if (Playery == Wally && Playerx == Wallx)
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("충돌함");
                                ++Playery;
                            }

                             if (Playery == ToMantyWally[0] && Playerx == ToMantyWallx[0])
                               {
                                  Console.SetCursorPosition(0, 21);
                                  Console.Write("충돌함");
                                 ++Playery;
                                }
                        if (Playery == MapSizeMin_y)
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("맵 밖으로 탈출하지 마라");
                                ++Playery;
                            }

                            if (Playery == Boxy && Playerx == Boxx)
                            {

                                --Boxy;
                                if (Boxy == MapSizeMin_y)
                                {
                                    ++Boxy;
                                }
                                if (Boxy == Wally && Boxx == Wallx)
                                {
                                    ++Boxy;
                                }
                              if (Boxy == ToMantyWally[0] && Boxx == ToMantyWallx[0])
                                  {
                                     ++Boxy;
                                  }
                                 if (Playery == Boxy && Playerx == Boxx)
                                 {
                                    ++Playery;
                                  }
                                Console.SetCursorPosition(Boxx, Boxy);
                                Console.Write($"{WallCheck[2]}");
                            }
                            break;

                        case ConsoleKey.RightArrow:

                            Console.Clear();
                            ++Playerx;
                            if (Playerx == Wallx && Playery == Wally)
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("충돌함");
                                --Playerx;
                            }

                        if (Playerx == ToMantyWallx[0] && Playery == ToMantyWally[0])
                            {
                            Console.SetCursorPosition(0, 21);
                            Console.Write("충돌함");
                            --Playerx;
                            }
                              if (Playerx == MapSizeMax_x)
                              {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("맵 밖으로 탈출하지 마라");
                                --Playerx;
                              }

                            if (Playery == Boxy && Playerx == Boxx)
                            {
                                ++Boxx;
                                if (Boxx == MapSizeMax_x)
                                {
                                    --Boxx;
                                }
                                if (Boxx == Wallx && Boxy == Wally)
                                {
                                    --Boxx;
                                }
                                if(Boxx == ToMantyWallx[0] && Boxy == ToMantyWally[0])
                                 {
                                --Boxx;
                                  }
                            if (Playery == Boxy && Playerx == Boxx)
                                {
                                    --Playerx;
                                }
                                Console.SetCursorPosition(Boxx, Boxy);
                                Console.Write($"{WallCheck[2]}");
                            }

                            break;

                        case ConsoleKey.LeftArrow:

                            Console.Clear();
                            --Playerx;
                            if (Playerx == Wallx && Playery == Wally)
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("충돌함");
                                ++Playerx;
                            }

                            if (Playerx == ToMantyWallx[0] && Playery == ToMantyWally[0])
                            {
                            Console.SetCursorPosition(0, 21);
                            Console.Write("충돌함");
                            ++Playerx;
                            }

                        if (Playerx == MapSizeMin_x)
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("맵 밖으로 탈출하지 마라");
                                ++Playerx;
                            }

                            if (Playery == Boxy && Playerx == Boxx)
                            {
                                --Boxx;
                                if (Boxx == MapSizeMin_x)
                                {
                                    ++Boxx;
                                }
                                if (Boxx == Wallx && Boxy == Wally)
                                {
                                    ++Boxx;
                                }
                               
                                if(Boxx == ToMantyWallx[0] && Boxy == ToMantyWally[0])
                                {
                                ++Boxx; 
                                }

                            if (Playery == Boxy && Playerx == Boxx)
                                {
                                    ++Playerx;
                                }
                                Console.SetCursorPosition(Boxx, Boxy);
                                Console.Write($"{WallCheck[2]}");

                            }

                            break;

                        case ConsoleKey.F5:
                            Console.Clear();

                            Playerx = 1;
                            Playery = 1;
                            Boxx = 7;
                            Boxy = 4;

                            break;
                    }
                    
                    
                    Console.SetCursorPosition(Playerx, Playery);
                    Console.WriteLine("*");


                    if (Input.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                }
                while (true)
                {
                }
            }
     }
 }