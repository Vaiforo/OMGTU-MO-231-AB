public class Auditorium {
    private int Number;
    private int SitCount;
    private bool Proecktor;
    private bool HavePc;

    public void printAuditorumData() {
        Console.WriteLine($"Номер аудитории: {Number}");
        Console.WriteLine($"Кол-во посадочных мест: {SitCount}; Проектор: {(Proecktor ? "да" : "нет")}; Компьютеры: {(HavePc ? "да" : "нет")}");
    }

    public string setNumber(string number) {
        bool isNum = int.TryParse(number, out int num);
        if (num >= 100 || num <= 10 || !isNum) return "Неверный номер аудитории!";
        else {
            Number = num;
            return "";
        }
    }

    public string setSitCount(string sitCount) {
        bool isNum = int.TryParse(sitCount, out int num);
        if (num <= 0 || !isNum) return "Неверное кол-во посадочных мест!";
        else {
            SitCount = num;
            return "";
        }
    }

    public void setProecktor(bool proecktor) {
        Proecktor = proecktor;
    }

    public void setHavePC(bool havePc) {
        HavePc = havePc;
    }

    public int getNumber() {
        return Number;
    }

    public int getSitCount() {
        return SitCount;
    }

    public bool getProecktor() {
        return Proecktor;
    }

    public bool getHavePc() {
        return HavePc;
    }
}