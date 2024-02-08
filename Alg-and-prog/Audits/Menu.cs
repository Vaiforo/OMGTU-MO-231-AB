public class Menu {
    public void skip() {
        Console.Write("Нажмите enter для продолжения...");
        Console.ReadLine();
    }

    public bool check_empty_bd(List<Auditorium> audits) {
        if (audits.Count == 0) {
            Console.WriteLine("База данных пуста.");
            Console.WriteLine("Сначала добавьте аудитории!");
            return false;
        } return true;
    }

    public bool check_bd_created(List<Auditorium> audits) {
        try {
            if (audits.Count != 0) return true;return true;
        } catch {
            Console.WriteLine("База данных не создана.");
            return false;
        }
    }

    public List<Auditorium> CreateBD() {
        Console.WriteLine("База данных успешно создана!");
        return new List<Auditorium>();
    }

    public Auditorium CreateNewAudit() {
        var newAudit = new Auditorium();

        Console.WriteLine("--Добавление новой аудитории--");

        Console.Write("Введите номер аудитории (этаж+номер): ");
        string err = newAudit.setNumber(int.Parse(Console.ReadLine()));
        while (err != "") {
            Console.Write($"{err}\n\nВведите номер аудитории (этаж+номер): ");
            err = newAudit.setNumber(int.Parse(Console.ReadLine()));
        }

        Console.Write("Введите кол-во посадочных мест: ");
        err = newAudit.setSitCount(int.Parse(Console.ReadLine()));
        while (err != "") {
            Console.Write($"{err}\n\nВведите кол-во посадочных мест: ");
            err = newAudit.setSitCount(int.Parse(Console.ReadLine()));
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

        return newAudit;
    }

    public void printCountSitAudits(List<Auditorium> auditoriums) {
        Console.WriteLine("--Поиск по кол-ву посадочных мест--");

        Console.Write("Введите кол-во посадочных мест: ");
        int sitCount = int.Parse(Console.ReadLine());

        bool haveAudits = false;
        Console.WriteLine("\nПодходящие аудитории:");
        foreach (Auditorium auditorium in auditoriums) {
            if (auditorium.getSitCount() >= sitCount) {
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
        int sitCount = int.Parse(Console.ReadLine());

        bool haveAudits = false;
        Console.WriteLine("\nПодходящие аудитории:");
        foreach (Auditorium auditorium in auditoriums) {
            if (auditorium.getSitCount() >= sitCount && auditorium.getHavePc()) {
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
        int stage = int.Parse(Console.ReadLine());

        bool haveAudits = false;
        Console.WriteLine("\nПодходящие аудитории:");
        foreach (Auditorium auditorium in auditoriums) {
            if (int.Parse(auditorium.getNumber().ToString()[0] + "") == stage) {
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

        foreach (Auditorium auditorium in auditoriums) {
            auditorium.printAuditorumData();
        }
    }

    public int Choose(ref int top, ref int y, ref int down) {
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
}