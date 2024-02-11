const fs = require("fs");
import * as fs from "fs";
var FirstName = document.getElementById("Fname")
var LastName = document.getElementById("LName")
var DateAndTime = document.getElementById("Date")
var Steps = document.getElementById("Steps")
var database = "Database.json"

function alert2() {
    var FirstName = document.getElementById("Fname")
    var LastName = document.getElementById("LName")
    var DateAndTime = document.getElementById("Date")
    var Steps = document.getElementById("Steps")
    populate()
}
async function populate()
{
    var saveData = {
        FName : FirstName,
        LName : LastName ,
        Date : DateAndTime,
        steps : Steps
    }
    const userJson = JSON.stringify(saveData)
    fs.writeFile("Database.json", userJson (error) => {
        if (error) {}
    })
    
}