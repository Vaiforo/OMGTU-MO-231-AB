def prog(N, nums):
    out, out_n = 10 ** 10000, 0
    for i in range(N):
        x1, y1, z1, x2, y2, z2, cost1, cost2 = nums[i]
        k1 = 2 * (x1 * y1 + y1 * z1 + x1 * z1)
        k2 = 2 * (x2 * y2 + y2 * z2 + x2 * z2)
        total_cost = (cost1 - cost2 * k1 / k2) / (x1 * y1 * z1 - x2 * y2 * z2 * k1 / k2) * 1000
        if out > total_cost:
            out, out_n = total_cost, i + 1
    return round(out, 2), out_n


for i in range(1, 11):
    with open(f"Упаковки молока\input{i}.txt", encoding="utf8") as file:
        data = file.readlines()
        N = int(data[0].rstrip('\n'))
        nums = []
        for strok in data[1:]:
            nums += [list(map(float, strok.rstrip('\n').split()))]
    with open(f"Упаковки молока\output{i}.txt", encoding="utf8") as file:
        data = file.readline().split()
        check_out1, check_out2 = int(data[0]), float(data[1])
        num2, num1 = prog(N, nums)
        print(i)
        print(N, nums)
        print(num1, num2, check_out1, check_out2)
        print(num1 == check_out1 and num2 == check_out2)
        print()
