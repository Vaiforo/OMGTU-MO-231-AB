def prog(nums):
    n_start_c = nums[0]
    k_start_a = nums[1]
    n_end_d = nums[2]
    k_end_b = nums[3]
    n_start_e = nums[4]
    for i in range(len(n_start_e)):
        for j in range(k_start_a[0]):
            if n_start_e[i] > k_start_a[j + 1]:
                n_start_e[i] -= 1
        if i != len(n_start_e) - 1:
            n_start_e[i] *= n_start_c[i + 1]

    t = sum(n_start_e)
    c = []
    m = n_end_d[0] - 1
    del n_end_d[0]
    n2 = sorted(n_end_d)
    for i in range(m):
        c.insert(0, t % n2[i])
        t = t // n2[i]
    c.insert(0, t)
    for i in range(len(k_end_b) - 1):
        for j in range(len(c)):
            if c[j] > k_end_b[i + 1]:
                c[j] += 1
    return c


for i in range(1, 15):
    with open(f"Обмен денег\input{i}.txt", encoding="utf8") as file:
        data = file.readlines()
        data = list(map(lambda x: list(map(int, x.rstrip('\n').split())), data))
    with open(f"Обмен денег\output{i}.txt", encoding="utf8") as file:
        out = list(map(int, file.readline().split()))
        print(i)
        res = prog(data)
        print(out, res)
        print(res == out)
        print()
