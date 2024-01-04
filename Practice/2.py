def prog(n):
    m = 0
    if n >= 3:
        p = 1
        while p <= n // 2:
            if n <= p + p / 2:
                m = n - p
            else:
                m = 2 * p - n
            p *= 2
    return abs(m)


for i in range(1, 11):
    name = "0" + str(i) if len(str(i)) == 1 else str(i)
    with open(f"Отбор в разведку\input_s1_{name}.txt", encoding="utf8") as file:
        num = int(file.readline())
    with open(f"Отбор в разведку\output_s1_{name}.txt", encoding="utf8") as file:
        check_out = int(file.readline())
    print(i, num, check_out)
    print(prog(num), prog(num) == check_out)
