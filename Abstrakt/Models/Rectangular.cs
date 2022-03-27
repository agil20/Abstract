using System;

namespace Abstrakt.Models
{
    internal class Rectangular:Figure
    {//Bir Rectangular class-ı olur width və length deyə property-ləri olacaq, width və length mənfi ola bilməz.
        private int _width;
        private int _height;
        public int Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                {
                    _width = value;

                }
                else
                {
                    Console.WriteLine("musbet olmalidir");
                }
            }
        }
        public int Length
        {
            get { return _height; }

            set
            {
                if (value > 0)
                {
                    _height = value;

                }
                else
                {
                    Console.WriteLine("musbet olmalidir");
                }
            }
        }


        //   Width və length dəyərləri təyin olunmamış Rectangular obyekti yaradıla bilməz.
        public Rectangular(int width,int length)
        {
            Width = width;
            Length = length;
        }

        public override void CalcArea()
        {
            int z = Length * Width;
            Console.WriteLine("Sahesi : "+   z);
        }
        //  Rectangular class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

    }
}

