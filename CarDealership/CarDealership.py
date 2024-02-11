
def menu():
  menuScreen = ("---- *DEALERSHIP NAME* ----\n---- 1. Create Customer ----\n---- 2. Add Car to Customer ----\n---- 3. Search Cars ----\n---- 4. Search Customers ----\n")
  choice = input(menuScreen)
  if choice == "1":
    CutomerAccountSystem()
  elif choice == "2":
    carSelectionSystem()
  elif choice == "3":
    CarSearch()
  elif choice == "4":
    CustomerSearch()
  else:
    print("---- enter a valid input ----")

def CutomerAccountSystem():
  name = str(input("---- What is the customer's name ----\n"))
  address = str(input("---- What is the customer's address ----\n"))
  phoneNumber = str(input("---- What is the customer's phone number ----\n"))
  emailAddress = str(input("---- What is the customer's email address ----\n"))
  f = open("customerDatabase.txt" , "a")
  f.write(name)
  f.write(address)
  f.write(phoneNumber)
  f.write(emailAddress)
  f.write("\n")
  f.close
  print("file closed")

def carSelectionSystem():
  customer = input("What is the customer's name")
  customerDatabase.read(customer)
  
  if customer in customerDatabase:
    next
  else:
    print("---- There is no record of this customer. Please add the customer to the database ----")
    menu()
  
  make = input("What is the car make")
  print(carDatabase[make,x]) 
  #prints the available models for the make inputted
  
  model = input("What is the car model")
  print(carDatabase[make,model,x])
  #prints available colours for the model
  
  colour = input("---- What is the car colour ----")
  
def CarSearch():
  carMake = input("---- What make are you searching for ----")
  carModel = input("---- What model are you searching for ----")
  
  
def CustomerSearch():
  customerName = input("What is the customer's name")
  customerAddress = input("What is the customer's address")
  print("---- ", customerDatabase[CustomerName,customerAddress,x,x,x,x,x], " ----")
  

menu()
