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

                int MapSizeMax_x = 20;
                int MapSizeMax_y = 10;
                int MapSizeMin_x = 0;
                int MapSizeMin_y = 0;
                int Playerx = 1;
                int Playery = 1;
                int Goalx = 15;
                int Goaly = 7;
                int Boxx = 7;
                int Boxy = 4;
                int DoubleMaker = 0;
                int DoubleMakerSub1 = 3;
                int[] Wallx = new int[] {2,6,9,11};
                int[] Wally = new int[] {2,3,5,9};
                int[] InTellepoterx = new int[] {1,19};
                int[] InTellepotery = new int[] {9,1};
                int[] OutTellepoterx = new int[] {19,1};
                int[] OutTellepotery = new int[] {1,9};
            int Wallcountx = Wallx.Length;
                int Wallcounty = Wally.Length;
                string[] WallCheck = new string[] {"★", "Λ", "☆", "△", "▲"};
                Random Randomteleport = new Random();
                bool Infinity = true;

                Console.SetCursorPosition(Playerx, Playery);
                Console.Write("*");

            while (Infinity)
            {
                Console.SetCursorPosition(0, 0);
                StageMaker();

                Console.SetCursorPosition(1, 9);
                Console.WriteLine(WallCheck[3]);
                Console.SetCursorPosition(19, 1);
                Console.WriteLine(WallCheck[4]);

                for (int i = 0; i < Wallcountx; i++)
                {
                    Console.SetCursorPosition(Wallx[i], Wally[i]);
                    Console.WriteLine(WallCheck[1]);
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

                        for (int i = 0; i < Wallcountx; i++)
                        {
                            if (Playery == Wally[i] && Playerx == Wallx[i])
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("충돌함");
                                --Playery;
                            }
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
                            for (int i = 0; i < Wallcountx; i++)
                            {
                                if (Wallx[i] == Boxx && Wally[i] == Boxy)
                                {
                                    --Boxy;
                                }
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

                        for (int i = 0; i < Wallcountx; i++)
                        {
                            if (Playery == Wally[i] && Playerx == Wallx[i])
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("충돌함");
                                ++Playery;
                            }
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
                            for (int i = 0; i < Wallcountx; i++)
                            {
                                if (Boxy == Wally[i] && Boxx == Wallx[i])
                                {
                                    ++Boxy;
                                }
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

                        for (int i = 0; i < Wallcountx; i++)
                        {
                            if (Playerx == Wallx[i] && Playery == Wally[i])
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
                        }
                        if (Playery == Boxy && Playerx == Boxx)
                        {
                            ++Boxx;
                            if (Boxx == MapSizeMax_x)
                            {
                                --Boxx;
                            }
                            for (int i = 0; i < Wallcountx; i++)
                            {
                                if (Boxx == Wallx[i] && Boxy == Wally[i])
                                {
                                    --Boxx;
                                }
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

                        for (int i = 0; i < Wallcountx; i++)
                        {
                            if (Playerx == Wallx[i] && Playery == Wally[i])
                            {
                                Console.SetCursorPosition(0, 21);
                                Console.Write("충돌함");
                                ++Playerx;
                            }
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
                            for (int i = 0; i < Wallcountx; i++)
                            {
                                if (Boxx == Wallx[i] && Boxy == Wally[i])
                                {
                                    ++Boxx;
                                }
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

                    case ConsoleKey.T:

                        if (Playerx == InTellepoterx[0] && Playery == InTellepotery[0])
                        {
                            Console.Clear();
                            Playerx = OutTellepoterx[0];
                            Playery = OutTellepotery[0];
                            Console.SetCursorPosition(Playerx, Playery);
                            Console.WriteLine("*");
                            Console.SetCursorPosition(0, 21);
                            Console.WriteLine("전송완료");

                            break;
                        }

                        if (Playerx == OutTellepoterx[0] && Playery == OutTellepotery[0])
                        {

                            Console.SetCursorPosition(0, 21);
                            Console.WriteLine("해당 텔레포터는 단방향 전송만 가능합니다.");
                            Console.WriteLine("이쪽은 출구이므로 입구를 찾아주시기 바랍니다.");
                        }

                        if (Boxx == OutTellepoterx[0] && Boxy == OutTellepotery[0])
                        {
                            Console.SetCursorPosition(0, 21);
                            Console.WriteLine("해당 텔레포터는 단방향 전송만 가능합니다.");
                            Console.WriteLine("이쪽은 출구이므로 입구를 찾아주시기 바랍니다.");
                            Console.WriteLine("또한 박스는 해당 텔레포터 입구에 두면 자동으로 작동되며 무작위로 전송됩니다.");
                            Console.WriteLine("절대 텔레포터의 입구에 박스를 옮기지 마십시오.");
                            Console.WriteLine("잘 이해했을거라 믿겠습니다. 관리자 나으리.");
                        }

                        break;
                }

                Console.SetCursorPosition(Playerx, Playery);
                Console.WriteLine("*");


                if (Input.Key == ConsoleKey.Escape)
                {
                    break;
                }

                if (Boxx == InTellepoterx[0] && Boxy == InTellepotery[0])
                {
                    Console.SetCursorPosition(InTellepoterx[0], InTellepotery[0]);
                    Console.WriteLine(WallCheck[3]);

                    Console.SetCursorPosition(0, 21);
                    Console.WriteLine("저런....해당 텔레포트는 오직 사람만 수동으로 옮길 수 있는 미완성이였군요.");
                    Console.WriteLine("심지어 박스가 올라가면 자동으로 물건이 미지의 공간으로 사라지는군요!");
                    Console.WriteLine("누가 이런걸 여기에 배치했는지는 모르겠지만, 아무튼 당신이 박스를 이곳으로 옮긴 사람이죠.");
                    Console.WriteLine("그러게 누가 일하는데 메뉴얼도 안읽고 업무투입을 하랬습니까?");
                    Console.WriteLine("축하합니다! 당신은 해고입니다!");

                    break;
                }

            }
                while (true)
                {
                }
            }
     }
 }