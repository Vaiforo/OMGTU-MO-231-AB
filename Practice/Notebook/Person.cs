public class Person {
    private string Surname;
    private string Name;
    private string Patronymic;
    private string Number;
    private string Address = ":Нет данных:";
    private string Year = ":Нет данных:";
    private string Month = "";
    private string Date = "";

    public Person(string Surname, string Name, string Patronymic, string Number) {
        this.Surname = Surname;
        this.Name = Name;
        this.Patronymic = Patronymic;
        this.Number = Number;
    }
    
    public Person(string Surname, string Name, string Patronymic, string Number, string Address) {
        this.Surname = Surname;
        this.Name = Name;
        this.Patronymic = Patronymic;
        this.Number = Number;
        this.Address = Address;
    }

    public Person(string Surname, string Name, string Patronymic, string Number, string Address, string Year, string Month, string Date) {
        this.Surname = Surname;
        this.Name = Name;
        this.Patronymic = Patronymic;
        this.Number = Number;
        this.Address = Address;
        this.Year = Year;
        this.Month = Month;
        this.Date = Date;
    }

    public void printData(int[] parametrs) {
        string data = parametrs[3] == 1 ? $"Номер телефона: {Number}\n" : "";
        data += parametrs[0] + parametrs[1] + parametrs[2] >= 1 ? $"ФИО: {(parametrs[0] == 1 ? Surname + " " : "")}{(parametrs[1] == 1 ? Name + " " : "")}{(parametrs[2] == 1 ? Patronymic : "")}\n" : "";
        data += parametrs[4] == 1 ? $"Адрес проживания: {Address}\n" : "";
        data += parametrs[5] + parametrs[6] + parametrs[7] >= 1 ? $"Дата рождения: {(parametrs[5] == 1 ? Year + " " : "")}{(parametrs[6] == 1 ? Month + " " : "")}{(parametrs[7] == 1 ? Date : "")}\n" : "";
        data += "-------------------------------------------------------------------------------------------";
        Console.WriteLine(data);
    }

    public bool isSurname(string surname) {
        return surname == Surname;
    }

    public bool isName(string name) {
        return name == Name;
    }

    public bool isPatronymic(string patronymic) {
        return patronymic == Patronymic;
    }

    public bool isNumber(string number) {
        return number == Number;
    }

    public bool isAddress(string adress) {
        return adress == Address;
    }

    public bool isYear(string year) {
        return year == Year;
    }

    public bool isMonth(string month) {
        return month == Month;
    }

    public bool isDate(string date) {
        return date == Date;
    }

    public int getYear() {
        if (!char.IsDigit(Year[0])) return 0;
        return int.Parse(Year);
    }

    public string getMonth() {
        if (Month == ":Нет данных:") return "январь";
        return Month;
    }

    public int getDate() {
        if (!char.IsDigit(Date[0])) return 0;
        return int.Parse(Date);
    }
}