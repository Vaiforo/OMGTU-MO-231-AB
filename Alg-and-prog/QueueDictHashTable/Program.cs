using System.Collections;

class NoteBook {
    static void Main() {
        Queue<string> queue1 = new();

        queue1.Enqueue("89139653821 11.11.2022 12");
        queue1.Enqueue("89139652498 11.10.2022 15");
        queue1.Enqueue("89139652498 11.10.2022 3");
        queue1.Enqueue("89139653821 11.11.2022 5");
        queue1.Enqueue("89139653456 11.12.2022 8");
        queue1.Enqueue("89139653456 11.11.2022 28");
        queue1.Enqueue("89139653821 11.10.2023 13");
        queue1.Enqueue("89139653821 11.10.2023 18");
        queue1.Enqueue("89139653821 11.11.2023 6");

        Queue<string> queue2 = new(queue1.ToArray());

        // Подсчёт с помощью Dictionary

        Console.WriteLine("Подсчёт с помощью Dictionary\n");

        Dictionary<string, Dictionary<string, Dictionary<string, int>>> report1 = new();
        report1 = ReportWithDict.GetReport(queue1);

        Outputer.PrintDictionary(report1);

        Console.WriteLine("___________________________________________");

        // Подсчёт с помощью Hashtable

        Console.WriteLine("Подсчёт с помощью Hashtable\n");

        Hashtable report2 = new();
        report2 = ReportWithTable.GetReport(queue2);

        Outputer.PrintHashtable(report2);

        Console.WriteLine("___________________________________________");
    }
}