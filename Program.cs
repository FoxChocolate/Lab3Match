using System;

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

            Console.WriteLine(t1);
            Console.WriteLine(tall);
            Console.ReadKey();
        }
    }
}
