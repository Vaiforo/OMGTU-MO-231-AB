using System.Collections;

public class PlaySortedList {
    static public void PrintSortedList(SortedList array, string title) {
        Console.WriteLine(title);
        foreach (DictionaryEntry elem in array) Console.WriteLine($"key: {elem.Key} value: {elem.Value}");
        Console.WriteLine();
    }

    static public void Add(SortedList array) {
        PrintSortedList(array, "Что в SortedList сейчас: ");

        Console.Write($"Введие ключ элемента для добавления: ");
        string key = Console.ReadLine();

        Console.Write($"Введие новый элемент: ");
        array[key] = Console.ReadLine();

        PrintSortedList(array, "\nИ вот что сейчас: ");
    }

    static public void IndexOfByKey(SortedList array) {
        PrintSortedList(array, "Что в SortedList сейчас: ");

        Console.Write($"Введие ключ для поиска: ");
        Console.WriteLine($"Ответ: {array.IndexOfKey(Console.ReadLine())}");
    }

    static public void IndexOfByValue(SortedList array) {
        PrintSortedList(array, "Что в SortedList сейчас: ");

        Console.Write($"Введие значение для поиска: ");
        Console.WriteLine($"Ответ: {array.IndexOfValue(Console.ReadLine())}");
    }

    static public void KeyByIndex(SortedList array) {
        PrintSortedList(array, "Что в SortedList сейчас: ");

        int index;
        while (true) {
            Console.Write($"Введие индекс <int>: ");
            if (int.TryParse(Console.ReadLine(), out index))
            if (index < array.Count && index >= 0) break;
        }
        IList keys = array.GetKeyList();
        Console.WriteLine($"Ответ: {keys[index]}");
    }

    static public void ValueByIndex(SortedList array) {
        PrintSortedList(array, "Что в SortedList сейчас: ");

        int index;
        while (true) {
            Console.Write($"Введие индекс <int>: ");
            if (int.TryParse(Console.ReadLine(), out index))
            if (index < array.Count && index >= 0) break;
        }
        Console.WriteLine($"Ответ: {array.GetByIndex(index)}");
    }
}