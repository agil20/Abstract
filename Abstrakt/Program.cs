using System;
using Abstrakt.Models;

namespace Abstrakt
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            //  Program class-ında bir menu olacaq
            //1. Square
            //2. Rectangular
            //0. Quit

            //İstifadəçi 1 yazıb enter-ə click-ləsə Square-in CalcArea methodu işə düşməlidir.
            //İstifadəçi 2 yazıb enter-ə click-ləsə Rectangular-in CalcArea methodu işə düşməlidir.
            //İstifadəçi 0 yazıb enter-ə click-ləsə proqram sonlanmalıdı.
            Console.WriteLine("1.Square " +
                " 2.Rectanguler" +
                " 3.Quit\n"+
                "Zehmet olmasa birini secin");
            int a;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("zehmet olmasa terefi yazin"); int side=Convert.ToInt32(Console.ReadLine()); 
                        Square square1=new Square(side);

                        square1.Side = side;
                        square1.CalcArea(); break;
                    case 2:
                        Console.WriteLine("zehmet olmasa terefleri qeyd edin");
                        int width=Convert.ToInt32(Console.ReadLine());
                        int length=Convert.ToInt32(Console.ReadLine());
                        Rectangular rectanguler1 = new Rectangular(width, length);
                       rectanguler1.Width = width;
                        rectanguler1.Length = length;
                        rectanguler1.CalcArea(); break;
                    case 0: return;
                }

            } while (a != 1&& a!=2 &&a!=3);


             
} } }