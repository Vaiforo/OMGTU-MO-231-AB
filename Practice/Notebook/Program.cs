using System;
using System.Collections.Generic;


class Notebook {
    enum screenStatuses {
        Menu,
        FindByNumber,
        ChooseParam,
        PrintByParam,
        FindByParam,
    }

    enum printParams {
        Suranme,
        Name,
        Patronymic,
        Number,
        Adress,
        Year,
        Mounth,
        Date,
    }

    static screenStatuses statusScr = screenStatuses.Menu;
    static printParams printByParam = printParams.Number; 
    static string findParam; 
    static string error;

    static List<Person> persons = new List<Person>();
    static List<Person> sortPersons = new List<Person>();

    static void Main() {
        CreatePersons(persons);  // Люди для примера

        PersonComparer cmp = new PersonComparer();

        persons.Sort(cmp);

        while (true) {
            Console.SetWindowSize(92, 45);

            Console.CursorSize = 100;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Display.PrintHeader();

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (statusScr == 0) {
                Menu();
            } else if ((int)statusScr == 1) {
                FindByNumber();
            } else if ((int)statusScr == 2) {
                ChooseParam();
            } else if ((int)statusScr == 3) {
                PrintByParam();
            } else if ((int)statusScr == 4) {
                FindByParam();
            }

            Console.Clear();
        }
    }

    static void Menu() {
        Console.WriteLine("::::Выберите действие (Стрекли вверх/вниз enter)::::\n");

        sortPersons.Clear();
        foreach (Person person in persons) sortPersons.Add(person);

        int top = Console.CursorTop;
        int y = top;

        Console.WriteLine("+ Поиск человека по номеру");
        Console.WriteLine("+ Поиск по другим параметрам");

        int down = Console.CursorTop;

        statusScr = (screenStatuses)Choose(ref top, ref y, ref down) + 1;
    }

    static void FindByNumber() {
        Console.WriteLine("::::Поиск по номеру::::");

        Console.WriteLine(error);
        error = "";

        Console.Write("Ввидет номер искомого человека: ");
        findParam = Console.ReadLine();

        foreach (char num in findParam) {
            if (!char.IsDigit(num)) {
                error = "Введенный номер некорректен!";
                break;
            }
        }

        printByParam = printParams.Number;

        if (error == "") statusScr = screenStatuses.PrintByParam;
        // else повтор ввода
    }

    static void ChooseParam() {
        Console.WriteLine("::::Поиск по параметрам::::");

        int top = Console.CursorTop;
        int y = top;

        Console.WriteLine("+ Поиск людей по фамилии");
        Console.WriteLine("+ Поиск людей по имени");
        Console.WriteLine("+ Поиск людей по отчеству");
        Console.WriteLine("+ Поиск людей по адресу");
        Console.WriteLine("+ Поиск людей по году рождения");
        Console.WriteLine("+ Поиск людей по месяцу рождения");
        Console.WriteLine("+ Поиск людей по дате (в месяце) рождения");

        int down = Console.CursorTop;

        int paramN = Choose(ref top, ref y, ref down);
        printByParam = (printParams)(paramN >= 3 ? paramN + 1 : paramN);

        statusScr = screenStatuses.FindByParam;
    }

    static void FindByParam() {
        Console.WriteLine("::::Поиск по параметру::::");

        Console.WriteLine(error);
        error = "";

        if ((int)printByParam <= 5) {
            Console.Write($"Ввидет параметр ({printByParam}) искомого человека: ");
            findParam = Console.ReadLine();
        }
        
        if ((int)printByParam < 3) {
            foreach (char let in findParam) {
                if (char.IsDigit(let)) {
                    error = "Некорректный ввод!";
                    break;
                }
            }
        } else if ((int)printByParam == 5) {
            foreach (char let in findParam) {
                if (!char.IsDigit(let)) {
                    error = "Некорректный год!";
                    break;
                }
            }
            if (int.Parse(findParam) > DateTime.Now.Year || int.Parse(findParam) <= DateTime.Now.Year - 116) {
                error = "Некорректный год!";
            }
        } else if ((int)printByParam == 6) {
            int top = Console.CursorTop;
            int y = top;
            
            string[] mounths = {"январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь"};

            foreach (string elem in mounths) Console.WriteLine($"+ {elem}");

            int down = Console.CursorTop;

            findParam = mounths[Choose(ref top, ref y, ref down)];

            statusScr = screenStatuses.PrintByParam;
        } else if ((int)printByParam == 7) {
            int top = Console.CursorTop;
            int y = top;

            for (int i = 1; i <= 31; i++) Console.WriteLine($"+ {i}");

            int down = Console.CursorTop;

            findParam = $"{Choose(ref top, ref y, ref down) + 1}";

            statusScr = screenStatuses.PrintByParam;
        }

        if (error == "") statusScr = screenStatuses.PrintByParam;
        // else повтор ввода
    }

    static void PrintByParam() {
        Console.WriteLine("::::Результаты поиска::::\n");

        int top = Console.CursorTop;
        int y = top;

        Console.WriteLine("+ Изменить значение параметра");

        if ((int)printByParam != 3) {
            Console.WriteLine("+ Добавить параметр");
        }

        Console.WriteLine("+ К меню");

        int down = Console.CursorTop;

        Console.WriteLine($"\nПоиск по: {findParam}");
        Console.WriteLine("-------------------------------------------------------------------------------------------");

        int[] paramsForFind = {1, 1, 1, 1, 1, 1, 1, 1};
        paramsForFind[(int)printByParam] = 0;

        List<Person> newSortedPersons = new List<Person>();
        int counter = 0;        
        foreach (Person person in sortPersons) {

            bool ok = false;
            if ((int)printByParam == 0) ok = person.isSurname(findParam);
            else if ((int)printByParam == 1) ok = person.isName(findParam);
            else if ((int)printByParam == 2) ok = person.isPatronymic(findParam);
            else if ((int)printByParam == 3) ok = person.isNumber(findParam);
            else if ((int)printByParam == 4) ok = person.isAddress(findParam);
            else if ((int)printByParam == 5) ok = person.isYear(findParam);
            else if ((int)printByParam == 6) ok = person.isMonth(findParam);
            else if ((int)printByParam == 7) ok = person.isDate(findParam);

            if (ok) {
                counter++;
                person.printData(paramsForFind);
                newSortedPersons.Add(person);
            }
        }
        if (counter == 0) Console.WriteLine("Ничего не найдено");

        int check = Choose(ref top, ref y, ref down);

        if (check == 0) {
            if ((int)printByParam != 3) statusScr = screenStatuses.FindByParam;
            else statusScr = screenStatuses.FindByNumber;
        }
        else if (check == 1 && (int)printByParam != 3) {
            statusScr = screenStatuses.ChooseParam;
            sortPersons.Clear();
            foreach (Person person in newSortedPersons) {
                sortPersons.Add(person);
            }
        }
        else statusScr = screenStatuses.Menu;
    }

    static int Choose(ref int top, ref int y, ref int down) {
        Console.CursorTop = top;
        ConsoleKey key;
        while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
        {
            if (key == ConsoleKey.UpArrow)
            {
                if (y > top)
                {
                    y--;
                    Console.CursorTop = y;
                }
            }
            else if (key == ConsoleKey.DownArrow)
            {
                if (y < down - 1)
                {
                    y++;
                    Console.CursorTop = y;
                }
            }
        }

        Console.CursorTop = down;

        return y - top;
    }

    static void CreatePersons(List<Person> persons) {
        persons.Add(new Person("Иванов", "Иван", "Иванович", "123456"));
        persons.Add(new Person("Кокорин", "Петр", "Алексеевич", "1234567", "Омск"));
        persons.Add(new Person("Ниров", "Сергей", "Петрович", "12345678", "Томск", "2000", "апрель", "27"));
        persons.Add(new Person("Серов", "Петр", "Олегович", "7234243", "Новосибирск", "1999", "март", "15"));
        persons.Add(new Person("Серов", "Аркадий", "Олегович", "45645475", "Омск", "1996", "апрель", "17"));
        persons.Add(new Person("Куликов", "Марк", "Олегович", "86786867", "Новосибирск", "1996", "декабрь", "15"));
        persons.Add(new Person("Гений", "Арсений", "Валерьевич", "2346456", "Уфа", "1996", "апрель", "17"));
    }
}