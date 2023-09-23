def prog(nums):
    x, y, L, c1, c2, c3, c4, c5, c6 = nums
    x, y = x * 2, y * 2
    ready = [[(c4 + c5) * (x + y) + c6 * L]]
    suma = []
    if c1 < c2 + c3 or c1 < c4 + c5:
        suma += [c1 * max([x // 2, y // 2]) if L < max([x // 2, y // 2]) else L * c1]
        if L < max([x // 2, y // 2]):
            L -= max([x // 2, y // 2])
        else:
            if x > y:
                x -= L
            else:
                y -= L
    elif c2 + c3 < c1 or c2 + c3 < c4 + c5:
        suma += [(c2 + c3) * L]
        if x >= L:
            x -= L
        elif y >= L:
            y -= L
        else:
            if x < y:
                y -= L - x
                x = 0
            else:
                x -= L - y
                y = 0
    if c4 + c5 < c1:
        suma += [(c4 + c5) * (x + y)]
    elif c4 + c5 < c2 + c3:
        suma += [(c4 + c5) * (x + y)]



    print(suma)

    return min(ready, key=sum)


for i in range(1, 2):
    name = "0" + str(i) if len(str(i)) == 1 else str(i)
    with open(f"Постройка дома\input_s1_{name}.txt", encoding="utf8") as file:
        numbers = list(map(int, file.readline().split()))
        print(numbers)
    with open(f"Постройка дома\output_s1_{name}.txt", encoding="utf8") as file:
        check_out = int(file.readline())
        print(check_out)
    print(prog(numbers) == check_out)
