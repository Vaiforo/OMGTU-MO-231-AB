using System;

private class Person {
    string fio;
    int bornYear;
    string education {get; init; } = "medieval";
    string adress {get; init; } = "Omsk";

    public void Printer() {
        Console.WriteLine($"FIO: {fio}\nBorn year: {bornYear}");
        Console.WriteLine($"Education: {education}\nAdress: {adress}");
    }

    void IsFio(string str) {
        if (str == fio) {
            Console.WriteLine("--------По FIO--------");
            Printer();
            Console.WriteLine("----------------------");
        }
    }

    void IsEducation(string str) {
        if (str == education) {
            Console.WriteLine("-----По Education-----");
            Printer();
            Console.WriteLine("----------------------");
        }
    }

    void IsYear(int year) {
        if (year == bornYear) {
            Console.WriteLine("-----По Born Year-----");
            Printer();
            Console.WriteLine("----------------------");
        }
    }


}

// class Program {
//     static void Main() {
//         Person person1 = new() {
//             FIO = "Ivanov Peta Sergeevich",
//             BornYear = 1977,
//         };

//         Person person2 = new() {
//             FIO = "Genadiev Genadiy Genadievich",
//             BornYear = 1977,
//             Education = "high",
//         };

//         Person person3 = new() {
//             FIO = "Chort Chort Chortovich",
//             BornYear = 1977,
//             Education = "high",
//             Adress = "Novosib",
//         };

//         Person[] persons = new Person[] {person1, person2, person3};

//         foreach (Person pers in persons) {

//         }
//     }
// }