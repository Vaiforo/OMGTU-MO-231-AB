using System.Collections;

public class ReportWithTable {
    public static Hashtable GetReport(Queue<string> queue) {
        Hashtable report = new();

        while (queue.Count > 0) {
            string[] phoneInfo = queue.Dequeue().Split(" ");
            var (phoneNumber, date, callMinutes) = (phoneInfo[0], phoneInfo[1].Split("."), phoneInfo[2]);
            var (mounth, year) = (date[1], date[2]);

            if (!report.ContainsKey(year)) {
                Hashtable mounthsReport = new();
                Hashtable callMinutesReport = new() {
                    { phoneNumber, int.Parse(callMinutes) }
                };

                mounthsReport.Add(mounth, callMinutesReport);
                report.Add(year, mounthsReport);
            } else {
                Hashtable mounthsReport = (Hashtable)report[year];
                if (!mounthsReport.ContainsKey(mounth)) {
                    Hashtable callMinutesReport = new() {
                        { phoneNumber, int.Parse(callMinutes) }
                    };

                    mounthsReport.Add(mounth, callMinutesReport);
                    report[year] = mounthsReport;
                } else {
                    Hashtable callMinutesReport = (Hashtable)mounthsReport[mounth];
                    if (!callMinutesReport.ContainsKey(phoneNumber)) {
                        callMinutesReport.Add(phoneNumber, int.Parse(callMinutes));
                        mounthsReport[mounth] = callMinutesReport;
                        report[year] = mounthsReport;
                    } else {
                        callMinutesReport[phoneNumber] = (int)callMinutesReport[phoneNumber] + int.Parse(callMinutes);
                        mounthsReport[mounth] = callMinutesReport;
                        report[year] = mounthsReport;
                    }
                }
            }
        }

        return report;
    }
}