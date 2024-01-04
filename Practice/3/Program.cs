using System;

class Program {
    static void Main() {
        int start_num = 106732567;
        int end_num = 152673836;
        // int count = 0;
        for (int i = start_num; i <= end_num; i++) {
            int num = (int)Math.Sqrt(Math.Sqrt(i));
            if (num * num * num * num != i) {
                continue;
            } 
            int dels = 0;
            for (int j = 2; j < 10; j++) {
                if (num % j == 0) {
                    dels++;
                }
            }
            if (dels != 0) {
                continue;
            }
            Console.WriteLine($"{i} {Math.Pow(num, 3)}");
        }
    }
}