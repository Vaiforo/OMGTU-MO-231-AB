grafs = [
    [1, 4],
    [2, 4],
    [6, 4],
    [5, 4],
    [3, 5],
    [7, 5],
    [7, 6],
    [8, 9],
    [9, 10],
    [8, 10],
]
grafs = sorted(list(map(lambda x: sorted(x), grafs)))

white_list = [i for i in range(grafs[0][0], grafs[-1][-1] + 1)]
grey_list, black_list = [], []


def give_grafs(x: int) -> list:
    out: list = []
    for loc_graf in grafs:
        if x in loc_graf:
            out.append(loc_graf[0] if x != loc_graf[0] else loc_graf[1])
    return out


def find_components_1(x: int, grey: set) -> set:
    for near_graf in give_grafs(x):
        if near_graf not in black_list:
            black_list.append(near_graf)
            grey.add(near_graf)
            grey.union(find_components_1(near_graf, grey))
    return grey


for graf in white_list:
    if graf not in black_list:
        black_list.append(graf)
        grey_list.append(list(find_components_1(graf, {graf})))

print(grey_list)
