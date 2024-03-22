using System;

public class Audits {
    enum Screen {
        Menu,
        CreateBD,
        CreateNewAudit,
        EditAuditByNumber,
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
                    nowScreen = (Screen)menu.MainMenu();
                    break;
                case 1:
                    auditoriums = menu.CreateBD();
                    nowScreen = Screen.Menu;
                    menu.Skip();
                    break;
                case 2:
                    if (menu.CheckEmptyCreatedBd(auditoriums, false)) {
                        menu.CreateNewAudit(auditoriums);
                    }
                    nowScreen = Screen.Menu;
                    menu.Skip();
                    break;
                case 3:
                    if (menu.CheckEmptyCreatedBd(auditoriums, false)) {
                        menu.EditAuditByNumber(auditoriums);
                    }
                    nowScreen = Screen.Menu;
                    menu.Skip();
                    break;
                case 4:
                    if (menu.CheckEmptyCreatedBd(auditoriums, true)) {
                        menu.printCountSitAudits(auditoriums);
                    }
                    nowScreen = Screen.Menu;
                    menu.Skip();
                    break;
                case 5:
                    if (menu.CheckEmptyCreatedBd(auditoriums, true)) {
                        menu.printHaveProecktorAudits(auditoriums);
                    }
                    nowScreen = Screen.Menu;
                    menu.Skip();
                    break;
                case 6:
                    if (menu.CheckEmptyCreatedBd(auditoriums, true)) {
                        menu.printCountSitPcAudits(auditoriums);
                    }
                    nowScreen = Screen.Menu;
                    menu.Skip();
                    break;
                case 7:
                    if (menu.CheckEmptyCreatedBd(auditoriums, true)) {
                        menu.printStageAudits(auditoriums);
                    }
                    nowScreen = Screen.Menu;
                    menu.Skip();
                    break;
                case 8:
                    if (menu.CheckEmptyCreatedBd(auditoriums, true)) {
                        menu.printAllAudits(auditoriums);
                    }
                    nowScreen = Screen.Menu;
                    menu.Skip();
                    break; 
                case 9:
                    Environment.Exit(0);
                    break; 
            }
        }
    }
}