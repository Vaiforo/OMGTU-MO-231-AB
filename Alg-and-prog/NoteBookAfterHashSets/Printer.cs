public class Printer {
    static public void PrintMostPopular(Dictionary<string, int[]> history, string mostPopularNumber, string fromNumber) {
        Console.WriteLine($"С номера {fromNumber} чаще всего звонили на номер {mostPopularNumber}");

        

        foreach (var (date, call) in history) {
            Console.WriteLine($"\t- {date} total {call[0]} min. {call[1]} calls");
        }
    }
}