import random as i

def Main():
    dict = {}
    x = RandomReturn()
    dict[0] = x
    x2 = RandomReturn()
    dict[1] = x2
    x3 = RandomReturn()
    dict[2] = x3
    x4 = RandomReturn()
    dict[3] = x4
    y = loopfunct(dict)
    y2 = loopfunct(dict)
    print (y, y2)
    print(dict)
    print("1. ", dict[0])
    print("2. ", dict[1])
    print("3. ", dict[2])
    print("4. ", dict[3])
    inputBox = input("What is the answer")

def RandomReturn():
    x = i.randint(1, 1000)
    return x

def loopfunct(dict):
    dict1 = dict
    check = 1
    while check == 1:
        x = i.randint(0,3)
        if x in dict1:
            check = 0
        else: 
            check = 1
    return x
    



Main()

