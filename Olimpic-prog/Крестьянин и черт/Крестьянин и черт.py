def prog(n):
    money = n
    i = 2
    while (2 ** i) - 1 <= n:
        money += n // ((2 ** i) - 1)
        i += 1
    return money


for i in range(1, 9):
    with open(f"Крестьянин и черт\input{i}.txt", encoding="utf8") as file:
        num = int(file.readline())
    with open(f"Крестьянин и черт\output{i}.txt", encoding="utf8") as file:
        out = int(file.readline())
        print(i)
        print(num, out, prog(num))
        print(prog(num) == out)
        print()
