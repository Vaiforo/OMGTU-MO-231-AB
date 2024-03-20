class HashSetTester {
    static void Main() {
        HashSet<int> hashSet1 = new(){1, 2, 3, 4, 5, 7, 9};  // Всегда больше всего элементов
        HashSet<int> hashSet2 = new(){1, 2, 3, 8, 10};
        HashSet<int> hashSet3 = new(){4, 5, 6, 7};  // Всегда меньше всего элементов

        HashSet<int> intersection = new();
        foreach (int item in hashSet1) {
            if (hashSet2.Contains(item) && hashSet3.Contains(item)) intersection.Add(item);
        }

        var intersection_auto = hashSet1.IntersectWith(hashSet2).IntersectWith(hashSet3);

        DisplaySet(intersection, intersection_auto, "Пересечение:");
    }

    static void DisplaySet(HashSet<int> collection1, IEnumerable<int> collection2, string message) {
        Console.WriteLine(message);
        Console.WriteLine("Вручную:");
        foreach (int item in collection1) {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\nМетодом:");
        foreach (int item in collection2) {
            Console.Write($"{item} ");
        }
    }
}