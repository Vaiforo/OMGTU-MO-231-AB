import random
import struct

A = 'abcd'
P = [2, 5, 5, 4]
r = 4


def coding(text):
    beg, end = 0, 1
    prob = 1
    k = k1 = 0
    code = ''

    for symbol in text:
        pos = A.find(symbol)
        end = beg * (2 ** r) + prob * sum(P[0:pos + 1])
        beg = beg * (2 ** r) + prob * sum(P[0:pos])
        prob = prob * P[pos]
        k += r
        k1 += r

        while True:
            if end < 2 ** (k - 1):
                k -= 1
                code += '0'
            elif beg >= 2 ** (k - 1):
                beg -= 2 ** (k - 1)
                end -= 2 ** (k - 1)
                k -= 1
                code += '1'
            elif beg % 2 == 0 and end % 2 == 0:
                beg /= 2
                end /= 2
                prob /= 2
                k -= 1
            elif k > 30:
                beg //= 2
                end //= 2
                prob = end - beg
                k -= 1
            else:
                break
    return code


s = ''
for i in range(5):
    ln = random.randint(1, 7)
    for j in range(ln):
        s += random.choice('abcd')
    s += ' '

with open('s.txt', 'w') as f:
    f.write(s)

code = coding(s)

pack = b''
for i in range(0, len(code), 8):
    pack += struct.pack('B', int(code[i:i + 8], 2))

with open('pack_code.txt', 'wb') as f:
    f.write(pack)

with open('pack_code.txt', 'rb') as f:
    unpack = f.read()

code_unpack = ''
for i in unpack:
    code_unpack += '{0:08b}'.format(i)

print(f'Is the original code equal to the code converted from bytes: {code_unpack == code}')
