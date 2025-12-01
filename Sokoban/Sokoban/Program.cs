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

                Console.SetCursorPosition(Playerx, Playery);
                Console.Write("*");


                int Infinity = 1; //그냥 와일문에 트루 박으셈. 이거 코드장난임. == 쓰레기코드라는뜻
            while (Infinity < 5)
            {
                Console.SetCursorPosition(0, 0);
                StageMaker();

                for (DoubleMaker = 0; DoubleMaker < 5; DoubleMaker+=DoubleMakerSub1)
                {
                    Console.SetCursorPosition(Wallx+DoubleMaker, Wally+DoubleMaker);
                    Console.Write($"{WallCheck[1]}");
                }
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

                        if (Playery == (Wally + (DoubleMakerSub1)) && Playerx == Wallx+DoubleMakerSub1)
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
                            if((Wallx + DoubleMakerSub1) == Boxx && (Wally +DoubleMakerSub1) == Boxy)
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

                        if (Playery == (Wally + (DoubleMakerSub1)) && Playerx == Wallx + DoubleMakerSub1)
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
                                if ((Wallx + DoubleMakerSub1) == Boxx && (Wally + DoubleMakerSub1) == Boxy)
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

                              if (Playerx == (Wallx+DoubleMakerSub1) && Playery == (Wally+DoubleMakerSub1))
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
                                 if (Boxx == (Wallx+DoubleMakerSub1) && Boxy == (Wally+DoubleMakerSub1))
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

                        if (Playerx == (Wallx + DoubleMakerSub1) && Playery == (Wally + DoubleMakerSub1))
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
                                if (Boxx == (Wallx + DoubleMakerSub1) && Boxy == (Wally + DoubleMakerSub1))
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
                    Infinity++;
                    Infinity--;
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