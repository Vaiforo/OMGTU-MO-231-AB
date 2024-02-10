public class Menu {
    public void skip() {
        Console.Write("Нажмите enter для продолжения...");
        Console.ReadLine();
    }

    public bool checkEmptyCreatedBd(List<Auditorium> audits, bool checkEmpty) {
        try {
            if (!checkEmpty && audits.Count == 0) {
                return true;
            }
            if (audits.Count == 0) {
                Console.WriteLine("База данных пуста.");
                Console.WriteLine("Сначала добавьте аудитории!");
                return false;
            } return true;
        } catch {
            Console.WriteLine("База данных не создана.");
            return false;
        }
    }

    public List<Auditorium> CreateBD() {
        Console.WriteLine("База данных успешно создана!");
        return new List<Auditorium>();
    }

    public void CreateNewAudit(List<Auditorium> auditoriums) {
        var newAudit = new Auditorium();

        Console.WriteLine("--Добавление новой аудитории--");

        Console.Write("Введите номер аудитории (этаж+номер): ");
        string err = newAudit.setNumber(Console.ReadLine());
        while (err != "") {
            Console.Write($"{err}\n\nВведите номер аудитории (этаж+номер): ");
            err = newAudit.setNumber(Console.ReadLine());
        }

        Console.Write("Введите кол-во посадочных мест: ");
        err = newAudit.setSitCount(Console.ReadLine());
        while (err != "") {
            Console.Write($"{err}\n\nВведите кол-во посадочных мест: ");
            err = newAudit.setSitCount(Console.ReadLine());
        }

        Console.WriteLine("Имеется ли проектор:");
        int top = Console.CursorTop;
        int y = top;
        Console.WriteLine("+ Да");
        Console.WriteLine("+ Нет");
        int down = Console.CursorTop;
        newAudit.setProecktor(Choose(ref top, ref y, ref down) == 0 ? true : false);

        Console.WriteLine("Имеются ли пк:");
        top = Console.CursorTop;
        y = top;
        Console.WriteLine("+ Да");
        Console.WriteLine("+ Нет");
        down = Console.CursorTop;
        newAudit.setHavePC(Choose(ref top, ref y, ref down) == 0 ? true : false);

        auditoriums.Add(newAudit);
    }

    public void EditAuditByNumber(List<Auditorium> auditoriums) {
        int top, y, down;

        Console.WriteLine("--Изменение данных об аудитории--");

        Console.Write("Введите номер аудитории: ");
        string number = Console.ReadLine();
        bool isNum = int.TryParse(number, out int num);
        while (isNum) {
            Console.WriteLine("Неверный ввод!");
            Console.Write("Введите номер аудитории: ");
            number = Console.ReadLine();
            isNum = int.TryParse(number, out num);
        }


        var findedAudit = auditoriums.Find(elem => elem.getNumber() == num);
        while (findedAudit == null) {
            Console.WriteLine("Аудитория с тким номером на найдена!");
            Console.WriteLine("Попробовать снова?");

            top = Console.CursorTop;
            y = top;
            Console.WriteLine("+ Да");
            Console.WriteLine("+ Нет");
            down = Console.CursorTop;
            if (Choose(ref top, ref y, ref down) == 1) return;

            Console.Write("Введите номер аудитории: ");
            number = Console.ReadLine();
            isNum = int.TryParse(number, out num);
            while (isNum) {
                Console.WriteLine("Неверный ввод!");
                Console.Write("Введите номер аудитории: ");
                number = Console.ReadLine();
                isNum = int.TryParse(number, out num);
            }

            findedAudit = auditoriums.Find(elem => elem.getNumber() == num);
        }

        int index = auditoriums.IndexOf(findedAudit);

        Console.Write($"Введите новое кол-во посадочных мест - текущее <{findedAudit.getSitCount()}>: ");
        var err = auditoriums[index].setSitCount(Console.ReadLine());
        while (err != "") {
            Console.Write($"{err}\n\nВведите новое кол-во посадочных мест - текущее <{findedAudit.getSitCount()}>: ");
            err = auditoriums[index].setSitCount(Console.ReadLine());
        }

        Console.WriteLine($"Имеется ли проектор - текущее <{(findedAudit.getProecktor() ? "да" : "нет")}>:");
        top = Console.CursorTop;
        y = top;
        Console.WriteLine("+ Да");
        Console.WriteLine("+ Нет");
        down = Console.CursorTop;
        auditoriums[index].setProecktor(Choose(ref top, ref y, ref down) == 0 ? true : false);

        Console.WriteLine($"Имеются ли пк - текущее <{(findedAudit.getHavePc() ? "да" : "нет")}>:");
        top = Console.CursorTop;
        y = top;
        Console.WriteLine("+ Да");
        Console.WriteLine("+ Нет");
        down = Console.CursorTop;
        auditoriums[index].setHavePC(Choose(ref top, ref y, ref down) == 0 ? true : false);
    }

    public void printCountSitAudits(List<Auditorium> auditoriums) {
        Console.WriteLine("--Поиск по кол-ву посадочных мест--");

        Console.Write("Введите кол-во посадочных мест: ");
        string sitCount = Console.ReadLine();
        bool isNum = int.TryParse(sitCount, out int num);
        while (isNum) {
            Console.WriteLine("Неверный ввод!");
            Console.Write("Введите кол-во посадочных мест: ");
            sitCount = Console.ReadLine();
            isNum = int.TryParse(sitCount, out num);
        }

        bool haveAudits = false;
        Console.WriteLine("\nПодходящие аудитории:");
        foreach (Auditorium auditorium in auditoriums) {
            if (auditorium.getSitCount() >= num) {
                haveAudits = true;
                Console.WriteLine(auditorium.getNumber());
            }
        }
        if (!haveAudits) {
            Console.WriteLine("Не найдено!");
        }      
    }

    public void printHaveProecktorAudits(List<Auditorium> auditoriums) {
        Console.WriteLine("--Поиск по наличию проекторов--");

        bool haveAudits = false;
        Console.WriteLine("\nПодходящие аудитории:");
        foreach (Auditorium auditorium in auditoriums) {
            if (auditorium.getProecktor()) {
                haveAudits = true;
                Console.WriteLine(auditorium.getNumber());
            }
        }
        if (!haveAudits) {
            Console.WriteLine("Не найдено!");
        }      
    }

    public void printCountSitPcAudits(List<Auditorium> auditoriums) {
        Console.WriteLine("--Поиск по кол-ву компьютеров--");

        Console.Write("Введите кол-во компьютеров: ");
        string sitCount = Console.ReadLine();
        bool isNum = int.TryParse(sitCount, out int num);
        while (isNum) {
            Console.WriteLine("Неверный ввод!");
            Console.Write("Введите кол-во компьютеров: ");
            sitCount = Console.ReadLine();
            isNum = int.TryParse(sitCount, out num);
        }

        bool haveAudits = false;
        Console.WriteLine("\nПодходящие аудитории:");
        foreach (Auditorium auditorium in auditoriums) {
            if (auditorium.getSitCount() >= num && auditorium.getHavePc()) {
                haveAudits = true;
                Console.WriteLine(auditorium.getNumber());
            }
        }
        if (!haveAudits) {
            Console.WriteLine("Не найдено!");
        }      
    }

    public void printStageAudits(List<Auditorium> auditoriums) {
        Console.WriteLine("--Поиск по этажу--");
        
        Console.Write("Введите этаж: ");
        string stage = Console.ReadLine();
        bool isNum = int.TryParse(stage, out int num);
        while (isNum) {
            Console.WriteLine("Неверный ввод!");
            Console.Write("Введите этаж: ");
            stage = Console.ReadLine();
            isNum = int.TryParse(stage, out num);
        }

        bool haveAudits = false;
        Console.WriteLine("\nПодходящие аудитории:");
        foreach (Auditorium auditorium in auditoriums) {
            if (int.Parse(auditorium.getNumber().ToString()[0] + "") == num) {
                haveAudits = true;
                Console.WriteLine(auditorium.getNumber());
            }
        }
        if (!haveAudits) {
            Console.WriteLine("Не найдено!");
        }      
    }

    public void printAllAudits(List<Auditorium> auditoriums) {
        Console.WriteLine("--Вывод всех аудиторий--");

        Console.WriteLine("--------------------------------------");
        foreach (Auditorium auditorium in auditoriums) {
            auditorium.printAuditorumData();
            Console.WriteLine("--------------------------------------");
        }
    }

    public int Choose(ref int top, ref int y, ref int down) {
        Console.CursorTop = top;
        ConsoleKey key;
        while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter) {
            if (key == ConsoleKey.UpArrow) {
                if (y > top) {
                    y--;
                    Console.CursorTop = y;
                }
            }
            else if (key == ConsoleKey.DownArrow) {
                if (y < down - 1) {
                    y++;
                    Console.CursorTop = y;
                }
            }
        }

        Console.CursorTop = down;

        return y - top;
    }
}