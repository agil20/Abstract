using System;

namespace Abstrakt.Models
{
    internal class Square:Figure
    {
        // Bir Square class-ı olur side deyə bir property-i olur və side mənfi ola bilməz.
        private int _side;
        public int Side
        {
            get { return _side; }

            set
            {
                if (value>0) //boyukdur 0 ediremki kvardatin teefi 0 ola bilmez
                {
                   _side=value;
                }
                else
                {
                    Console.WriteLine("kvadratin terefi 0 dan boyuk olmadlidir");
                }

            }
        }
        //Side dəyəri təyin olunmamış Square obyekti yaradıla bilməz.
        public Square(int side)
        {
            Side = side;
        }

        public override void CalcArea()
        {
            int s= Side * Side;
            Console.WriteLine("sahesi: "+ s);
        }
        //Square class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.
    }
    
}
