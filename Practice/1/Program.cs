Console.WriteLine("Программа для вычисления значений трех функций:");
Console.WriteLine(" Г (a + b) / (exp^x + cos(x))     0 <= x < 2.3");
Console.WriteLine("<  (a + b) / (x + 1)              2.3 <= x <5 ");
Console.WriteLine(" L exp^x + sin(x)                 5 <= x <= 7");
Console.WriteLine("");

double a = -2.7;
double b = -0.27;

Console.Write("Введите значение x от 0 до 7: ");
double x = Convert.ToDouble(Console.ReadLine());

double z = 0;
if (x >= 0 && x < 2.3) {
    z = (a + b) / (Math.Exp(x) + Math.Cos(x));
} else if (x >= 2.3 && x < 5) {
    z = (a + b) / (x + 1);
} else {
    z = Math.Exp(x) + Math.Sin(x);
}

Console.WriteLine($"z = {Math.Round(z, 3)}");
