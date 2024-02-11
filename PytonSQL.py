import sqlite3

connection = sqlite3.connect("aquarium.db")
cursor = connection.cursor()
#create variables
cursor.execute("INSERT INTO fish VALUES ('Sammy', 'shark', 1)")
cursor.execute("INSERT INTO fish VALUES ('jamie', 'cuttlefish', 1)")
cursor.execute("INSERT INTO fish VALUES ('bob', 'clownfish', 3)")
#allows the user to create a new fish
def enterNewFish():
    newFish = input("what is the new fish's name\n")
    newFishSpecies = input("what is the new fish's species\n")
    newFishTankNumber = input("what is the new fish's tank number\n")
    cursor.execute("INSERT INTO fish (name,species,tank_number) VALUES (?,?,?)",(newFish, newFishSpecies, newFishTankNumber))
#allows the user to print all fish
def printAllFish():
    rows=cursor.execute("SELECT name, species, tank_number FROM fish").fetchall()
    print (rows)
#allows the user to find the fish
def findFish():
    target_fish_name = input("what is the fish's name\n")
    rows=cursor.execute("SELECT name, species, tank_number FROM fish WHERE name =?",(target_fish_name,),).fetchall()
#creates a menu for the user to interact with
def menu():
    choice = input("1: Enter New Fish\n2: Print All Fish\n3: findFish\n")
    if choice == "1":
        enterNewFish()
        menu()
    elif choice == "2":
        printAllFish()
        menu()
    elif choice == "3":
        findFish()
        menu()

menu()