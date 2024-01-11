def prog(data):
    a, b, c = data[0]
    sx, sy, sz = data[1]
    fx, fy, fz = data[2]

    f1 = lambda x1, x2, x3, x4: ((x1 - x2) ** 2 + (x3 - x4) ** 2) ** 0.5
    f2 = lambda x1, x2, x3, x4: ((x1 + x2) ** 2 + (x3 - x4) ** 2) ** 0.5
    f3 = lambda x1, x2, x3, x4, x5: ((x1 + x2 + x3) ** 2 + (x4 - x5) ** 2) ** 0.5

    if sx == 0 and fx == 0 or sx == a and fx == a:
        r = f1(sy, fy, sz, fz)
    elif sy == 0 and fy == 0 or sy == b and fy == b:
        r = f1(sx, fx, sz, fz)
    elif sz == 0 and fz == 0 or sz == c and fz == c:
        r = f1(sy, fy, sx, fx)
    elif abs(sx - fx) == a:
         r = min(min(f3(sy, a, fy, sz, fz), f3(b - sy, a, b - fy, sz, fz)), min(f3(sz, a, fz, sy, fy), f3(c - sz, a, c - fz, sy, fy)))
    elif abs(sy - fy) == b:
        r = min(min(f3(sx, b, fx, sz, fz), f3(a - sx, b, a - fx, sz, fz)), min(f3(sz, b, fz, sx, fx), f3(c - sz, b, c - fz, sx, fx)))
    elif abs(sz - fz) == c:
        r = min(min(f3(sx, c, fx, sy, fy), f3(a - sx, c, a - fx, sy, fy)), min(f3(sy, c, fy, sx, fx), f3(b - sy, c, b - fy, sx, fx)))
    elif sx == 0:
        if fz == c:
            r = f2(c - sz, fx, sy, fy)
        if fz == 0:
            r = f2(sz, fx, sy, fy)
        if fy == b:
            r = f2(b - sy, fx, sz, fz)
        if fy == 0:
            r = f2(sy, fx, sz, fz)
    elif sx == a:
        if fz == c:
            r = f2(c - sz, a - fx, sy, fy)
        if fz == 0:
            r = f2(sz, a - fx, sy, fy)
        if fy == b:
            r = f2(b - sy, a - fx, sz, fz)
        if fy == 0:
            r = f2(sy, a - fx, sz, fz)
    elif sy == 0:
        if fz == c:
            r = f2(c - sz, fy, sx, fx)
        if fz == 0:
            r = f2(sz, fy, sx, fx)
        if fx == a:
            r = f2(a - sx, fy, sz, fz)
        if fx == 0:
            r = f2(sx, fy, sz, fz)
    elif sy == b:
        if fz == c:
            r = f2(c - sz, b - fy, sx, fx)
        if fz == 0:
            r = f2(sz, b - fy, sx, fx)
        if fx == a:
            r = f2(a - sx, b - fy, sz, fz)
        if fx == 0:
            r = f2(sx, b - fy, sz, fz)
    elif sz == 0:
        if fx == a:
            r = f2(a - sx, fz, sy, fy)
        if fx == 0:
            r = f2(sx, fz, sy, fy)
        if fy == b:
            r = f2(b - sy, fz, sx, fx)
        if fy == 0:
            r = f2(sy, fz, sx, fx)
    elif sz == c:
        if fx == a:
            r = f2(a - sx, c - fz, sy, fy)
        if fx == 0:
            r = f2(sx, c - fz, sy, fy)
        if fy == b:
            r = f2(b - sy, c - fz, sx, fx)
        if fy == 0:
            r = f2(sy, c - fz, sx, fx)
    return round(r, 3)


for i in range(1, 21):
    strok = f"0{i}" if i < 10 else i
    with open(f"Паук и муха\input_s1_{strok}.txt", encoding="utf8") as file:
        data = file.readlines()
        data = list(map(lambda x: list(map(int, x.rstrip('\n').split())), data))
    with open(f"Паук и муха\output_s1_{strok}.txt", encoding="utf8") as file:
        out = float(file.readline())
        print(i)
        res = prog(data)
        print(data, out, res)
        print(res == out)
        print()
