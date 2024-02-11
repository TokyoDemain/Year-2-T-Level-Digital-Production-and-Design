import tkinter as tk
import csv as csvreader
#-------------------------------------------LOGIN--------------------------------------------------------------------
def on_login():
    entered_username = username_entry.get()
    entered_password = password_entry.get()
    check = False
    with open("UsernamePassword.csv") as csvFile:
        reader = csvreader.reader(csvFile)
        for row in reader:
            if entered_username == row[0] and entered_password == row[1]:
                check = True
                print("Login successful!")
                open_main_window()
        if check == False:
            print("Login Failed")

def open_main_window():
    # Close the login window
    login_window.destroy()

    # Create the main window
    root = tk.Tk()
    root.title("Dark Theme Grid")

    # Set a dark theme color scheme
    root.configure(bg='#333333')  # Set background color

    # Create four boxes in a 2x2 grid
    for i in range(2):
        for j in range(2):
            box_number = i * 2 + j + 1
            box = tk.Button(root, text=f"Box {box_number}", width=15, height=5, command=lambda n=box_number: on_box_click(n))
            box.grid(row=i, column=j, padx=10, pady=10)

            # Customize the appearance for a dark theme
            box.configure(bg='#666666', fg='#ffffff')  # Set background and text color

    # Start the Tkinter event loop
    root.mainloop()

# Create the login window
login_window = tk.Tk()
login_window.title("Login")

# Set a dark theme color scheme for the login window
login_window.configure(bg='#333333')  # Set background color

# Create username and password entry fields
username_label = tk.Label(login_window, text="Username:", bg='#333333', fg='#ffffff')
username_label.pack(pady=5)
username_entry = tk.Entry(login_window)
username_entry.pack(pady=5)

password_label = tk.Label(login_window, text="Password:", bg='#333333', fg='#ffffff')
password_label.pack(pady=5)
password_entry = tk.Entry(login_window, show="*")
password_entry.pack(pady=5)

# Create login button
login_button = tk.Button(login_window, text="Login", command=on_login)
login_button.pack(pady=10)

# Start the Tkinter event loop for the login window
login_window.mainloop()
#----------------------------------------------MAIN APP-------------------------------------------------------
def on_box_click(box_number):
    print(f"Box {box_number} clicked!")

# Create the main window
root = tk.Tk()
root.title("Dark Theme Grid")

# Set a dark theme color scheme
root.configure(bg='#333333')  # Set background color

# Create four boxes in a 2x2 grid
for i in range(2):
    for j in range(2):
        box_number = i * 2 + j + 1
        box = tk.Button(root, text=f"Box {box_number}", width=15, height=5, command=lambda n=box_number: on_box_click(n))
        box.grid(row=i, column=j, padx=10, pady=10)

        # Customize the appearance for a dark theme
        box.configure(bg='#666666', fg='#ffffff')  # Set background and text color

