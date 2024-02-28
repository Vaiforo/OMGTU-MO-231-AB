roads = [
    ["С", "К", 26],
    ["С", "П", 19],
    ["С", "Р", 86],
    ["К", "Д", 16],
    ["К", "Л", 66],
    ["П", "Н", 4],
    ["П", "В", 51],
    ["Д", "В", 21],
    ["Н", "М", 21],
    ["М", "Л", 24],
    ["М", "В", 34],
    ["Л", "А", 13],
    ["Л", "Ж", 43],
    ["А", "Б", 25],
    ["Ж", "Р", 31],
    ["Ж", "Б", 44],
    ["Б", "Р", 22],
    ["В", "Ж", 9],
]

tree = {}
for road in roads:
    tree[road[0]] = tree[road[0]] + [road[1]] if road[0] in tree else [road[1]]
    tree[road[1]] = tree[road[1]] + [road[0]] if road[1] in tree else [road[0]]

roads_tree = {}
blocked = []

road_lens = sorted(list(map(lambda x: [x[0] if x[1] == "С" else x[1], x[2]],
                            filter(lambda x: "С" in x, roads))), key=lambda x: x[1])
for graf in road_lens:
    if graf not in blocked:
        if graf[0] not in roads_tree:
            roads_tree[graf[0]] = graf[1]
        else:
            

