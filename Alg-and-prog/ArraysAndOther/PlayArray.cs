using System.Collections;

public class PlayArray {
    static public void PrintArray(Array array, string title) {
        Console.WriteLine(title);
        foreach (int elem in array) Console.Write($"{elem} ");
        Console.WriteLine("\n");
    }
    
    static public void PrintArray(int[] array, string title) {
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
            if (index < array.Length && index >= 0) break;
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
        
        int[] arrayInt = (int[])array;
        
        Console.WriteLine($"Кол-во четных элементов: {arrayInt.Count(x => x % 2 == 0)}");
    }

    static public void BinarySearch(Array array) {
        int[] forBinSearch = new int[array.Length];
        Array.Copy(array, forBinSearch, array.Length);
        Array.Sort(forBinSearch);

        PrintArray(forBinSearch, "Array для бинарного поиска: ");

        int findElem;
        while (true) {
            Console.Write($"Введие искомый элемент <int>: ");
            if (int.TryParse(Console.ReadLine(), out findElem)) break;
        }

        Console.WriteLine($"\nИндекс введённого элемента: {Array.BinarySearch(forBinSearch, findElem)}");
    }

    static public void Copy(Array array) {
        int[] copyArray = new int[array.Length];
        Array.Copy(array, copyArray, array.Length);

        PrintArray(array, "Что в Array сейчас: ");
        
        PrintArray(copyArray, "И вот что в скопированном: ");
    }

    static public void Find(Array array) {
        PrintArray(array, "Что в Array сейчас: ");
        
        int findElem = Array.Find((int[])array, x => x % 2 == 0 && x % 3 == 0);
        Console.WriteLine($"Первый элемент который делится на 2 и на 3: {findElem}");
    }

    static public void FindLast(Array array) {
        PrintArray(array, "Что в Array сейчас: ");
        
        int findElem = Array.FindLast((int[])array, x => x % 2 == 0 && x % 4 == 0);
        Console.WriteLine($"Последний элемент который делится на 2 и на 4: {findElem}");
    }

    static public void IndexOf(Array array) {
        PrintArray(array, "Что в Array сейчас: ");

        int findElem;
        while (true) {
            Console.Write($"Введие искомый элемент <int>: ");
            if (int.TryParse(Console.ReadLine(), out findElem)) break;
        }
        
        Console.WriteLine($"\nИндекс искомого элемента: {Array.IndexOf(array, findElem)}");
    }

    static public void Reverse(Array array) {
        PrintArray(array, "Что в Array сейчас: ");

        Array.Reverse(array);

        PrintArray(array, "Перевёрнутый Array: ");
    }

    static public void Resize(Array array) {
        PrintArray(array, "Что в Array сейчас: ");

        int newSize;
        while (true) {
            Console.Write($"Введие новую длину <int>: ");
            if (int.TryParse(Console.ReadLine(), out newSize))
            if (newSize > 0) break;
        }

        var arrayInt = (int[])array;
        Array.Resize(ref arrayInt, newSize);

        PrintArray(arrayInt, "Array после с измененным размером: ");
    }

    static public void Sort(Array array) {
        PrintArray(array, "Что в Array сейчас: ");

        Array.Sort(array);

        PrintArray(array, "Сортированный Array: ");
    }
}