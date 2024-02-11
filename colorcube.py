import tkinter as tk
import random

app = tk.Tk()
app.title("GUI Example 4")
app.geometry("100x100")

frameTop = tk.Frame(master=app, width=100, height=50)
frameBottom = tk.Frame(master=app, width=100, height=50)
frameTop.place(x=0, y=0)
frameBottom.place(x=0, y=50)

bA = tk.Label(app, text="A", width=12, bg='red', bd=5)
bB = tk.Label(app, text="B", width=12, bg='yellow')
bC = tk.Label(app, text="C", width=12, bg='blue')
bD = tk.Label(app, text="D", width=12, bg='white')

bA.pack(frameTop, side='top', expand=1)
bB.pack(frameTop, side='bottom')
bC.pack(frameBottom, side='left', fill=Y, expand=1)
bD.pack(frameBottom, side='right')


app.mainloop() 