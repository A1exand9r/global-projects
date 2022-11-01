school_do = 0 
school_posl = 0
sl = {'1a':23, '1b':50, '2a':128, '2b':1, '3a':10, '3b':2}

for i in sl:
    school_do += sl[i]
print('кол-во учащихся до:', school_do)

def a():
    print('a')
    print(sl)
    sl['2b'] = 4
    print(sl)

def b():
    print('b')
    print(sl)
    sl['5c'] = 28
    print(sl)

def c():
    print('c')
    print(sl)
    del sl['3b']
    print(sl)

def d(school_posl):
    print('d')
    for i in sl:
        school_posl += sl[i]
    print('кол-во учащихся после:', school_posl)
    return school_posl 

def e(school_do, d):
    print('e')
    school_do -= d
    if school_do < d:
        print('стало меньше на:', abs(school_do))
    else:
        print('стало больше на:', abs(school_do))
    


if __name__ == '__main__':
    a()
    b()
    c()
    d = d(school_posl)
    e(school_do, d)