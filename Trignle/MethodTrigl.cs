using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trignle
{
    internal class MethodTrigl
    {
        int a, b, c;
        public int Proverka(string numb)
        {
            try
            {
                int num = Convert.ToInt32(numb);
                if (num != 0 && num > 0 && num < 1000)
                {
                    return num;
                }else 
                    return 0;

            }
            catch (FormatException) { return 0; }

        }
        public string Treug(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
            {
                return "Треугольника с такими сторонами не существует!!!";
            }
            if (a == b && a == c && b == c)
            {
                return "Треугольник равносторонний!";
            }
            if (((a * a) == (b * b) + (c * c)) || ((b * b) == ((a * a) + (c * c)) || ((c * c) == (b * b) + (a * a))))
            {
                return "Треугольник прямоугольный!";
            }
            if ((a == b && a != c) || (b == c && b != a) || (a == c && a != b))
            {
                return "Треугольник равнобедренный!";
            }
            return "Треугольник разносторонний!";
        }
    }
}
