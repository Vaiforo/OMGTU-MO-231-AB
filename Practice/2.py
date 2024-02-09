# grafs = [[15, 1, 2],
#          [14, 1, 5],
#          [23, 1, 4],
#          [19, 2, 3],
#          [16, 2, 4],
#          [15, 2, 5],
#          [14, 3, 5],
#          [26, 3, 6],
#          [25, 4, 5],
#          [23, 4, 7],
#          [20, 4, 8],
#          [24, 5, 6],
#          [27, 5, 8],
#          [18, 5, 9],
#          [14, 7, 8],
#          [18, 8, 9],
#          ]
grafs = [[4, 1, 2],
         [2, 2, 3],
         [1, 1, 6],
         [7, 6, 7],
         [2, 7, 3],
         [3, 4, 2],
         [1, 4, 5],
         [7, 5, 3],
         [3, 4, 1],
         [6, 1, 5],
         [4, 5, 3],
         [1, 2, 7],
         [6, 5, 7],
         [3, 4, 7],
         [3, 5, 6],
         [5, 4, 6],
         [6, 2, 6],
         ]

grafs.sort(key=lambda x: x[0])

trees, out_grafs, was_checked = {}, [], set()

for graf in grafs:
    if graf[1] not in was_checked and graf[2] not in was_checked:
        trees[graf[1]] = [graf[1], graf[2]]
        trees[graf[2]] = trees[graf[1]]
    elif graf[1] not in was_checked:
        trees[graf[2]].append(graf[1])
        trees[graf[1]] = trees[graf[2]]
    elif graf[2] not in was_checked:
        trees[graf[1]].append(graf[2])
        trees[graf[2]] = trees[graf[1]]
    if graf[1] not in was_checked or graf[2] not in was_checked:
        out_grafs += [graf]
        was_checked.add(graf[1])
        was_checked.add(graf[2])

for key in trees:
    print(id(trees[key]), key, trees[key])

for graf in grafs:
    if graf[2] not in trees[graf[1]]:
        print(graf)
        # new_tree = trees[graf[1]] + trees[graf[2]]
        # trees[graf[1]], trees[graf[2]] = new_tree, new_tree
        # new_tree = trees[graf[1]]
        # trees[graf[1]] += trees[graf[2]]
        # trees[graf[2]] += new_tree
        trees[graf[1]] += trees[graf[2]]
        trees[graf[2]] += trees[graf[1]]
        out_grafs += [graf]
        for key in trees:
            print(id(trees[key]), key, trees[key])

print(out_grafs)
print(sum(list(map(lambda x: x[0], out_grafs))))

