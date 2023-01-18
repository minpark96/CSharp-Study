using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 데이터 + 로직
            // 체력 0

            // 0b11111111 = 255
            // byte(1바이트 0~255), short(2바이트 -3만~3만), int(4바이트 -21억~21억), long(8바이트)
            // sbyte(1바이트, -128~127, ushort(2바이트, 0~6만, uint(4바이트 0~43억, ulong(8바이트)
            //int hp;
            //short level = 100;
            //long id;
            //hp = 100;

            //byte attack = 0;
            //attack--;

            // 10진수
            // 0 1 2 3 4 5 6 7 8 9
            // 10

            // 2진수
            // 0~1
            // 0b00 0b01 0b10 0b11 0b100
            // 0b10001111 = 0x8F

            // 16진수
            // 0~9 a b c d e f
            // 0x00 0x01 0x02 .. 0x0F
            // 0x10

            // 1바이트(참/거짓)
            bool b;
            b = true;
            b = false;

            // 소수
            // 4바이트
            float f = 3.14f;
            // 8바이트
            double d = 3.14;

            // 2바이트
            char c = 'a';
            string str = "Hello World";

            Console.WriteLine(str);



            //Console.WriteLine("Hello Number ! {0}", hp);
        }
    }
}
