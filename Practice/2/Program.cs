using System;
using System.Runtime.Intrinsics.Arm;

public class MainClass
{
    public static void Main()
    {
        int out1 = int.MaxValue;
        bool out2 = true;
        int out3 = 0;
        bool out4 = true;
        int n1 = 0;
        int n2 = 1;
        int last_let = 0;
        int shag = 0;
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            int num = int.Parse(Console.ReadLine());
            if (i == 0) last_let = num;

            if (last_let == num) n1++;
            else {
                if (n1 < out1) out1 = n1;
                n1 = 1;
            }
            if (i == n - 1 & n1 < out1) out1 = n1;

            if (num % (i + 1) != 0) out2 = false; 

            if (last_let != num) n2++;
            else {
                if (n2 > out3) out3 = n2;
                n2 = 1;
            }
            if (i == n - 1 & n2 > out3) out3 = n2;

            if (i == 1) shag = last_let - num;
            if (last_let - num != shag && i != 0 || last_let <= num && i != 0) out4 = false;

            last_let = num;
        }
        Console.WriteLine($"Наименьшая длина последовательности одинаковых элементов: {out1}");
        Console.WriteLine($"Все элементы кратны номеру, под которым они стоят: {out2}");
        Console.WriteLine($"Наибольшая длина последовательности разных элементов: {out3}");
        Console.WriteLine($"Последовательность равномерно убывает: {out4}");

        Console.Read();
    }
}