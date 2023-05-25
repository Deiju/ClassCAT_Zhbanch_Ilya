using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_классами_Консоль_
{
    class CAT
    {
        public CAT (string CatName, double weight)
        {
            Name=CatName;
            Weight = weight;
        }
        public void Meow ()
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!! И его вес:{weight}");
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                bool OnlyLetters = true;
                foreach ( var ch in value )
                {
                    if ( !char.IsLetter(ch) )
                    {
                        OnlyLetters = false;
                    }
                }

                if ( OnlyLetters )
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        private double weight;
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {   
                if (!(value<=0))
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine($"{value}: не может быть нулевой или отрицательный вес");
                }
            }
        }
    }
}
