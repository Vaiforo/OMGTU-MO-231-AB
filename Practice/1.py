def print_all(tree, nach):
    out = []
    if nach in tree:
        for person in tree[nach]:
            out += [person]
            out += print_all(tree, person)
        return out
    else:
        return out


def prog(file_in):
    last_nach = ""
    tree = {}
    persons = {}
    ok = False
    for line in file_in.readlines():
        line = line.rstrip("\n")
        if ok:
            nach = line
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
        persons[line[:4]] = "Unknown Name" \
            if len(line.split()) == 1 else line[5:]
    if nach not in persons:
        for person in persons:
            if nach == persons[person]:
                nach = person
    print(nach)
    out = sorted(print_all(tree, nach))
    print(persons)
    print(tree)
    print(out)


for i in range(4, 5):
    name = "0" + str(i) if len(str(i)) == 1 else str(i)
    with open(f"Компания ХХХ\input_s1_{name}.txt", encoding="utf8") as file:
        f_in = file
        with open(f"Компания ХХХ\output_s1_{name}.txt", encoding="utf8") as file:
            # input_nach = file.readline()
            print(prog(f_in))
