p, k, l, n = [int(x) for x in input('p k l n: ').split()]

out = 0
for i in range(n):
    out += 2 * p + \
          k * 2 + l * 2 + \
          i * l * 2

print(out)

print(2 * n * (p + k + l) + l * n * (n - 1))
