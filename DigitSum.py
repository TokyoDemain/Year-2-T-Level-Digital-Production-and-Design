v = float(input("what is the current velocity:    "))
tr = float(input("what is your reaction time:      "))
g = 9.81
mu = 0.7

RD = v*tr
BD = (v*v)/(2*mu*g)

print(RD + BD,"meters")