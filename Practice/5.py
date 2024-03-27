def prog(input_data):
    pos1 = int(input_data[0]) + 1
    magic_words = []
    for j in range(1, pos1):
        magic_words.append(input_data[j])
    f_crit = []
    pos2 = pos1 + int(input_data[pos1]) + 1
    for j in range(pos1 + 1, pos2):
        f_crit.append(input_data[j])
    pos1 = pos2
    pos2 = pos2 + int(input_data[pos1])
    l_crit = []
    for j in range(pos1 + 1, pos2 + 1):
        l_crit.append(input_data[j])

    n_out = 0
    start_crit = {}
    end_crit = {}

    for elem in f_crit:
        elem = elem.split()
        start_crit[elem[0]] = int(elem[1])
    for elem in l_crit:
        elem = elem.split()
        end_crit[elem[0]] = int(elem[1])

    for elem in magic_words:
        try:
            start_crit[elem[0]] -= 1
            if start_crit[elem[0]] < 0:
                raise KeyError
            try:
                end_crit[elem[-1]] -= 1
                if end_crit[elem[-1]] < 0:
                    raise KeyError
                n_out += 1
            except KeyError:
                start_crit[elem[0]] += 1
        except KeyError:
            pass
    return n_out


for i in range(1, 14):
    strok: str = f"0{i}" if i < 10 else i
    with open(f"Золотая рыбка\input_s1_{strok}.txt", encoding="utf8") as file:
        data = file.readlines()
        data = list(map(lambda x: x.rstrip("\n"), data))
        answer: int = prog(data)
    with open(f"Золотая рыбка\output_s1_{strok}.txt", encoding="utf8") as file:
        data: int = int(file.readline())
        print(i)
        print(f"right: {data} my: {answer}")
        print(data == answer)
        print()
