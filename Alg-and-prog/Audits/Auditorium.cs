public class Auditorium {
    private int Number;
    private int SitCount;
    private bool Proecktor;
    private bool HavePc;

    public void printAuditorumData() {
        Console.WriteLine($"Номер аудитории: {Number}");
        Console.WriteLine($"Кол-во посадочных мест: {SitCount}; Проектор: {(Proecktor ? "да" : "нет")}; Компьютеры: {(HavePc ? "да" : "нет")}");
    }

    public string setNumber(int number) {
        if (number >= 100 || number <= 10) return "Неверный номер аудитории!";
        else {
            Number = number;
            return "";
        }
    }

    public string setSitCount(int sitCount) {
        if (sitCount <= 0) return "Неверное кол-во посадочных мест!";
        else {
            SitCount = sitCount;
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