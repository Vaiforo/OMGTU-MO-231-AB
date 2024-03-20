public class ReportWithDict {
    public static Dictionary<string, Dictionary<string, Dictionary<string, int>>> GetReport(Queue<string> queue) {
        Dictionary<string,
            Dictionary<string,
                Dictionary<string, int>>> report = new();
        
        while (queue.Count > 0) {
            string[] phoneInfo = queue.Dequeue().Split(" ");
            var (phoneNumber, date, callMinutes) = (phoneInfo[0], phoneInfo[1].Split("."), phoneInfo[2]);
            var (mounth, year) = (date[1], date[2]);

            if (!report.ContainsKey(year)) {
                Dictionary<string, Dictionary<string, int>> mounthsReport = new();
                Dictionary<string, int> callMinutesReport = new() {
                    { phoneNumber, int.Parse(callMinutes) }
                };

                mounthsReport.Add(mounth, callMinutesReport);
                report.Add(year, mounthsReport);
            } else {
                if(!report[year].ContainsKey(mounth)) {
                    Dictionary<string, int> callMinutesReport = new() {
                        { phoneNumber, int.Parse(callMinutes) }
                    };

                    report[year].Add(mounth, callMinutesReport);
                } else {
                    if (!report[year][mounth].ContainsKey(phoneNumber)) {
                        report[year][mounth].Add(phoneNumber, int.Parse(callMinutes));
                    } else {
                        report[year][mounth][phoneNumber] += int.Parse(callMinutes);
                    }
                }
            }
        }

        return report;
    }
}