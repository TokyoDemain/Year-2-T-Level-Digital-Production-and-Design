import python_weather
from aiohttp import ClientSession
import tkinter as tk
import customtkinter
import asyncio
import os
import csv
import hashlib
from pyiqvia import Client
import sqlite3
import APIHandlers
#import required modules


m = hashlib.sha256()
#define the hash
forecastdict = {}
#create a dict variable for later
location = " "
#creates a temporary location string to prevent errors
v = 0
RuntimeDataDict = { "passes" : 0, 
                    "Active" : { 
                      1 : { 
                        "Username" : "Admin" 
                        } 
                        } ,
                    "Pollution Lvl" : 0,
                    "Pollen Lvl" : 0,
                    "Choice" : ""
                  }
#creates a dictionary that stores data about the current run

class App(customtkinter.CTk):
    def __init__(self):
      RuntimeDataDict["Pollen Lvl"] = asyncio.run(APIHandlers.Pollen())
      RuntimeDataDict["Pollution Lvl"] = asyncio.run(APIHandlers.pollution())
      #updates the dictionary with the data about pollen count and pollution levels to ensure that the apis only have to be called once
      combobox_var=1
      super().__init__()
      self.geometry("550x500")
      self.grid_rowconfigure((0), weight=1)
      self.grid_columnconfigure((0,1), weight=1)
      #setting up the app

      self.leftFrame = customtkinter.CTkFrame(self)
      self.leftFrame.grid(row=0, column=0, padx=(0,10), pady=(10,10), sticky="nsw")
      self.rightFrame = customtkinter.CTkScrollableFrame(self, width=350)
      self.rightFrame.grid(row=0, column=1, padx=(0,10), pady=(10,10), sticky="ew")
      #creating and placing the frames on the grid

      self.label = customtkinter.CTkLabel(self.leftFrame, text="View Weather Forecast")
      self.label.grid(row=0, column=0, padx=5, pady=(5,0))
      self.button = customtkinter.CTkButton(self.leftFrame, text="Check Weather", command=self.button_callback, corner_radius=10)
      self.button.grid(row=1, column=0, padx=10, pady=10)
      self.LocationEntry = customtkinter.CTkEntry(self.leftFrame, placeholder_text= "Blank for current", corner_radius=10)
      self.LocationEntry.grid(row=2, column=0, padx=10, pady=10)
      self.combobox = customtkinter.CTkComboBox(self.leftFrame, values=["Daily Forecast", "Hourly Forecast"], command=self.combobox_callback)
      self.combobox.set("Time")
      self.combobox.grid(row=3, column=0, padx=10, pady=10)
      #creating and placing the components of the app in the frames

      self.tabview = TabView(master=self)
      self.tabview._segmented_button.grid(sticky="W")
      self.tabview.grid(row=1, column=0, padx=10, pady=10, columnspan=2, sticky="ew")
      #creates the tab view that is visible at the bottom of the app


    def combobox_callback(master, choice):
      print(choice)
      RuntimeDataDict["Choice"] = choice

    def button_callback(self):
        labellist = []
        intlist = []
        if RuntimeDataDict["Choice"] == "Daily Forecast":
          forecastdict.update(asyncio.run(APIHandlers.getweather(self.LocationEntry.get(), "Daily Forecast")))
        else:
          forecastdict.update(asyncio.run(APIHandlers.getweather(self.LocationEntry.get(), "Hourly Forecast")))
        for i in forecastdict:
          labelTemp = labelForcast(master=self.rightFrame, i=i)
          labellist.append(labelTemp)
          intlist.append(i)
        for i in intlist:
          temp = labellist[i]
          temp.grid(row=i, column=0)

class TabView(customtkinter.CTkTabview):
  def __init__(self, master, **kwargs):
    super().__init__(master, **kwargs)
    self.add("Pollution count")
    self.add("Pollen Count")
    #set up the tab view to be used in the main app

    self.FrameBar = customtkinter.CTkFrame(self.tab("Pollen Count"), bg_color="gray")
    self.label = customtkinter.CTkLabel(master=self.FrameBar, text="Pollen Count")
    self.pollencountbar = customtkinter.CTkProgressBar(master=self.FrameBar, mode="determinate", determinate_speed="0.1")
    self.AdviceBox = scrollFrameAdviceBoxPollen(master=self.tab("Pollen Count"), width=400)
    self.FrameBar.grid(row=0, column=0)
    self.label.grid(row=0, column=0, sticky="new", columnspan=2)
    self.pollencountbar.grid(row=1, column=0, sticky="new", columnspan=2)
    self.pollencountbar.set(int(RuntimeDataDict["Pollen Lvl"])/10)
    #sets the progress of the bar to the pollen index level from the dictionary(data pulled by api) divided by ten
    self.AdviceBox.grid(row=0, column=1, sticky="ne", rowspan=2, padx = 10)
    #populates the second tab

    self.FrameBarPollution = customtkinter.CTkFrame(self.tab("Pollution count"), bg_color="gray")
    self.labelPollution = customtkinter.CTkLabel(master=self.FrameBarPollution, text="Pollution count")
    self.pollutioncountbar = customtkinter.CTkProgressBar(master=self.FrameBarPollution, mode="determinate", determinate_speed="0.1")
    self.AdviceBoxPollution = scrollFrameAdviceBoxPollution(master=self.tab("Pollution count"), width=400)
    self.FrameBarPollution.grid(row=0, column=0)
    self.labelPollution.grid(row=0, column=0, sticky="new", columnspan=2)
    self.pollutioncountbar.grid(row=1, column=0, sticky="new", columnspan=2)
    self.pollutioncountbar.set(int(RuntimeDataDict["Pollution Lvl"])/10)
    #sets the progress of the bar to the pollution index level frothe dictionary(data pulled by api) divided by ten
    self.AdviceBoxPollution.grid(row=0, column=1, sticky="ne", rowspan=2, padx = 10)
    #populates the second tab

class scrollFrameAdviceBoxPollen(customtkinter.CTkScrollableFrame):
  def __init__(self, master, **kwargs):
    super().__init__(master, **kwargs)
    self.grid_columnconfigure((0,1), weight=1)
    #sets up the frame
    connection=sqlite3.connect("Advice.db")
    #connects to the sql database
    cursor=connection.cursor()
    #creates the cursor based of the prior connection
    self.textbox = customtkinter.CTkTextbox(master=self)
    self.textbox.grid(row=0, column=0, sticky="nsew")
    #creates the textbox components that will store the data from the database
    data = cursor.execute("""SELECT AdviceInfo FROM Advice WHERE Unit = "Pollen" AND Lower <= {index}""".format(index = RuntimeDataDict["Pollen Lvl"] * 25)).fetchall()
    #creates a variable that holds the data returned by the database
    out = data[0]
    #creates the variable to store the data
    self.textbox.insert("0.0", out)
    #places the text into the textbox

class scrollFrameAdviceBoxPollution(customtkinter.CTkScrollableFrame): 
  def __init__(self, master, **kwargs):
    super().__init__(master, **kwargs)
    self.grid_columnconfigure((0,1), weight=1)
    #sets up the frame
    connection=sqlite3.connect("Advice.db")
    #connects to the sql database
    cursor=connection.cursor()
    #creates the cursor based of the prior connection
    self.textbox = customtkinter.CTkTextbox(master=self)
    self.textbox.grid(row=0, column=0, sticky="nsew")
    #creates the textbox components that will store the data from the database
    data = cursor.execute("""SELECT AdviceInfo FROM Advice WHERE Unit = "Pollution" AND Lower <= {index}""".format(index = RuntimeDataDict["Pollution Lvl"] * 25)).fetchall()
    #creates a variable that holds the data returned by the database
    out = data[0]
    #creates the variable to store the data
    self.textbox.insert("0.0", out)
    #places the text into the textbox

class labelForcast(customtkinter.CTkFrame):
  def __init__(self, master, i):
    super().__init__(master, i)
    #uses x variable to save how many repetitions it has done
    date = forecastdict[i]["date"]
    temp = forecastdict[i]["temp"]
    snow = forecastdict[i]["snow"]
    #populates the variables based on the dictionary
    if RuntimeDataDict == "Daily Forecast":
      string = "Date: {date},  Temperature: {temp}°C,  Snowfall: {snow}".format(date = date, temp = temp, snow = snow)
    else:
      string = "Time: {date},  Temperature: {temp}°C,  Snowfall: {snow}".format(date = date, temp = temp, snow = snow)
    self.label = customtkinter.CTkLabel(master=self, text=(string))
    self.label.grid(row=0, column=0, padx=10, pady=10)
    #places them in the label and places the label in the frame

class LoginApp(customtkinter.CTk):
  def __init__(self):
    super().__init__()
    UserPassDict = {}
    self.title("Login")
    self.geometry("360x200")
    self.grid_rowconfigure(0, weight=1)
    self.grid_columnconfigure(0, weight=1)
    #Sets up the class
    self.MainFrame = customtkinter.CTkFrame(self)
    self.MainFrame.grid(row=0, column=0, padx=10, pady=10, columnspan=2, rowspan=2)
    #creates and places the main login frame
    self.Title = customtkinter.CTkLabel(self.MainFrame, text="Login")
    self.EntryUser = customtkinter.CTkEntry(self.MainFrame, placeholder_text="Enter Username")
    self.EntryPass = customtkinter.CTkEntry(self.MainFrame, placeholder_text="Enter Password", show="*")
    #creates the components for the function
    def login_button_callback():
      #creates the function called by the login button
      UserAttempt = self.EntryUser.get()
      PassAttempt = self.EntryPass.get()
      #gets the variables from the app
      connection = sqlite3.connect("User.DB")
      cur = connection.cursor()
      try:
        UserAttempt = cur.execute("SELECT Username FROM userpass WHERE PasswordHash == {UserAtt}".format(UserAtt = PassAttempt))
      except
          #reads every row in the file
          try:
            #creates exception handling
            PassAttempt = misc.hasher(PassAttempt)
            #hashes the string ready to compare to the password database
            if UserPassDict[UserAttempt] == PassAttempt:
              #if the username is there and if the value under the key is equal
              ##this will create an error if the username is wrong
              loginApp.destroy()
              #close the login app
              app = App()
              #instance the main app
              app.mainloop()
              #starts the app
            else:
              self.LoginButton.configure(text="Password Wrong", fg_color="red", hover_color="darkred")
              #if the password is wrong, it will inform the user by displaying the above message on the button and changing the colour
          except Exception as error:
            #defines the error variable as the exception
            self.LoginButton.configure(text=error, fg_color="red", hover_color="darkred")
            #configures the login button to change colour and change the error message to the text on the button
            pass

    self.LoginButton = customtkinter.CTkButton(self.MainFrame, command=login_button_callback, text="Login")
    self.Title.grid(row=0, column=0)
    self.EntryUser.grid(row=1, column=0, padx=10, pady=10)
    self.EntryPass.grid(row=2, column=0, padx=10, pady=10)
    self.LoginButton.grid(row=3, column=0, padx=10, pady=10)
    #places the components

    self.SignUpFrame = customtkinter.CTkFrame(self)
    self.SignUpFrame.grid(row=0, column=2, padx=10, pady=10, columnspan=2, rowspan=2)
    #places the sign up frame
    self.TitleSignUp = customtkinter.CTkLabel(self.SignUpFrame, text="Sign Up")
    self.EntryUserS = customtkinter.CTkEntry(self.SignUpFrame, placeholder_text="Enter Username")
    self.EntryPassS = customtkinter.CTkEntry(self.SignUpFrame, placeholder_text="Enter Password", show="*")
    #creates the components for the function

    def signup_button_callback():
      #creates the function that is called when the button is pressed
      UserAttempt = self.EntryUserS.get()
      PassAttempt = self.EntryPassS.get()
      #gets the variables from the app
      if UserAttempt and PassAttempt:
        #checks that the variables are not empty
        with open('LoginDB.csv', "a", newline='') as csvfile:
          #opens the csv
          csvwriter = csv.writer(csvfile, delimiter=',', quotechar='|')
          #defines the writer for easier use
          PassAttempt = misc.hasher(PassAttempt)
          #hashes the password to increase security
          output = ([UserAttempt,PassAttempt])
          #puts the username and the hashed password into one variable
          csvwriter.writerow(output)
          #appends the csv by writing the variable onto a newline on the csv
          OnLoad()
          #triggers the onload command to refresh the dictionary

    self.SignUpButton = customtkinter.CTkButton(self.SignUpFrame, command=signup_button_callback, text="Signup")
    self.TitleSignUp.grid(row=0, column=0)
    self.EntryUserS.grid(row=1, column=0, padx=10, pady=10)
    self.EntryPassS.grid(row=2, column=0, padx=10, pady=10)
    self.SignUpButton.grid(row=3, column=0, padx=10, pady=10)
    #places the components on the sign up frame

    def OnLoad():
      with open('LoginDB.csv', newline='') as csvfile:
        #opens the csv file
        spamreader = csv.reader(csvfile, delimiter=',', quotechar='|')
        for row in spamreader:
          #a for loop for every row
          UserPassDict.update({row[0] : row[1]})
          #adds them to the dictionary
    OnLoad()

class misc:
  def hasher(data):
    #creates a function for hashing
    data = str.encode(data)
    #reassigns the variable to hold the encoded string
    sha256 = hashlib.sha256()
    #defines the hashing algorithm
    sha256.update(data)
    #updates the data by hashing it
    return sha256.hexdigest()
    #returns the hashed data

if __name__ == '__main__':
  if os.name == 'nt':
    asyncio.set_event_loop_policy(asyncio.WindowsSelectorEventLoopPolicy())
    #sets the async policy
  customtkinter.set_appearance_mode("dark")
  #sets the apperance mode
  loginApp = LoginApp()
  #instances the login app
  loginApp.mainloop()
  #starts the main loop

