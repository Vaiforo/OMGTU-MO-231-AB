def prog(nums):
    x, y, L, c1, c2, c3, c4, c5, c6 = nums
    cost = 0

    P = (x + y) * 2
    if L > max(x, y):
        cost = (L - max(x, y)) * c2
        ost = L - max(x, y)
        if c2 + c6 + c4 + c5 > c1 and c2 + c3 > c1:
            cost += max(x, y) * c1
        elif c2 + c6 + c4 + c5 > c2 + c3:
            cost += max(x, y) * (c2 + c3)
        else:
            cost += max(x, y) * (c4 + c5 + c6 + c2)
        P -= max(x, y)
        if c3 < c4 + c5 + c6:
            if ost <= P:
                P -= ost
                cost += ost * c3 + P * (c4 + c5)
            else:
                cost += P * c3 + (ost - P) * c6
                P = 0
        else:
            cost += P * (c4 + c5) + ost * c6
            P = 0
    elif L <= max(x, y):
        if c2 + c3 > c1 and c2 + c6 + c4 + c5 > c1:
            cost += L * c1
        elif c2 + c6 + c4 + c5 > c2 + c3:
            cost += L * (c2 + c3)
        else:
            cost += L * (c4 + c5 + c6 + c2)
        P -= L
        cost += P * (c4 + c5)
    return cost


for i in range(1, 15):
    name = "0" + str(i) if len(str(i)) == 1 else str(i)
    with open(f"Постройка дома\input_s1_{name}.txt", encoding="utf8") as file:
        numbers = list(map(int, file.readline().split()))
    with open(f"Постройка дома\output_s1_{name}.txt", encoding="utf8") as file:
        check_out = int(file.readline())
    print(i, numbers, check_out)
    print(prog(numbers) == check_out)
