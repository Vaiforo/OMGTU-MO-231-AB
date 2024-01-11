using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moloko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество фирм: ");
            int n = int.Parse(Console.ReadLine());
            float v1, v2, s1, s2, price;
            double min = 9999999;
            int n_firmi = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Введите данные фирмы номер {i + 1}: ");
                string line = Console.ReadLine();
                string[] str = line.Split(' ');
                float x1 = float.Parse(str[0]);
                float y1 = float.Parse(str[1]);
                float z1 = float.Parse(str[2]);
                float x2 = float.Parse(str[3]);
                float y2 = float.Parse(str[4]);
                float z2 = float.Parse(str[5]);
                float c1 = float.Parse(str[6]);
                float c2 = float.Parse(str[7]);
                v1 = (x1 * y1 * z1);
                v2 = (x2 * y2 * z2);
                s1 = 2 * (x1 * y1 + y1 * z1 + x1 * z1);
                s2 = 2 * (x2 * y2 + y2 * z2 + x2 * z2);
                price = (c1 - c2 * s1 / s2) / (v1 - v2 * s1 / s2) * 1000;
                if (price < min)
                {
                    min = price;
                    n_firmi = i;
                }
            }
            min = Math.Round(min, 2);
            Console.WriteLine("Ответ: " + n_firmi + " " + min);
        }
    }
}