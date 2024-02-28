using System.Collections;

public class PlayArray {
    static public void PrintArray(Array array, string title) {
        Console.WriteLine(title);
        foreach (int elem in array) Console.Write($"{elem} ");
        Console.WriteLine("\n");
    }

    static public void EditElement(Array array) {
        PrintArray(array, "Что в Array сейчас: ");

        int index, newElem;
        while (true) {
            Console.Write($"Введие индекс элемента для изменения <int>: ");
            if (int.TryParse(Console.ReadLine(), out index))
            if (index < array.GetLength(0) && index >= 0) break;
        }

        while (true) {
            Console.Write($"Введие новый элемент <int>: ");
            if (int.TryParse(Console.ReadLine(), out newElem)) break;
        }
        array.SetValue(newElem, index);

        PrintArray(array, "\nИ вот что сейчас: ");
    }

    static public void Count(Array array) {
        PrintArray(array, "Что в Array сейчас: ");
        
        // Console.WriteLine($"Кол-во четных элементов: {array.Count}");
    }

    static public void BinarySearch(Array array) {
        // int[] forBinSearch = new int[array.Length];
        // Array.Copy(array, forBinSearch, array.Length);
        // Array.Sort(forBinSearch);

        // Console.WriteLine("Array для бинарного поиска: ");
        // foreach (var elem in forBinSearch) Console.Write($"{elem} ");
        // Console.WriteLine("\n");

        // int findElem;
        // while (true) {
        //     Console.Write($"Введие искомый элемент <int>: ");
        //     if (int.TryParse(Console.ReadLine(), out findElem)) break;
        // }

        // Console.WriteLine($"\nИндекс введённого элемента: {Array.BinarySearch(forBinSearch, findElem)}");
        Console.WriteLine("pass");
    }

    static public void Copy(Array array) {
        // int[] copyArray = new int[array.Length];
        // Array.Copy(array, copyArray, array.Length);

        // Console.WriteLine("Что в Array сейчас: ");
        // foreach (var elem in array) Console.Write($"{elem} ");
        // Console.WriteLine("\n");
        // Console.WriteLine("И вот что в скопированном: ");
        // foreach (var elem in copyArray) Console.Write($"{elem} ");
        // Console.WriteLine("\n");
        Console.WriteLine("pass");
    }

    static public void Find(Array array) {
        // Console.WriteLine("Что в Array сейчас: ");
        // foreach (var elem in array) Console.Write($"{elem} ");
        // Console.WriteLine("\n");
        
        // findElem = Array.Find(array, x => x % 2 == 0 && x % 3 == 0);
        // Console.WriteLine($"Первый элемент который делится на 2 и на 3: {findElem}");
        Console.WriteLine("pass");
    }

    static public void FindLast(Array array) {
        // Console.WriteLine("Что в Array сейчас: ");
        // foreach (var elem in array) Console.Write($"{elem} ");
        // Console.WriteLine("\n");
        
        // findElem = Array.FindLast(array, x => x % 2 == 0 && x % 4 == 0);
        // Console.WriteLine($"Последний элемент который делится на 2 и на 4: {findElem}");
        Console.WriteLine("pass");
    }

    static public void IndexOf(Array array) {
        // Console.WriteLine("Что в Array сейчас: ");
        // foreach (var elem in array) Console.Write($"{elem} ");
        // Console.WriteLine("\n");

        // while (true) {
        //     Console.Write($"Введие искомый элемент <int>: ");
        //     if (int.TryParse(Console.ReadLine(), out findElem)) break;
        // }
        
        // Console.WriteLine($"\nИндекс искомого элемента: {Array.IndexOf(array, findElem)}");
        Console.WriteLine("pass");
    }

    static public void Reverse(Array array) {
        // Console.WriteLine("Что в Array сейчас: ");
        // foreach (var elem in array) Console.Write($"{elem} ");
        // Console.WriteLine("\n");

        // Array.Reverse(array);

        // Console.WriteLine("Перевёрнутый Array: ");
        // foreach (var elem in array) Console.Write($"{elem} ");
        // Console.WriteLine("\n");
        Console.WriteLine("pass");
    }

    static public void Resize(Array array) {
        // Console.WriteLine("Что в Array сейчас: ");
        // foreach (var elem in array) Console.Write($"{elem} ");
        // Console.WriteLine("\n");

        // int newSize;
        // while (true) {
        //     Console.Write($"Введие новую длину <int>: ");
        //     if (int.TryParse(Console.ReadLine(), out newSize))
        //     if (newSize > 0) break;
        // }
        // Array.Resize(ref array, newSize);

        // Console.WriteLine("Array после с измененным размером: ");
        // foreach (var elem in array) Console.Write($"{elem} ");
        // Console.WriteLine("\n");
        Console.WriteLine("pass");
    }

    static public void Sort(Array array) {
        // Console.WriteLine("Что в Array сейчас: ");
        // foreach (var elem in array) Console.Write($"{elem} ");
        // Console.WriteLine("\n");

        // Array.Sort(array);

        // Console.WriteLine("Сортированный Array: ");
        // foreach (var elem in array) Console.Write($"{elem} ");
        // Console.WriteLine("\n");
        Console.WriteLine("pass");
    }
}