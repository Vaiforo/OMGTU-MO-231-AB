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
# grafs = [[2, 1, 2],
#          [9, 2, 4],
#          [5, 4, 6],
#          [17, 6, 8],
#          [17, 7, 8],
#          [9, 5, 7],
#          [7, 1, 5],
#          [2, 1, 3],
#          [2, 2, 3],
#          [5, 3, 5],
#          [2, 2, 5],
#          [10, 4, 5],
#          [2, 4, 7],
#          [16, 4, 8],
#          ]
grafs.sort(key=lambda x: x[0])

out_grafs, was_checked = [], set()
was_checked.add(grafs[0][1])
was_checked.add(grafs[0][2])
out_grafs += [grafs[0]]

maxe = max(grafs, key=lambda x: x[1:])
while len(was_checked) != max(maxe[1:]):
    for graf in grafs[1:]:
        if (graf[1] not in was_checked and graf[2] in was_checked) or \
                (graf[1] in was_checked and graf[2] not in was_checked):
            was_checked.add(graf[1])
            was_checked.add(graf[2])
            out_grafs += [graf]
            break

print(was_checked, out_grafs)
print(sum(list(map(lambda x: x[0], out_grafs))))
