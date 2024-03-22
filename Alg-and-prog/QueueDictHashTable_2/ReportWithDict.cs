public class ReportWithDict {
    public static Dictionary<string, int> GetReport(Queue<string> queue) {
        Dictionary<string, int> report = new();
        
        while (queue.Count > 0) {
            string[] callInfo = queue.Dequeue().Split(" ");
            var (day, callTime) = (callInfo[1], callInfo[2]);

            if (!report.ContainsKey(day)) {
                report.Add(day, int.Parse(callTime));
            } else {
                report[day] += int.Parse(callTime);
            }
        }
        
        return report;
    }
}