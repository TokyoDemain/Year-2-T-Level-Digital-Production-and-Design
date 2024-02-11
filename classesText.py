class StudentData():
    student_ID = ""
    student_name = ""
    student_class = ""

    def student():
        print("student_name, \nstudent_class, \nstudent_ID\n")
        
    def student_data(self):
        desc_str = "Name: %s\nForm: %s\nID: %s" % (self.student_name, self.student_class, self.student_ID)
        return desc_str
    


student1 = StudentData()
student1.student_ID = "2202787"
student1.student_name = "Tokyo"
student1.student_class = "9C"

student2 = StudentData()
student2.student_ID = "1564234"
student2.student_name = "Joe Marsh"
student2.student_class = "9C"

StudentData.student()
print(student1.student_data(),"\n")
print(student2.student_data())
