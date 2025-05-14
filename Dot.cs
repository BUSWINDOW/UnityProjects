using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _0424_CSharp
{
    enum eDays
    {
        Sun, Mon, Tue, Wed, Tur, Fri, Sat
    }
    internal class Dot
    {
        public static void A1() 
        {
            #region 스위치문 예제
            eDays day = 0;
            Write("요일 입력 : ");
            string dayInput = Console.ReadLine();
            

            switch (dayInput)
            {
                case "일":
                    day = eDays.Sun; 
                    break;
                case "월":
                    day = eDays.Mon;
                    break;
                case "화":
                    day = eDays.Tue;
                    break;
                case "수":
                    day = eDays.Wed;
                    break;
                case "목":
                    day = eDays.Tur;
                    break;
                case "금":
                    day = eDays.Fri;
                    break;
                case "토":
                    day = eDays.Sat;
                    break;
                default:
                    WriteLine("요일 아님");
                    break;

            }

            WriteLine(day);
            #endregion

        }
        public static void A2() 
        {
      
            for (int i = 0; i < 10; i++) 
            {
                if (i == 3)
                {
                    continue;
                }
                WriteLine(i);
                if (i == 7)
                {
                    break;
                }
            }
        }
        public static void A3() 
        {
            int Input = Convert.ToInt32(ReadLine());
            //int Score = (int)(Math.Truncate(Input));
            int Score = Input / 10 * 10;
            WriteLine(Score);
            string result;
            switch (Score)
            {
                case 90:
                    result = "A";
                    break;
                case 80:
                    result = "B";
                    break;
                case 70:
                    result = "C";
                    break;
                case 60:
                    result = "D";
                    break;
                case 50:
                    result = "F";
                    break;
                default:
                    
                    result = "Error";
                    break;

            }
            WriteLine(result);


        }
        public static void A4() 
        {
            int num = 0;
            while (num < 5 || num > 10)
            {
                Write("5에서 10 사이 정수 입력 : ");
                num = int.Parse(ReadLine());
                if(num < 5 || num > 10)
                {
                    WriteLine("입력 오류");
                }
                
            }
            for (int i = 0; i < num; i++)
            {
                WriteLine(i + 1);
            }
            int a = 0;
            for (; ; )
            {
                
                WriteLine(a++ + 1);
                if (a == num)
                    break;
            }
        }
        public static void A5() 
        {
            int num = 7;
            for(int i = 1; i < 10; i++)
            {
                WriteLine($"{num} x {10 - i} = {num * (10 - i)}");
            }
        }
        public static void A6() 
        {
            #region 구구단 표시기
            for (int i = 1; i<10 ;i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    Write($"{i}x{j}={i*j}\t");
                }
                WriteLine();

            }
            #endregion
        }
        public static void A7() 
        {
            #region 역구구단 표시기
            for ( int i = 9; i > 0 ; i--)
            {
                for(int j = 9; j > 1; j--)
                {
                    Write($"{i}x{j}={i * j}\t");
                }
                WriteLine();
            }
            #endregion
        }
        public static void A8() 
        {
            for (int i = 0;i < 5 ;i++ )
            {
                for( int j = 0; j <=i ; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
        public static void A9() 
        {
            int a = 10;
            while (a > 0)
            {
                WriteLine(a--);
            }
        }
        public static void A10() 
        {
            #region 공약수 계산기
            Write("첫번째 정수 입력 : ");
            int n1 = int.Parse(ReadLine());
            Write("두번째 정수 입력 : ");
            int n2 = int.Parse(ReadLine());

            List<int> n1s = new List<int>();
            List<int> n2s = new List<int>();

            for (int i = 1;i <= n1 / 2; i++)
            {
                if(n1 % i == 0)
                {
                    n1s.Add(i);
                }
            }
            n1s.Add(n1);
            for (int i = 1; i <= n2 / 2; i++)
            {
                if (n2 % i == 0)
                {
                    n2s.Add(i);
                }
            }
            n2s.Add(n2);
            Write("첫번째 정수의 약수 : ");
            foreach(int i in n1s)
            {
                Write($"{i} ");
            }

            WriteLine();
            Write("두번째 정수의 약수 : ");
            foreach (int i in n2s)
            {
                Write($"{i} ");
            }
            List<int> com = new List<int>();
            foreach (int i in n1s)
            {
                foreach (int j in n2s)
                {
                    if(i == j)
                    {
                        com.Add(j);
                    }
                }
            }
            WriteLine();
            Write("두 수의 공약수 : ");
            foreach (int i in com)
            {
                Write($"{i} ");
            }
            #endregion
        }
        public static void A11() 
        {
            int i = 10;
            int j = 10;
            while (i-- > 1)
            {
                
                while (j-- > 1)
                { 
                    Write($"{i}x{j}={i * j}\t");
                }
                WriteLine();
                j = 10;
            }
        }
        public static void A12() 
        {
            int i = 0;
            int j = 0;
            while (i++ < 5)
            {
                j = 0;
                    while (j++ < i)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
        public static void A13() 
        {
            int total = 0;
            int num = 0;
            do
            {
                Write("정수 입력(0 입력 시 종료) : ");
                num = int.Parse(ReadLine());
                total += num;
            } while (num != 0);
            WriteLine($"숫자들의 합 : {total}");
        }
        public static void A14() 
        {
            int i = 10;
            do
            {
                WriteLine();
            } while (i-- == 0);
        }
        public static void A15() 
        {
            Write("숫자 입력 : ");
            int Cnt = int.Parse(ReadLine());
            for(int i = 0; i < Cnt; i++)
            {
                WriteLine("Hello World");
            }
        }
        public static void A16() 
        {
            Write("숫자 입력 : ");
            int Cnt = int.Parse(ReadLine());
            for (int i = 1;i <= Cnt; i++)
            {
                WriteLine($"{i} x 3 = {3 * i}");
            }
        }
        public static void A17() 
        {
            int total = 0;
            int num = 0;
            do
            {
                Write("정수 입력(0 입력 시 종료) : ");
                num = int.Parse(ReadLine());
                total += num;
            } while (num != 0);
            WriteLine($"숫자들의 합 : {total}");
        }
        public static void A18() 
        {
            Write("숫자 입력 : ");
            int Cnt = int.Parse(ReadLine());
            for (int i = 9; i > 0; i--)
            {
                WriteLine($"{i} x {Cnt} = {Cnt * i}");
            }
        }
        public static void A19() 
        {
            Write("몇개의 숫자를 입력할건지 입력 : ");
            int Cnt = int.Parse(ReadLine());
            float Total = 0;
            for (int i = 0; i < Cnt; i++)
            {
                Write("숫자 입력 : ");
                Total += int.Parse(ReadLine());
            }
            WriteLine($"숫자들의 평균 : {Total / Cnt}");
        }
        public static void A20() 
        {
            int Total = 0;
            int num = 0;
            for (int i = 0;i < 5; i++)
            {
                do
                {
                    Write("숫자 입력(반드시 1 이상) : ");
                    num = int.Parse(ReadLine());
                    if (num < 1)
                    {
                        WriteLine("반드시 1 이상인 숫자 입력");
                        continue;
                    }
                    else
                    {
                        Total += num;
                    }
                } while (num < 1);
                
            }
            WriteLine($"총합 : {Total}");
        }
        public static void A21() 
        {
            for (int i = 0; i < 5 ; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write("o");
                }
                Write("*\n");
            }
        } 
        public static void A22() { }

    }
}
