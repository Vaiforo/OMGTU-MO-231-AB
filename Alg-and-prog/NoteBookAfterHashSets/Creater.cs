public class Creater {
    public static Dictionary<string, Dictionary<string, Call>> GetNoteBook(Queue<string> queue) {
        Dictionary<string, Dictionary<string, Call>> notebook = new();

        while (queue.Count > 0) {
            string[] line = queue.Dequeue().Split(" ");
            var (fromPhone, toPhone, date, callTime) = (line[0], line[1], line[2], line[3]);

            if (!notebook.ContainsKey(fromPhone)) {
                Dictionary<string, Call> dayNoteBook = new(){
                    {date, new Call(toPhone, int.Parse(callTime))}
                };
                notebook.Add(fromPhone, dayNoteBook);
            } else {
                notebook[fromPhone].Add(toPhone, new Call(toPhone, int.Parse(callTime)));
            }
        }
        return notebook;
    }

    public static (Dictionary<string, (int, int)>, string) GetHistoryOfCalls(Dictionary<string, Dictionary<string, Call>> notebook, string fromPhone) {
        Dictionary<string, (int, int)> history = new();
        Dictionary<string, int> callsCount = new();

        foreach (var (_, call) in notebook[fromPhone]) {
            if (!callsCount.ContainsKey(call.PhoneNumber))
                callsCount.Add(call.PhoneNumber, 1);
            else
                callsCount[call.PhoneNumber] += 1;
        }

        string mostPopularNumber = callsCount.MaxBy(x => x.Value).Key;
        foreach (var (date, call) in notebook[fromPhone]) {
            if (call.PhoneNumber == mostPopularNumber) {
                if (!history.ContainsKey(date))
                    history.Add(date, (call.CallTime, 1));
                else 
                    history[date].Fri += (call.CallTime, 1);
            }
        }

        return (history, mostPopularNumber);
    }

}