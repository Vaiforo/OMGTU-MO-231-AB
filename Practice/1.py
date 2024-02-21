import sys

sys.setrecursionlimit(10000)


def print_all(tree, nach) -> [...]:
    out: list = []
    if nach in tree:
        for person in tree[nach]:
            out += [person] + print_all(tree, person)
    return out


def prog(file_in, answer, k) -> None:
    last_nach: str = ""
    tree: dict = {}
    persons: dict = {}
    ok: bool = False
    for line in file_in.readlines():
        line: str = line.rstrip("\n")
        if ok:
            nach: str = line
            break
        if line == "END":
            ok = True
            continue
        if last_nach == "":
            last_nach = line[:4]
        else:
            person = line[:4]
            if last_nach not in tree:
                tree[last_nach] = [person]
            else:
                tree[last_nach] += [person]
            last_nach = ""
        if line[:4] not in persons or persons[line[:4]] == "Unknown Name":
            persons[line[:4]] = "Unknown Name" \
                if len(line.split()) == 1 else line[5:]
    if nach not in persons:
        for person in persons:
            if nach == persons[person]:
                nach = person
    out = sorted(print_all(tree, nach))

    # Почти чисто вывод
    if len(out) > 0:
        for i, elem in enumerate(out):
            out[i] = f"{elem} {persons[elem]}\n"
        out[-1] = out[-1].rstrip("\n")
    else:
        out = ["NO"]
    print(
        f"TEST {k} Запрос: {nach} {persons[nach]}\nОтвет  программы: {out}\nПравильный ответ: {answer}\nСовпадение: {out == answer}\n")


for i in range(1, 16):
    name = "0" + str(i) if len(str(i)) == 1 else str(i)
    with open(f"Компания ХХХ\input_s1_{name}.txt", encoding="utf8") as f_in:
        with open(f"Компания ХХХ\output_s1_{name}.txt", encoding="utf8") as file:
            answer = file.readlines()
            prog(f_in, answer, i)
