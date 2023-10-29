def prog(nums):
    x, y, L, c1, c2, c3, c4, c5, c6 = nums
    x, y = x * 2, y * 2
    ready = [(c4 + c5) * (x + y) + (c6 + c2) * L]
    suma = []
    if c1 < c2 + c3 or c1 < c4 + c5:
        suma += [c1 * max([x // 2, y // 2]) if L > max([x // 2, y // 2]) else L * c1]
        if L > max([x // 2, y // 2]):
            L -= max([x // 2, y // 2])
            if x > y:
                x //= 2
            else:
                y //= 2
        else:
            if x > y:
                x -= L
                L = 0
            else:
                y -= L
                L = 0
    for _ in range(3):
        if (c2 + c3 < c1 or c2 + c3 < c4 + c5) and L and (x or y):
            if x >= L:
                x -= L
                suma += [(c2 + c3) * L]
                L = 0
            elif y >= L:
                y -= L
                suma += [(c2 + c3) * L]
                L = 0
            else:
                if x < y:
                    l = L
                    Y = y
                    y -= L - x
                    L -= x + Y - y
                    x = 0
                    if y < 0:
                        L = abs(y)
                        y = 0
                    suma += [(c2 + c3) * (l - L)]
                else:
                    l = L
                    X = x
                    x -= L - y
                    L -= y + X - x
                    y = 0
                    if x < 0:
                        L = abs(x)
                        x = 0
                    suma += [(c2 + c3) * (l - L)]
        else:
            break
    print(x, y, L)
    suma += [(c4 + c5) * (x + y) + L * (c6 + c2)]


    ready += [sum(suma)]
    print(*ready, suma)

    return min(ready)


for i in range(14, 15):
    name = "0" + str(i) if len(str(i)) == 1 else str(i)
    with open(f"Постройка дома\input_s1_{name}.txt", encoding="utf8") as file:
        numbers = list(map(int, file.readline().split()))
    with open(f"Постройка дома\output_s1_{name}.txt", encoding="utf8") as file:
        check_out = int(file.readline())
    print(i, numbers, check_out)
    print(prog(numbers) == check_out)
