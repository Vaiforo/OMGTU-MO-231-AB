a = 'Обмен денег\input2.txt'
b = 'Обмен денег\output2.txt'
f = open(a)
line = f.readline().split()
n1 = list(map(int, line))
line = f.readline().split()
k1 = list(map(int, line))
line = f.readline().split()
n2 = list(map(int, line))
line = f.readline().split()
k2 = list(map(int, line))
line = f.readline().split()
c = list(map(int, line))

for i in range(len(c)):
    for j in range(k1[0]):
        if c[i] > k1[j + 1]:
            c[i] -= 1
    if i != len(c) - 1:
        c[i] *= n1[i + 1]

t = sum(c)
c = []
m = n2[0] - 1
del n2[0]
n2 = sorted(n2)
for i in range(m):
    c.insert(0, t % n2[i])
    t = t // n2[i]
c.insert(0, t)
for i in range(len(k2) - 1):
    for j in range(len(c)):
        if c[j] > k2[i + 1]:
            c[j] += 1
print(c)
