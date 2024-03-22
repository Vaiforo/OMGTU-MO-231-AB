public class Creater {
    public static Dictionary<string, Dictionary<string, Call>> GetNoteBook(Queue<string> queue) {
        Dictionary<string, Dictionary<string, Call>> notebook = new();

        while (queue.Count > 0) {
            string[] line = queue.Dequeue().Split(" ");
            var (fromPhone, toPhone, date, callTime) = (line[0], line[1], line[2], line[3]);

            if (!notebook.ContainsKey(fromPhone)) {
                Dictionary<string, Call> toPhoneNoteBook = new(){
                    {toPhone, new Call(date, int.Parse(callTime))}
                };
                notebook.Add(fromPhone, toPhoneNoteBook);
            }
        }
        return notebook;
    }

}