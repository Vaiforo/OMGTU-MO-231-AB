using System.Collections;


public class Program {
    static void Main() {
        int typeOf = 0;
        int justDoIt = 0;
        int top, y, down;

        int[] array = {1, 3, 5, 7, 9, 2, 4, 6, 8, 10};
        ArrayList arrayList = new ArrayList{"1", "2", "abc", "qwerty", "3"};
        SortedList arraySorted = new SortedList();
        arraySorted.Add("abc", "cba");
        arraySorted.Add("def", "fed");
        arraySorted.Add("gel", "leg");

        while (true) {
            switch (typeOf) {
                case 0:
                    top = Console.CursorTop;
                    y = top;

                    Console.WriteLine("* Array");
                    Console.WriteLine("* ArrayList");
                    Console.WriteLine("* SortedList");

                    down = Console.CursorTop;
                    typeOf = Choose(ref top, ref y, ref down) + 1;
                    break;
                case 1:
                    while (true) {     
                        Console.Clear();
                        if (typeOf == 0) break;
                        switch (justDoIt) {
                            case 0:
                                Console.WriteLine("--Array--");

                                top = Console.CursorTop;
                                y = top;

                                Console.WriteLine("* EditElement");
                                Console.WriteLine("* Count");
                                Console.WriteLine("* BinarySearch");
                                Console.WriteLine("* Copy");
                                Console.WriteLine("* Find");
                                Console.WriteLine("* FindLast");
                                Console.WriteLine("* IndexOf");
                                Console.WriteLine("* Reverse");
                                Console.WriteLine("* Resize");
                                Console.WriteLine("* Sort");
                                Console.WriteLine("* Назад");

                                down = Console.CursorTop;
                                justDoIt = Choose(ref top, ref y, ref down) + 1;
                                break;
                            case 1:
                                Console.WriteLine("--EditElement--\n");

                                Console.WriteLine("Что в Array сейчас: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                int index, newElem;
                                while (true) {
                                    Console.Write($"Введие индекс элемента для изменения <int>: ");
                                    if (int.TryParse(Console.ReadLine(), out index))
                                    if (index < array.Length) break;
                                }

                                while (true) {
                                    Console.Write($"Введие новый элемент <int>: ");
                                    if (int.TryParse(Console.ReadLine(), out newElem)) break;
                                }
                                array[index] = newElem;

                                Console.WriteLine("\nИ вот что сейчас: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine();

                                Skip();
                                justDoIt = 0;
                                break;
                            case 2:
                                Console.WriteLine("--Count--\n");

                                Console.WriteLine("Что в Array сейчас: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Console.WriteLine($"Кол-во четных элементов: {array.Count(x => x % 2 == 0)}");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 3:
                                Console.WriteLine("--BinarySearch--\n");

                                int[] forBinSearch = new int[array.Length];
                                Array.Copy(array, forBinSearch, array.Length);
                                Array.Sort(forBinSearch);

                                Console.WriteLine("Array для бинарного поиска: ");
                                foreach (var elem in forBinSearch) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                int findElem;
                                while (true) {
                                    Console.Write($"Введие искомый элемент <int>: ");
                                    if (int.TryParse(Console.ReadLine(), out findElem)) break;
                                }

                                Console.WriteLine($"\nИндекс введённого элемента: {Array.BinarySearch(forBinSearch, findElem)}");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 4:
                                Console.WriteLine("--Copy--\n");

                                int[] copyArray = new int[array.Length];
                                Array.Copy(array, copyArray, array.Length);

                                Console.WriteLine("Что в Array сейчас: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");
                                Console.WriteLine("И вот что в скопированном: ");
                                foreach (var elem in copyArray) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 5:
                                Console.WriteLine("--Find--\n");

                                Console.WriteLine("Что в Array сейчас: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");
                                
                                findElem = Array.Find(array, x => x % 2 == 0 && x % 3 == 0);
                                Console.WriteLine($"Первый элемент который делится на 2 и на 3: {findElem}");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 6:
                                Console.WriteLine("--FindLast--\n");

                                Console.WriteLine("Что в Array сейчас: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");
                                
                                findElem = Array.FindLast(array, x => x % 2 == 0 && x % 4 == 0);
                                Console.WriteLine($"Последний элемент который делится на 2 и на 4: {findElem}");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 7:
                                Console.WriteLine("--IndexOf--\n");

                                Console.WriteLine("Что в Array сейчас: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                while (true) {
                                    Console.Write($"Введие искомый элемент <int>: ");
                                    if (int.TryParse(Console.ReadLine(), out findElem)) break;
                                }
                                
                                Console.WriteLine($"\nИндекс искомого элемента: {Array.IndexOf(array, findElem)}");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 8:
                                Console.WriteLine("--Reverse--\n");

                                Console.WriteLine("Что в Array сейчас: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Array.Reverse(array);

                                Console.WriteLine("Перевёрнутый Array: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 9:
                                Console.WriteLine("--Resize--\n");

                                Console.WriteLine("Что в Array сейчас: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                int newSize;
                                while (true) {
                                    Console.Write($"Введие новую длину <int>: ");
                                    if (int.TryParse(Console.ReadLine(), out newSize))
                                    if (newSize > 0) break;
                                }
                                Array.Resize(ref array, newSize);

                                Console.WriteLine("Array после с измененным размером: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 10:
                                Console.WriteLine("--Sort--\n");

                                Console.WriteLine("Что в Array сейчас: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Array.Sort(array);

                                Console.WriteLine("Сортированный Array: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 11:
                                typeOf = 0;
                                justDoIt = 0;
                                break;
                        }
                    }
                    break;
                case 2:
                    while (true) {     
                        Console.Clear();
                        if (typeOf == 0) break;
                        switch (justDoIt) {
                            case 0:
                                Console.WriteLine("--ArrayList--");

                                top = Console.CursorTop;
                                y = top;

                                Console.WriteLine("* EditElement");
                                Console.WriteLine("* Count");
                                Console.WriteLine("* BinarySearch");
                                Console.WriteLine("* Copy");
                                Console.WriteLine("* IndexOf");
                                Console.WriteLine("* Insert");
                                Console.WriteLine("* Reverse");
                                Console.WriteLine("* Sort");
                                Console.WriteLine("* Add");
                                Console.WriteLine("* Назад");

                                down = Console.CursorTop;
                                justDoIt = Choose(ref top, ref y, ref down) + 1;
                                break;
                            case 1:
                                Console.WriteLine("--EditElement--\n");

                                Console.WriteLine("Что в ArrayList сейчас: ");
                                foreach (var elem in arrayList) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                int index;
                                string newElemList;
                                while (true) {
                                    Console.Write($"Введие индекс элемента для изменения <int>: ");
                                    if (int.TryParse(Console.ReadLine(), out index))
                                    if (index < arrayList.Count) break;
                                }

                                Console.Write($"Введие новый элемент: ");
                                newElemList = Console.ReadLine();
                                arrayList[index] = newElemList;

                                Console.WriteLine("\nИ вот что сейчас: ");
                                foreach (var elem in arrayList) Console.Write($"{elem} ");
                                Console.WriteLine();

                                Skip();
                                justDoIt = 0;
                                break;
                            case 2:
                                Console.WriteLine("--Count--\n");

                                Console.WriteLine("Что в ArrayList сейчас: ");
                                foreach (var elem in arrayList) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Console.WriteLine($"Кол-во элементов в ArrayList: {arrayList.Count}");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 3:
                                Console.WriteLine("--BinarySearch--\n");

                                ArrayList forBinSearchList = new ArrayList();
                                forBinSearchList = (ArrayList)arrayList.Clone();
                                forBinSearchList.Sort();

                                Console.WriteLine("ArrayList для бинарного поиска: ");
                                foreach (var elem in forBinSearchList) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Console.Write($"Введие искомый элемент: ");
                                var findElem = Console.ReadLine();

                                Console.WriteLine($"\nИндекс введённого элемента: {forBinSearchList.BinarySearch(findElem)}");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 4:
                                Console.WriteLine("--Copy--\n");

                                var arrayListCopy = new string[arrayList.Count - 1];
                                arrayList.CopyTo(2, arrayListCopy, 1, 3);

                                Console.WriteLine("Что в ArrayList сейчас: ");
                                foreach (var elem in arrayList) Console.Write($"{elem} ");
                                Console.WriteLine("\n");
                                Console.WriteLine("И вот что в скопированном: ");
                                foreach (var elem in arrayListCopy) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 5:
                                Console.WriteLine("--IndexOf--\n");

                                Console.WriteLine("Что в ArrayList сейчас: ");
                                foreach (var elem in arrayList) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Console.Write($"Введие искомый элемент: ");
                                findElem = Console.ReadLine();
                                
                                Console.WriteLine($"\nИндекс искомого элемента: {arrayList.IndexOf(findElem)}");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 6:
                                Console.WriteLine("--Insert--\n");

                                Console.WriteLine("Что в ArrayList сейчас: ");
                                foreach (var elem in arrayList) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                while (true) {
                                    Console.Write($"Введие индекс элемента для добавления <int>: ");
                                    if (int.TryParse(Console.ReadLine(), out index)) break;
                                }

                                Console.Write($"Введие новый элемент: ");
                                newElemList = Console.ReadLine();
                                
                                arrayList.Insert(index, newElemList);

                                Console.WriteLine("\nИтог: ");
                                foreach (var elem in arrayList) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 7:
                                Console.WriteLine("--Reverse--\n");

                                Console.WriteLine("Что в ArrayList сейчас: ");
                                foreach (var elem in arrayList) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                arrayList.Reverse();

                                Console.WriteLine("Перевёрнутый ArrayList: ");
                                foreach (var elem in arrayList) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 8:
                                Console.WriteLine("--Sort--\n");

                                Console.WriteLine("Что в ArrayList сейчас: ");
                                foreach (var elem in arrayList) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                arrayList.Sort();

                                Console.WriteLine("Сортированный ArrayList: ");
                                foreach (var elem in arrayList) Console.Write($"{elem} ");
                                Console.WriteLine("\n");

                                Skip();
                                justDoIt = 0;
                                break;
                            case 9:
                                typeOf = 0;
                                justDoIt = 0;
                                break;
                        }
                    }
                    break;
                case 3:
                    while (true) {     
                        Console.Clear();
                        if (typeOf == 0) break;
                        switch (justDoIt) {
                            case 0:
                                Console.WriteLine("--SortedList--");

                                top = Console.CursorTop;
                                y = top;

                                Console.WriteLine("* EditElement");
                                Console.WriteLine("* Count");
                                Console.WriteLine("* BinarySearch");
                                Console.WriteLine("* Copy");
                                Console.WriteLine("* Find");
                                Console.WriteLine("* FindLast");
                                Console.WriteLine("* IndexOf");
                                Console.WriteLine("* Reverse");
                                Console.WriteLine("* Resize");
                                Console.WriteLine("* Sort");
                                Console.WriteLine("* Назад");

                                down = Console.CursorTop;
                                justDoIt = Choose(ref top, ref y, ref down) + 1;
                                break;
                            case 1:
                                Console.WriteLine("--EditElement--\n");

                                Console.WriteLine("Что в SortedList сейчас: ");
                                foreach (DictionaryEntry  elem in arraySorted) Console.WriteLine($"key: {elem.Key} value: {elem.Value}");

                                int index, newElem;
                                while (true) {
                                    Console.Write($"\nВведие индекс элемента для изменения <int>: ");
                                    if (int.TryParse(Console.ReadLine(), out index))
                                    if (index < array.Length) break;
                                }

                                while (true) {
                                    Console.Write($"Введие новый элемент <int>: ");
                                    if (int.TryParse(Console.ReadLine(), out newElem)) break;
                                }
                                array[index] = newElem;

                                Console.WriteLine("\nИ вот что сейчас: ");
                                foreach (var elem in array) Console.Write($"{elem} ");
                                Console.WriteLine();

                                Skip();
                                justDoIt = 0;
                                break;
                            case 11:
                                typeOf = 0;
                                justDoIt = 0;
                                break;
                        }
                    }
                    break;
            } 
        }   
    }

    static void Skip() {
        Console.Write("Нажмите для продолжения...");
        Console.ReadLine();
    }

    static public int Choose(ref int top, ref int y, ref int down) {
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