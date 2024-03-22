from math import inf

grafs = [
    [inf, 1, inf, inf, 3],
    [inf, inf, 8, 7, 1],
    [inf, inf, inf, 1, -5],
    [inf, inf, 2, inf, inf],
    [inf, inf, inf, 4, inf],
]

lambdas = [inf if i > 0 else 0 for i in range(len(grafs))]

for i in range(1, len(grafs)):
    for j in range(1, len(grafs)):
        lambdas[j] = min(list(map(lambda x: lambdas[x] + grafs[x][j], range(len(grafs)))))

print(*lambdas)
