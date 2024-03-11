def prog(operations: list, result: int) -> int:
    now: list = [1, 0]
    for operation in operations:
        if operation[1] == 'x':
            now[0] += 1 if operation[0] == '+' else -1
        elif operation[0] != '*':
            now[1] += int(operation[1]) if operation[0] == '+' else -int(operation[1])
        elif operation[0] == '*':
            now = list(map(lambda x: x * int(operation[1]), now))
    return (result - now[1]) // now[0]


for i in range(1, 13):
    strok: str = f"0{i}" if i < 10 else i
    with open(f"Отгадай число\input_s1_{strok}.txt", encoding="utf8") as file:
        data: list = file.readlines()
        res: int = int(data[-1].rstrip('\n'))
        data = list(map(lambda x: x.rstrip('\n').split(), data[1:-1]))
    with open(f"Отгадай число\output_s1_{strok}.txt", encoding="utf8") as file:
        out = float(file.readline())
        print(i)
        prog_res = prog(data, res)
        print(data, res)
        print(out, prog_res)
        print(prog_res == out)
        print()
