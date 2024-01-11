public class PersonComparer: IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        string[] mounths = {"январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь"};

        if (x.getYear() > y.getYear()) return 1;
        else if (x.getYear() == y.getYear()) return 0;
        else if (x.getYear() < y.getYear()) return -1;
        else {
            if (FindIndex(mounths, x.getMonth()) < FindIndex(mounths, y.getMonth())) return 1;
            else if (FindIndex(mounths, x.getMonth()) == FindIndex(mounths, y.getMonth())) return 0;
            else if (FindIndex(mounths, x.getMonth()) > FindIndex(mounths, y.getMonth())) return -1;
            else {
                if (x.getDate() > y.getDate()) return 1;
                else if (x.getDate() == y.getDate()) return 0;
                else if (x.getDate() < y.getDate()) return -1;
                else {
                    return 0;
                }
            }
        }
    }

    public int FindIndex(string[] mounths, string mounth) {
        for (int i = 0; i < 12; i++) {
            if (mounths[i] == mounth) return i;
        }
        return 0;
    }
}