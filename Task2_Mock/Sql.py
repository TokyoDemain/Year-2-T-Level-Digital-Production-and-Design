import sqlite3
connection = sqlite3.connect("User.DB")
cur = connection.cursor()

cur.execute(""" 
                CREATE TABLE userpass (Username, PasswordHash)
                """)

connection.commit()