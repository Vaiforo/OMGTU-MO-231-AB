operations = [
    ['+', 2],
    ['*', 3],
    ['-', 5],
    ['-', 'x'],
]
n = 4
out = 7

now = [1, 0]
for operation in operations:
    if operation[0] == '-':
        if operation[1] != 'x':
            now[1] -= operation[1]
        else:
            now[0] -= 1
    elif operation[0] == '+':
        if operation[1] != 'x':
            now[1] += operation[1]
        else:
            now[0] += 1
    elif operation[0] == '*':
        now = list(map(lambda x: x * operation[1], now))
print((out - now[1]) // now[0])
