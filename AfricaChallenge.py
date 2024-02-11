print("""---------------------------
DO YOU THINK YOU CAN NAME ALL
COUNTRIES IN AFRICA
------------------------------""")

countriesInAfrica = ["Algeria", "Angola", "Benin", "Botswana", "Burkina Faso", "Burundi", "Cabo Verde", "Cameroon", "Central African Republic", "Chad", "Comoros", "Ivory Coast", "Djibouti", "Democratic Republic of the Congo", "Egypt", "Equatorial Guinea", "Eritrea", "Eswatini", "Ethiopia", "Gabon", "Gambia", "Ghana", "Guinea", "Guinea-Bissau", "Kenya", "Lesotho", "Liberia", "Libya", "Madagascar", "Malawi", "Mali", "Mauritania", "Mauritius", "Morocco", "Mozambique", "Namibia", "Niger", "Nigeria", "Republic of the Congo", "Rwanda", "Sao Tome & Principe", "Senegal", "Seychelles", "Sierra Leone", "Somalia", "South Africa", "South Sudan", "Sudan", "Tanzania", "Togo", "Tunisia", "Uganda", "Zambia", "Zimbabwe"]
guessed = []
countriesInAfrica = [element.lower() for element in countriesInAfrica]




def makeGuess():
    if len(countriesInAfrica) < 1:
        winGame()

    guess = input("Guess: ")
    if guess in (countriesInAfrica):
        countriesInAfrica.remove(guess)
        guessed.append(guess)
        print("There are", len(countriesInAfrica), "left")
        print("Good Guess")
    else:
        if guess in guessed:
            print("you allready guessed that")
            print("There are", len(countriesInAfrica), "left")
        else:
            print("That is not a country in Africa")
            print("There are", len(countriesInAfrica), "left")
    makeGuess()
        
def winGame():
    print("Congrats, you win")

makeGuess()