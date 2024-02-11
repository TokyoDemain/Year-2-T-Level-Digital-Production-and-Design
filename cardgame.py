import random
import csv
colors = ["red", "yellow", "black"]
deck = []
scores = []

class Card:
    def __init__(self, color, number):
        self.color = color
        self.number = number
    def __str__(self):
        return f"{self.color} {self.number}"



def shuffler():
    for x in range(1,11):
        for color in colors:
            card = Card(color, x)
            deck.append(card)
    random.shuffle(deck)

shuffler()

def NumChecker(inputValue):
    bing = inputValue
    bing = bing.number
    return bing

def checker(inputValue):
    bing = inputValue.color
    print(bing)
    return bing
    
def winCheck(score1, score2):
    if score1 > score2:
        print ("Player 1 wins the game")
        win()
    else:
        print ("Player 2 wins the game")
        win()

def win():
    print(scores)
    search_key = input("what is the player that wons name")
    temp = list(scores.items())
    res = [idx for idx, key in enumerate(temp) if key[0] == search_key]
    i = i + 1
    scores[res] = i

        

def takeCard(score1, score2):
    tempscore1 = score1
    tempscore2 = score2
    if len(deck) != 1 and len(deck) != 0:
        newCard1 = deck[0]
        print("player 1: ", newCard1)
        deck.remove(newCard1)
        newCard2 = deck[0]
        print("player 2: ", newCard2)
        deck.remove(newCard2)
        card1Num = NumChecker(newCard1)
        card2num = NumChecker(newCard2)
        card1color = checker(newCard1)
        card2color = checker(newCard2)
        if card1color == "red" and card2color == "black":
            winner = True
        elif card1color == "yellow" and card2color == "red":
            winner = True
        elif card1color == "black" and card2color == "yellow":
            winner = False
        else:
            if card1Num > card2num:
                winner = True
            else:
                winner = False

        if winner == True:
            print("Player 1 wins the round")
            tempscore1 = tempscore1 + 1
            print('player 1 score = ', tempscore1, ' player 2 score = ', tempscore2)
            score1 = tempscore1
            return (tempscore1, tempscore2)
        else:
            print("Player 2 wins the round")
            tempscore2 = tempscore2 + 1
            print('player 1 score = ', tempscore1, ' player 2 score = ', tempscore2)
            score2 = tempscore2
            return (tempscore1, tempscore2)

    else:
        print("No more cards left")
        winCheck(tempscore1, tempscore2)

def menu(score1, score2):
    choice = input("Press Enter To Take a Card")
    score1 , score2 = takeCard(score1, score2)
    score1 = score1
    score2 = score2
    menu(score1, score2)
    
def login(username, password):
    with open("usernamepassword.csv", "r") as csv:
        all_details = [[attr.strip() for attr in line.split(",")]
              for line in csv]
        return any(
               username == details[0] 
               and password == details[1] 
               for details in all_details)

def login_action():
     username = input("Username: ")
     password = input("Password: ")
     if not login(username, password):
         raise ValueError("Username/Password [INCORRECT]")
     return True

def scores_action():
    print (scores)


_USER_ACTIONS = {'l': login_action}, {'s': scores_action}

def main():
    with open ("Scores.csv") as csv:
        for rows in csv:
            scores.append(rows)
    while True:
        action = input("Login/SignUp [TYPE 'L' or 'S']: ").lower()
        if action == "l":
            score1 = 0
            score2 = 0
            menu(score1, score2)
        elif action == "s":
            scores_action()




main()