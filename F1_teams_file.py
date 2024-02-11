F1Teams = ["Ferrari","Williams","Haas","Racing Point"]
drivers = ["sebastian Vettel", "Charles Leclerc", "Kevin Magnussen","Lando Norris"]
wages = ["21 million", "17", ]
print("Current bonus Payment.", F1Teams[0])
print("Current rival is", F1Teams[1])
def listchange():
    change0= F1Teams.__delitem__(3)
    global Change1
    Change1= F1Teams.insert(3, "Aston Martin")
    print(F1Teams)
listchange()
def listappend():
    print("Two more teams have been added!")
    F1Teams.append("Red Bull")
    F1Teams.append("Mercedes")
    print(F1Teams)
listappend()
def menu():
    print("\n",F1Teams)
    input1 = input("what team do you want to change?\n")
    match input1:
        case "1":
            locals; change0
            change0= F1Teams.__delitem__(1)
            input2 = ("what name is the team?")
            locals; Change1
            Change1= F1Teams.insert(1, input2)
        case "2":
            locals; change0
            change0= F1Teams.__delitem__(1)
            input2 = ("what name is the team?")
            locals; Change1
            Change1= F1Teams.insert(1, input2)    
        case "3":
            locals; change0
            change0= F1Teams.__delitem__(1)
            input2 = ("what name is the team?")
            locals; Change1
            Change1= F1Teams.insert(1, input2)
        case "4":
            locals; change0
            change0= F1Teams.__delitem__(1)
            input2 = ("what name is the team?")
            locals; Change1
            Change1= F1Teams.insert(1, input2)
        case "5":
            locals; change0
            change0= F1Teams.__delitem__(1)
            input2 = ("what name is the team?")
            locals; Change1
            Change1= F1Teams.insert(1, input2)
menu()