grafs = [[15, 1, 2],
         [14, 1, 5],
         [23, 1, 4],
         [19, 2, 3],
         [16, 2, 4],
         [15, 2, 5],
         [14, 3, 5],
         [26, 3, 6],
         [25, 4, 5],
         [23, 4, 7],
         [20, 4, 8],
         [24, 5, 6],
         [27, 5, 8],
         [18, 5, 9],
         [14, 7, 8],
         [18, 8, 9],
         ]

grafs.sort(key=lambda x: x[0])

trees, was_checked, out_grafs = {}, set(), []

for graf in grafs:
    if graf[1] not in was_checked and graf[2] not in was_checked:
        trees[graf[1]] = [graf[1], graf[2]]
        trees[graf[2]] = trees[graf[1]]
    elif graf[1] not in was_checked:
        trees[graf[2]] += [graf[1]]
        trees[graf[1]] = trees[graf[2]]
    elif graf[2] not in was_checked:
        trees[graf[1]] += [graf[2]]
        trees[graf[2]] = trees[graf[1]]
    if graf[1] not in was_checked or graf[2] not in was_checked:
        out_grafs += [graf]
        was_checked.add(graf[1])
        was_checked.add(graf[2])

for graf in grafs:
    if graf[2] not in trees[graf[1]]:
        new_tree = trees[graf[1]] + trees[graf[2]]
        for key in trees:
            if graf[1] in trees[key] or graf[2] in trees[key]:
                trees[key] = new_tree
        out_grafs += [graf]

print(sum(list(map(lambda x: x[0], out_grafs))))
