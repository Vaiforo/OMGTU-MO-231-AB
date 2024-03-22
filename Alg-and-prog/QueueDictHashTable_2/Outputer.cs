using System.Collections;

public class Outputer {
    public static void PrintDict(Dictionary<string, int> dict) {
        foreach (KeyValuePair<string, int> entry in dict) {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }

    public static void PrintHashtable(Hashtable table) {
        IDictionaryEnumerator report = table.GetEnumerator();
        DictionaryEntry dayReport;

        while (report.MoveNext()) {
            dayReport = (DictionaryEntry)report.Current;
            Console.WriteLine($"{dayReport.Key}: {dayReport.Value}");
        }
    }
}