using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metrixmove
{
    class Program
    {
        static void print(char[,] M)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write(M[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            char[,] m = new char[10, 10];
            int x = 0;
            int y = 0;

            //맵생성
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = '□';
                }
            }
            //맵업데이트
            print(m);

            //키설정
            while (true)
            {
                //전위증감연산자 vs 후위증감연산자 
                //++x = 변수 값을 미리 증감한 후 나머지 연산을 수행.   [1,1] = 빈 상자 ->  [1,2] +1증감 -> [1,2] = 검은 상자
                //x++ = 연산식(대입)을 먼저 실행한 후 나중에 변수 값을 증감합니다. [1,1] = 빈 상자 -> [1,1] = 검은 상자 -> [1,2] +1증감

                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로올라갑니다");
                        m[x, y] = '□';
                        m[--x, y] = '■';        

                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 내려갑니다.");
                        m[x, y] = '□';
                        m[++x, y] = '■';
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 갑니다");
                        m[x, y] = '□';
                        m[x, --y] = '■';
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로갑니다.");
                        m[x, y] = '□';
                        m[x, ++y] = '■';
                        break;
                    default:
                        Console.WriteLine("화살표키가 아닙니다. 다시 입력해주세요.");
                        break;

                }
                //맵클리어
                Console.Clear();
                //맵업데이트
                print(m);

            }
        }
    }
}
