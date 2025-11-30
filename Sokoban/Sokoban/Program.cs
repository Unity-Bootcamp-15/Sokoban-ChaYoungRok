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
            string Wall4 = "l";
            int LineMaker = 0;
            
            for (int i = 1; i < 10; i++)
            {
                Console.SetCursorPosition(LineMaker, i);
                Console.Write($"{Wall4}");
                Console.SetCursorPosition(LineMaker+20,i);
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
    
        static  void Worldmap()
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
                int Wallx = 5;
                int Wally = 2;
                string[] WallCheck = new string[] { "★", "Λ", "☆", "-" };
                int MapSizeMax_x = 20;
                int MapSizeMax_y = 10;
                int MapSizeMin_x = 0;
                int MapSizeMin_y = 0;

                /*
                지금 구현해야할거 == 벽, 박스, 골인하기
                맵 크기 20*10
                플레이어 스타트 위치 (6,3)
                */


                Console.SetCursorPosition(Playerx, Playery);
                Console.Write("*");

                int Infinity = 1;
                while (Infinity < 5)
                {
                    Console.SetCursorPosition(0, 0);
                    StageMaker();
                    Console.SetCursorPosition(Wallx, Wally);
                    Console.Write($"{WallCheck[1]}");

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
                            if (Playery == MapSizeMax_y)
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("맵 밖으로 탈출하지 마라");
                                --Playery;
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
                            if (Playery == MapSizeMin_y)
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("맵 밖으로 탈출하지 마라");
                                ++Playery;
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
                            if (Playerx == MapSizeMax_x)
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("맵 밖으로 탈출하지 마라");
                                --Playerx;
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
                            if (Playerx == MapSizeMin_x)
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("맵 밖으로 탈출하지 마라");
                                ++Playerx;
                            }
                            break;

                        case ConsoleKey.F5:
                            Console.Clear();

                            Playerx = 5;
                            Playery = 10;
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
            }
        }
    }



