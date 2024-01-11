def prog(num):
    if num < 3:
        return 0
    if num == 3:
        return 1
    n = 1
    while n <= num // 2:
        n *= 2
    if num <= n + n // 2:
        out = num - n
    else:
        out = 2 * n - num
    return out


for i in range(1, 11):
    strok = f"0{i}" if i < 10 else i
    with open(f"Отбор в разведку\input_s1_{strok}.txt", encoding="utf8") as file:
        num = int(file.readline())
    with open(f"Отбор в разведку\output_s1_{strok}.txt", encoding="utf8") as file:
        out = int(file.readline())
        print(i)
        print(num, out, prog(num))
        print(prog(num) == out)
        print()
