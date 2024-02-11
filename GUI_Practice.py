from tkinter import *
from tkinter import messagebox

# Create a dictionary to store login credentials
login_credentials = {"username": "password"}


# Create a function to check login credentials
def check_login():
  username = username_entry.get()
  password = password_entry.get()
  if username in login_credentials and login_credentials[username] == password:
    messagebox.showinfo("Login", "Login successful")
  else:
    messagebox.showerror("Login Error", "Invalid username or password")


# Create a function to add a new user to the login credentials dictionary
def add_user():
  new_username = new_username_entry.get()
  new_password = new_password_entry.get()
  login_credentials[new_username] = new_password
  messagebox.showinfo("Sign Up", "User added successfully")


# Create GUI
root = Tk()
root.title("Login System")

username_label = Label(root, text="Username")
username_label.pack()
username_entry = Entry(root)
username_entry.pack()

password_label = Label(root, text="Password")
password_label.pack()
password_entry = Entry(root, show="*")
password_entry.pack()

login_button = Button(root, text="Login", command=check_login)
login_button.pack()

new_username_label = Label(root, text="New Username")
new_username_label.pack()
new_username_entry = Entry(root)
new_username_entry.pack()

new_password_label = Label(root, text="New Password")
new_password_label.pack()
new_password_entry = Entry(root, show="*")
new_password_entry.pack()

signup_button = Button(root, text="Sign Up", command=add_user)
signup_button.pack()

root.mainloop()
