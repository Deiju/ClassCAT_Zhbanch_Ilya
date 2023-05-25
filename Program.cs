using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_классами_Консоль_
{
    class Program
    {
        static void Main (string [ ] args)
        {
            CAT murzik = new CAT("Мурзик",13);
            CAT barsik = new CAT("Барсик",20);
            barsik.Weight = 0;
            murzik.Weight = -65;
            barsik.Name = "Барс1";
            murzik.Name = "Мурз2";
            murzik.Meow( );
            barsik.Meow( );
            Console.ReadLine( );
        }
    }
}
