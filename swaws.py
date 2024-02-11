import sqlite3

ContactBook = sqlite3.connect("ContactBook.db")
cursorCB = ContactBook.cursor()

cursorCB.execute("CREATE TABLE IF NOT EXISTS contactBook2(contactID, ContactFName, contactLName, address, phoneNumber, emailAddress)")
cursorCB.execute("INSERT INTO contactBook2 VALUES('1', 'Bob', 'Dingleberry', '12 Stout Street', '69', 'bobDB@gmail.com')")
cursorCB.execute("INSERT INTO contactBook2 VALUES('2', 'Miquelle', 'Cronkshonk', '3 bigman lane', '235133231231234134233', 'cranglus@gmail.com')")
cursorCB.execute("INSERT INTO contactBook2 VALUES('3', 'Fingle', 'bop', '8 crombobulus drive', '01642 725195', 'crombob8@gmail.com')")
                 


def menu():
    choice = str(input("1) Add new Contact\n2) Search For Contacts\n3) Display all Contact Records\n4) Delete Contact Records\n5) Modify Contact Records\n\n"))

    if choice == "1":
        AddNewContact()
    elif choice == "2":
        SearchForContact()
    elif choice == "3":
        DisplayAllContacts()
    elif choice == "4":
        DeleteContact()
    elif choice == "5":
        ModifyContact()
    else:
        print("You inputed something wrong")
        menu()

def AddNewContact():
    
    name = input("what is the person's first name")
    lname = input("what is the person's last name")
    ContactID = input("what is the person's ID")
    address = input("what is the person's Address")
    phoneNum = input("what is the person's phone number")
    emailAddress = input("what is the person's email address")
    cursorCB.execute("INSERT INTO contactBook2 (contactID, ContactFName, contactLName, address, phoneNumber, emailAddress) VALUES (?,?,?,?,?,?)",(ContactID,name,lname,address,phoneNum,emailAddress))
    print("Saved New Contact")
    menu()
    return

def SearchForContact():
    searchInput = input("What is the Contact ID\n")
    cursorCB.execute("SELECT * FROM contactBook2 WHERE (contactID) = (?)", (searchInput))
    result = cursorCB.fetchall()
    for searchInput in result:
        print(searchInput)
        print("\n")
    menu()
    return

def DisplayAllContacts():
    cursorCB.execute("SELECT * FROM contactBook2")
    result = cursorCB.fetchall()
    for row in result:
        print(row)
    menu()
    return
def DeleteContact():
    deleteID = input("what is the ID of the person you want to delete")
    cursorCB.execute("DELETE FROM contactBook2 WHERE (contactID) = (?)", (deleteID))
    menu()
    return
    
def ModifyContact():
    ChangeID = input("what is the persons ID that you would like to change")
    name = input("what is the person's first name")
    lname = input("what is the person's last name")
    address = input("what is the person's Address")
    phoneNum = input("what is the person's phone number")
    emailAddress = input("what is the person's email address")
    cursorCB.execute("UPDATE contactBook2 SET contactID = {ContactID}, ContactFName = {name}, contactLName={lname}, address = {address}, phoneNumber = {phoneNum}, emailAddress = {emailAddress}, WHERE contactID = {ContactID}".format(
        ContactID=ChangeID,
        name=name,
        lname=lname,
        address=address,
        phoneNum=phoneNum,
        emailAddress=emailAddress
    ))
    print("Contact Changed")
    menu()
    return

menu()
