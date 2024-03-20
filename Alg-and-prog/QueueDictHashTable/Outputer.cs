using System.Collections;

public class Outputer {
    private readonly static string[] mounths = {"January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December"};

    public static void PrintDictionary(Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary) {
        foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> yearReport in dictionary) {
            Console.WriteLine($"Year: {yearReport.Key}");
            foreach (KeyValuePair<string, Dictionary<string, int>> monthReport in yearReport.Value) {
                Console.WriteLine($"Month: {mounths[int.Parse(monthReport.Key) - 1]}({monthReport.Key})");
                foreach (KeyValuePair<string, int> callReport in monthReport.Value) {
                    Console.WriteLine($"{callReport.Key}: {callReport.Value} minutes");
                }
                Console.WriteLine();
            }
        }
    }

    public static void PrintHashtable(Hashtable table) {
        foreach (Hashtable mounthsReport in table) {
            foreach (Hashtable callReport in mounthsReport.Values) {
                foreach (DictionaryEntry call in callReport) {
                    Console.WriteLine($"{call.Key}: {call.Value} minutes");
                }
            }
        }
    }
}