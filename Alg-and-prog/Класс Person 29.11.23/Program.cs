string sortEducation = "Second", sortName = "Fill";
int sortYear = 2000;

Person[] persons = new Person[10];

persons[0] = new Person("Fill", 2005, "Second", "27 Line, 47");
persons[1] = new Person("Doll", 1997, "Higher", "5 Line, 7");
persons[2] = new Person("Bill", 2000, "Second", "27 Line, 47");
persons[3] = new Person("Ulona", 2000, "None", "27 Line, 47");
persons[4] = new Person("Fill", 1976, "Professor", "27 Line, 40");
persons[5] = new Person("Berl", 1891, "None", "27 Line, 40");
persons[6] = new Person("Ulona", 2002, "Higher", "7 Line, 12");
persons[7] = new Person("Mack", 2010, "Second", "7 Line, 13");
persons[8] = new Person("Piter", 1988, "Second", "27 Line, 47");
persons[9] = new Person("Merlin", 2002, "Higher", "27 Line, 40");

Console.WriteLine("Сортировка по образованию типа: " + sortEducation);

foreach (Person person in persons) {
    if (person.isEducation(sortEducation)) Console.WriteLine(person.printPerson());
}

Console.WriteLine("\nСортировка по году рождения: " + sortYear);

foreach (Person person in persons) {
    if (person.isYear(sortYear)) Console.WriteLine(person.printPerson());
}

Console.WriteLine("\nСортировка по имени:" + sortName);

foreach (Person person in persons) {
    if (person.isName(sortName)) Console.WriteLine(person.printPerson());
}

public class Person {
    private string Name;
    private int Year;
    private string Education;
    private string Address;

    public Person(string Name, int Year, string Education, string Address) {
        this.Name = Name;
        this.Year = Year;
        this.Education = Education;
        this.Address = Address;
    }

    public bool isName(string name) {
        return Name == name;
    }

    public bool isYear(int year) {
        return Year == year;
    }

    public bool isEducation(string education) {
        return Education == education;
    }

    public string getName() {
        return Name;
    }

    public int getYear() {
        return Year;
    }

    public string getEducation() {
        return Education;
    }

    public string getAddress() {
        return Address;
    }

    public string printPerson() {
        return $"Name: {Name}\nYear: {Year}\nEducation: {Education}\nAddress: {Address}";
    }

    public void setName(string name) {
        this.Name = name;
    }

    public void setYearOfBirth(int year) {
        this.Year= year;
    }

    public void setEducation(string education) {
        this.Education = education;
    }

    public void setAdress(string address) {
        this.Address = address;
    }
}