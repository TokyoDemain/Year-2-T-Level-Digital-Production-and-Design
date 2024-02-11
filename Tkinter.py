from tkinter import *

def clicked():
    print("Clicked")
    temp = entry1.get()
    if temp == "":
        return
    else:
        label1.config(text=temp)
        label1.pack(side="bottom")

app = Tk()
app.title("Button Window")

app.geometry("100x100")
button1 = Button(app, text="Print Clicked", command = clicked)
label1 = Label(app, text="Click the Button")
entry1 = Entry(app)

label1.pack(side="bottom")
button1.pack(side="bottom")
entry1.pack(side="top")
app.mainloop()