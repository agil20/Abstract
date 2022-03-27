using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakt.Models
{
    abstract class Figure
    {         //Bir Figure abstrakt class-ı olur və onun Figure-dan miras alan zaman mütləq override edilməsi lazım olan bir CalcArea methodu olur.
        abstract public void CalcArea();
    }
}
