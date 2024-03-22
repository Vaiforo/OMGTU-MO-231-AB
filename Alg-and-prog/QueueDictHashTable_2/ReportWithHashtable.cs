using System.Collections;

public class ReportWithHashtable {
    public static Hashtable GetReport(Queue<string> queue) {
        Hashtable report = new Hashtable();

        while (queue.Count > 0) {
            string[] callInfo = queue.Dequeue().Split(" ");
            var (day, callTime) = (callInfo[1], callInfo[2]);

            if (!report.ContainsKey(day)) {
                report.Add(day, int.Parse(callTime));
            } else {
                report[day] = (int)report[day] + int.Parse(callTime);
            }
        }

        return report;
    }
}