public class Call {
    public string Date;
    public int CallTime;
    public int Day;
    public int Mounth;
    public int Year;

    public Call(string date, int callTime) {
        Date = date;
        CallTime = callTime;
        SetDate(date);
    }

    public void SetDate(string date) {
        string[] dateParts = date.Split('.');
        Day = int.Parse(dateParts[0]);
        Mounth = int.Parse(dateParts[1]);
        Year = int.Parse(dateParts[2]);
    }
}