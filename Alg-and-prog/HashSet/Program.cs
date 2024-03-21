class HashSetTester {
    static void Main() {
        HashSet<int> hashSet1 = new(){1, 2, 3, 4, 7, 8, 10};  // Всегда больше всего элементов
        HashSet<int> hashSet2 = new(){1, 3, 4, 6, 7, 9};
        HashSet<int> hashSet3 = new(){1, 3, 4, 5, 6};  // Всегда меньше всего элементов

        DisplaySet(hashSet1, "Hashset 1:", false);
        DisplaySet(hashSet2, "Hashset 2:", false);
        DisplaySet(hashSet3, "Hashset 3:", true);

        // Пересечение

        HashSet<int> intersection = new(hashSet1);
        intersection.IntersectWith(hashSet2);
        intersection.IntersectWith(hashSet3);

        DisplaySet(intersection, "Пересечение:", true);

        // Объединение

        HashSet<int> union = new(hashSet1);
        union.UnionWith(hashSet2);
        union.UnionWith(hashSet3);

        DisplaySet(union, "Объединение:", true);

        // Дополнение

        HashSet<int> addition1 = new(union);
        bool inHashset1(int i) => hashSet1.Contains(i);
        addition1.RemoveWhere(inHashset1);

        DisplaySet(addition1, "Дополнение к 1:", true);

        HashSet<int> addition2 = new(union);
        bool inHashset2(int i) => hashSet2.Contains(i);
        addition2.RemoveWhere(inHashset2);

        DisplaySet(addition2, "Дополнение к 2:", true);

        HashSet<int> addition3 = new(union);
        bool inHashset3(int i) => hashSet3.Contains(i);
        addition3.RemoveWhere(inHashset3);

        DisplaySet(addition3, "Дополнение к 3:", true);
    }

    static void DisplaySet(HashSet<int> collection, string message, bool n) {
        Console.WriteLine(message);
        foreach (int item in collection) {
            Console.Write($"{item} ");
        } Console.WriteLine(n ? "\n" : "");
    }
}