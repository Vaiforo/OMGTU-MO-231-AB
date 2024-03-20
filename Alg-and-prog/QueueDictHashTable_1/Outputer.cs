using System.Collections;

public class Outputer {
    private readonly static string[] mounths = {"January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December"};

    public static void PrintDictionary(Dictionary<string, Dictionary<string, Dictionary<string, int>>> dictionary) {
        foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, int>>> yearReport in dictionary) {
            Console.WriteLine($"Year: {yearReport.Key}");
            foreach (KeyValuePair<string, Dictionary<string, int>> monthReport in yearReport.Value) {
                Console.WriteLine($"Month: {mounths[int.Parse(monthReport.Key) - 1]}({monthReport.Key})");
                foreach (KeyValuePair<string, int> phoneReport in monthReport.Value) {
                    Console.WriteLine($"{phoneReport.Key}: {phoneReport.Value} minutes");
                }
                Console.WriteLine();
            }
        }
    }

    public static void PrintHashtable(Hashtable table) {
        IDictionaryEnumerator yearReport = table.GetEnumerator();
        DictionaryEntry year, mounth, call;
        IDictionaryEnumerator monthReport, phoneReport;

        while (yearReport.MoveNext()) {
            year = (DictionaryEntry)yearReport.Current;
            Console.WriteLine($"Year: {year.Key}");

            Hashtable mountHash = (Hashtable)year.Value;
            monthReport = mountHash.GetEnumerator();
            while (monthReport.MoveNext()) {
                mounth = (DictionaryEntry)monthReport.Current;
                Console.WriteLine($"Month: {mounths[int.Parse((string)mounth.Key) - 1]}({mounth.Key})");

                Hashtable phoneHash = (Hashtable)mounth.Value;
                phoneReport = phoneHash.GetEnumerator();
                while (phoneReport.MoveNext()) {
                    call = (DictionaryEntry)phoneReport.Current;
                    Console.WriteLine($"{call.Key}: {call.Value} minutes");
                }
                Console.WriteLine();
            }
        }
    }
}