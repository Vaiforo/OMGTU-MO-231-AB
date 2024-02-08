class Graph:
    def __init__(self, vertices):
        self.V = vertices  # Количество вершин графа
        self.graph = []  # Список ребер графа

    def add_edge(self, u, v, w):
        # Добавляем ребро в граф
        self.graph.append([u, v, w])

    def find(self, parent, i):
        # Находим корневую вершину для вершины i
        if parent[i] == i:
            return i
        return self.find(parent, parent[i])

    def union(self, parent, rank, x, y):
        # Объединяем два подмножества по рангу
        x_root = self.find(parent, x)
        y_root = self.find(parent, y)

        if rank[x_root] < rank[y_root]:
            parent[x_root] = y_root
        elif rank[x_root] > rank[y_root]:
            parent[y_root] = x_root
        else:
            parent[y_root] = x_root
            rank[x_root] += 1

    def kraskal_mst(self):
        result = []  # Инициализация списка для хранения MST
        i = 0
        e = 0

        # Сортируем ребра по весу
        self.graph = sorted(self.graph, key=lambda item: item[2])

        parent = []  # Массив для хранения родительских вершин
        rank = []  # Массив для хранения рангов вершин

        # Инициализируем родительские вершины и ранги
        for node in range(self.V):
            parent.append(node)
            rank.append(0)

        # Пока не добавлено (V-1) ребро
        while e < self.V - 1:
            u, v, w = self.graph[i]  # Получаем вершины и вес ребра
            i = i + 1

            # Находим корневые вершины для текущих вершин
            x = self.find(parent, u)
            y = self.find(parent, v)

            # Если ребро не создает цикл, добавляем его в MST
            if x != y:
                e = e + 1
                result.append([u, v, w])
                self.union(parent, rank, x, y)

        # Выводим ребра в MST и их стоимость
        minimum_cost = 0
        print("Edges in the constructed MST:")
        for u, v, weight in result:
            minimum_cost += weight
            print(f"{u} -- {v} == {weight}")
        print(f"Minimum Spanning Tree Cost: {minimum_cost}")


# Пример использования
g = Graph(9)
g.add_edge(0, 1, 15)
g.add_edge(0, 4, 14)
g.add_edge(0, 3, 23)
g.add_edge(1, 2, 19)
g.add_edge(1, 3, 16)
g.add_edge(1, 4, 15)
g.add_edge(2, 4, 14)
g.add_edge(2, 5, 26)
g.add_edge(3, 4, 25)
g.add_edge(3, 6, 23)
g.add_edge(3, 7, 20)
g.add_edge(4, 5, 24)
g.add_edge(4, 7, 27)
g.add_edge(4, 8, 18)
g.add_edge(6, 7, 14)
g.add_edge(7, 8, 18)

g.kraskal_mst()
