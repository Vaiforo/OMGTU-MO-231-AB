using System.Collections;

public class PlayArrayList {
    static public void PrintArrayList(ArrayList array, string title) {
        Console.WriteLine(title);
        foreach (var elem in array) Console.Write($"{elem} ");
        Console.WriteLine("\n");
    }

    static public void EditElement(ArrayList array) {
        PrintArrayList(array, "Что в ArrayList сейчас: ");

        int index;
        while (true) {
            Console.Write($"Введие индекс элемента для изменения <int>: ");
            if (int.TryParse(Console.ReadLine(), out index))
            if (index < array.Count && index >= 0) break;
        }

        Console.Write($"Введие новый элемент: ");
        array[index] = Console.ReadLine();

        PrintArrayList(array, "\nИ вот что сейчас: ");
    }

    static public void Count(ArrayList array) {
        PrintArrayList(array, "Что в ArrayList сейчас: ");

        Console.WriteLine($"Кол-во элементов в ArrayList: {array.Count}");
    }

    static public void BinarySearch(ArrayList array) {
        ArrayList forBinSearchList = (ArrayList)array.Clone();
        forBinSearchList.Sort();

        PrintArrayList(forBinSearchList, "ArrayList для бинарного поиска: ");

        Console.Write($"Введие искомый элемент: ");
        Console.WriteLine($"\nИндекс введённого элемента: {forBinSearchList.BinarySearch(Console.ReadLine())}");
    }

    static public void Copy(ArrayList array) {
        var arrayListCopy = new string[array.Count - 1];
        array.CopyTo(1, arrayListCopy, 1, 3);

        PrintArrayList(array, "Что в ArrayList сейчас: ");
        
        PrintArrayList(new ArrayList(arrayListCopy), "И вот что в скопированном (3 элемента, начиная с 1 индекса из старого списка, вставлены с 1 индекса во второй): ");
    }

    static public void IndexOf(ArrayList array) {
        PrintArrayList(array, "Что в ArrayList сейчас: ");

        Console.Write($"Введие искомый элемент: ");
        Console.WriteLine($"\nИндекс искомого элемента: {array.IndexOf(Console.ReadLine())}");
    }

    static public void Insert(ArrayList array) {
        PrintArrayList(array, "Что в ArrayList сейчас: ");

        int index;
        while (true) {
            Console.Write($"Введие индекс элемента для добавления <int>: ");
            if (int.TryParse(Console.ReadLine(), out index))
            if (index < array.Count && index >= 0) break;
        }

        Console.Write($"Введие новый элемент: ");
        array.Insert(index, Console.ReadLine());

        PrintArrayList(array, "\nИтог: ");
    }

    static public void Reverse(ArrayList array) {
        PrintArrayList(array, "Что в ArrayList сейчас: ");

        array.Reverse();

        PrintArrayList(array, "Перевёрнутый ArrayList: ");
    }

    static public void Sort(ArrayList array) {
        PrintArrayList(array, "Что в ArrayList сейчас: ");

        array.Sort();

        PrintArrayList(array, "Сортированный ArrayList: ");
    }

    static public void Add(ArrayList array) {
        PrintArrayList(array, "Что в ArrayList сейчас: ");

        Console.Write($"Введие новый элемент: ");
        array.Add(Console.ReadLine());

        PrintArrayList(array, "\nИ вот что сейчас: ");
    }
}