﻿using System;

namespace MathLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, q, z, t, t1, tall;
            const char simv = 'E';
            Console.Write("Введите a:");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите q:");
            q = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите z:");
            z = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите t:");
            t = Convert.ToSingle(Console.ReadLine());

            t1 = (35 / a) * z + z * a - (a + simv * t) / 4;

            tall = t1 * q;

            int pnumber = Convert.ToInt32(tall);

            Console.WriteLine("Ответ C: {0:C}", pnumber);
            Console.WriteLine("Ответ D: {0:D}", pnumber);
            Console.WriteLine("Ответ E: {0:E}", pnumber);
            Console.WriteLine("Ответ F: {0:F}", pnumber);
            Console.WriteLine("Ответ G: {0:G}", pnumber);
            Console.WriteLine("Ответ N: {0:N}", pnumber);
            Console.WriteLine("Ответ P: {0:P}", pnumber);
            Console.ReadKey();
        }
    }
}
