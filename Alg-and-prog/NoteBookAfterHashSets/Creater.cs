public class Creater {
    public static Dictionary<string, Dictionary<string, List<Call>>> GetNoteBook(Queue<string> queue) {
        Dictionary<string, Dictionary<string, List<Call>>> notebook = new();

        while (queue.Count > 0) {
            string[] line = queue.Dequeue().Split(" ");
            var (fromPhone, toPhone, date, callTime) = (line[0], line[1], line[2], line[3]);

            if (!notebook.ContainsKey(fromPhone)) {
                Dictionary<string, List<Call>> dayNoteBook = new() {
                    {date, new List<Call>(){new Call(toPhone, int.Parse(callTime))}}
                };
                notebook.Add(fromPhone, dayNoteBook);
            } else {
                if (!notebook[fromPhone].ContainsKey(date)) {
                    notebook[fromPhone].Add(date, new List<Call>(){new Call(toPhone, int.Parse(callTime))});
                } else {
                    notebook[fromPhone][date].Add(new Call(toPhone, int.Parse(callTime)));
                }
            }
        }
        return notebook;
    }

    public static (Dictionary<string, int[]>, string) GetHistoryOfCalls(Dictionary<string, Dictionary<string, List<Call>>> notebook, string fromPhone) {
        Dictionary<string, int[]> history = new();
        Dictionary<string, int> callsCount = new();

        foreach (var (_, calls) in notebook[fromPhone]) {
            foreach (Call call in calls) {
                // if (!callsCount.ContainsKey(call.PhoneNumber)) {
                //     callsCount.Add(call.PhoneNumber, 1);
                // } else {
                //     callsCount[call.PhoneNumber]++;
                // }
                if (!callsCount.TryAdd(call.PhoneNumber, 1)) {
                    callsCount[call.PhoneNumber]++;
                }
            }
        }

        string mostPopularNumber = callsCount.MaxBy(x => x.Value).Key;
        foreach (var (date, calls) in notebook[fromPhone]) {
            foreach (Call call in calls) {
                if (call.PhoneNumber == mostPopularNumber) {
                    if (!history.ContainsKey(date)) {
                        history.Add(date, new int[]{call.CallTime, 1});
                    } else {
                        history[date][0] += call.CallTime;
                        history[date][1]++;
                    }
                }
            }
        }

        return (history, mostPopularNumber);
    }

}