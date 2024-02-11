list = []
print("""-------------------------------------------------
Enter calculation or type 'h' for session history
-------------------------------------------------""")
while True:
    calculation = input()
    if calculation != "h":
        calculation2 = eval(calculation)
        print(calculation2)
        history = calculation, calculation2
        list.append(history)
    else:
        print(list)
    