using System;

public class Audits {
    enum Screen {
        Menu,
        CreateBD,
        CreateNewAudit,
        EditAudit,
        CountSitAudits,
        HaveProecktorAudits,
        CountSitPcAudits,
        StageAudits,
        AllAudits,
        Exit,
    }

    static Screen nowScreen = Screen.Menu;

    static List<Auditorium> auditoriums;
    static Menu menu;

    static void Main() {
        menu = new Menu();

        while (true) {
            Console.Clear();

            switch ((int)nowScreen) {
                case 0:
                    Console.WriteLine("Выберите действие (стрелка вверх/вниз, пробел):");

                    int top = Console.CursorTop;
                    int y = top;

                    Console.WriteLine("+ Создание базы аудиторий");
                    Console.WriteLine("+ Добавление в базу аудитории");
                    Console.WriteLine("+ Изменение данных аудитории (по номеру аудитории)");
                    Console.WriteLine("+ Аудитории с кол-вом мест больше заданного");
                    Console.WriteLine("+ Аудитории с проектором");
                    Console.WriteLine("+ Аудитории с пк и кол-вом мест больше заданного");
                    Console.WriteLine("+ Аудитории на заданном этаже");
                    Console.WriteLine("+ Показать все аудитории");
                    Console.WriteLine("+ Выход");

                    int down = Console.CursorTop;

                    nowScreen = (Screen)menu.Choose(ref top, ref y, ref down) + 1;
                    break;
                case 1:
                    auditoriums = menu.CreateBD();
                    nowScreen = Screen.Menu;
                    menu.skip();
                    break;
                case 2:
                    if (menu.check_bd_created(auditoriums)) {
                        auditoriums.Add(menu.CreateNewAudit());
                    }
                    nowScreen = Screen.Menu;
                    menu.skip();
                    break;
                case 4:
                    if (menu.check_bd_created(auditoriums)) {
                        if (menu.check_empty_bd(auditoriums)) {
                            menu.printCountSitAudits(auditoriums);
                        }
                    }
                    nowScreen = Screen.Menu;
                    menu.skip();
                    break;
                case 5:
                    if (menu.check_bd_created(auditoriums)) {
                        if (menu.check_empty_bd(auditoriums)) {
                            menu.printHaveProecktorAudits(auditoriums);
                        }
                    }
                    nowScreen = Screen.Menu;
                    menu.skip();
                    break;
                case 6:
                    if (menu.check_bd_created(auditoriums)) {
                        if (menu.check_empty_bd(auditoriums)) {
                            menu.printCountSitPcAudits(auditoriums);
                        }
                    }
                    nowScreen = Screen.Menu;
                    menu.skip();
                    break;
                case 7:
                    if (menu.check_bd_created(auditoriums)) {
                        if (menu.check_empty_bd(auditoriums)) {
                            menu.printStageAudits(auditoriums);
                        }
                    }
                    nowScreen = Screen.Menu;
                    menu.skip();
                    break;
                case 8:
                    if (menu.check_bd_created(auditoriums)) {
                        if (menu.check_empty_bd(auditoriums)) {
                            menu.printAllAudits(auditoriums);
                        }
                    }
                    nowScreen = Screen.Menu;
                    menu.skip();
                    break; 
                case 9:
                    break; 
            }
        }
    }
}